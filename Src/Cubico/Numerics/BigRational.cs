using System;
using System.Diagnostics;
using System.Runtime.InteropServices;

namespace Cubico.Numerics
{
    public unsafe struct BigRational : IComparable<BigRational>, IEquatable<BigRational>
    {
        int _sign;
        uint[] _bits;
        public override int GetHashCode()
        {
            var h = (uint)_sign;
            if (_bits != null) for (int i = _bits.Length; i-- != 0; h = ((h << 7) | (_bits[i] >> 25)) ^ _bits[i]) ;
            return (int)h;
        }
        public override bool Equals(object obj)
        {
            return obj is BigRational && Equals((BigRational)obj);
        }
        public bool Equals(BigRational other)
        {
            if (_sign != other._sign)
            {
                return false;
            }

            if (_bits == null && other._bits == null)
            {
                return true;
            }

            if (_bits == null || other._bits == null || _bits.Length != other._bits.Length)
            {
                return false;
            }

            for (int i = 0, n = _bits.Length; i < n; i++)
            {
                if (_bits[i] != other._bits[i])
                {
                    return false;
                }
            }

            return true;
        }
        public int CompareTo(BigRational other)
        {
            return Compare(this, other);
        }
        public string ToString(int digits)
        {
            fixed (uint* p = _bits)
            {
                Rational c;
                Fix(&c, p);
                var nn = (c._numerator._num > c._denominator._num ? c._numerator._num : c._denominator._num) + 2;
                var p1 = stackalloc uint[nn * 3];
                var p2 = p1 + nn;
                var p3 = p2 + nn;

                for (int i = 0; i < c._numerator._num; i++)
                {
                    p1[i] = c._numerator._ptr[i];
                }

                var n1 = Mod(p1, c._numerator._num, c._denominator._ptr, c._denominator._num, p2);
                var n = n1 >> 16;

                var ss = stackalloc char[2 + n * 10 + digits];
                var ns = 0;
                uint ten = 10;
                Big bten;
                bten._ptr = &ten;
                bten._num = 1;

                if (_sign < 0)
                {
                    ss[ns++] = '-';
                }
                if (n == 1 && p2[0] == 0)
                {
                    ss[ns++] = '0';
                }
                var ab = ns;

                while (n > 1 || p2[0] != 0)
                {
                    n = Mod(p2, n, bten._ptr, 1, p3) >> 16;
                    ss[ns++] = (char)('0' + *p2);
                    var t = p2;
                    p2 = p3;
                    p3 = t;
                }

                for (int i = ab, k = ns - 1; i < k; i++, k--)
                {
                    var t = ss[i];
                    ss[i] = ss[k];
                    ss[k] = t;
                }

                n = n1 & 0xffff;

                for (int x = 0; x < digits && (n > 1 || p1[0] != 0); x++)
                {
                    if (x == 0)
                    {
                        ss[ns++] = '.';
                    }

                    for (int i = 0; i < n + 2; i++)
                    {
                        p2[i] = 0;
                    }
                    Debug.Assert(n + 2 <= nn);

                    var n2 = Multiply(new Big { _ptr = p1, _num = n }, bten, p2);
                    Debug.Assert(n2._num < nn);

                    n = Mod(n2._ptr, n2._num, c._denominator._ptr, c._denominator._num, p1) & 0xffff;
                    ss[ns++] = (char)('0' + *p1);

                    var t = p1;
                    p1 = p2;
                    p2 = t;
                }
                return new string(ss, 0, ns);
            }
        }
        public override string ToString()
        {
            return ToString(128);
        }
        public static BigRational Parse(string str)
        {
            BigRational a = 0, b = a, e = 1, f = 10;
            for (int i = str.Length - 1, c; i >= 0; i--)
            {
                if ((c = str[i]) >= '0' && c <= '9')
                {
                    a += (c - '0') * e;
                    e *= f;
                    continue;
                }
                if (c == '.')
                {
                    b = e;
                }
                else if (c == '-')
                {
                    a = -a;
                }
            }
            if (b._sign != 0)
            {
                a /= b;
            }

            return a;
        }
        public int Sign
        {
            get
            {
                return (_sign >> 31) - (-_sign >> 31);
            }
        }
        public BigRational Numerator
        {
            get
            {
                fixed (uint* p = _bits)
                {
                    Rational c;
                    Fix(&c, p);
                    c._denominator._ptr = (uint*)&c._denominator._num;

                    if (c._sign < 0)
                    {
                        c._sign = 1;
                    }

                    c._denominator._num = 1;
                    Tmp t;
                    t._ptrRational = &c;
                    return t;
                }
            }
        }
        public BigRational Denominator
        {
            get
            {
                fixed (uint* p = _bits)
                {
                    Rational c;
                    Fix(&c, p);
                    c._numerator = c._denominator;
                    c._denominator._ptr = (uint*)&c._denominator._num;
                    c._denominator._num = 1;

                    if (c._sign < 0)
                    {
                        c._sign = 1;
                    }

                    Tmp t;
                    t._ptrRational = &c;
                    return t;
                }
            }
        }
        public static bool operator ==(BigRational a, BigRational b)
        {
            return a.Equals(b);
        }
        public static bool operator !=(BigRational a, BigRational b)
        {
            return !a.Equals(b);
        }
        public static bool operator <=(BigRational a, BigRational b)
        {
            return Compare(a, b) <= 0;
        }
        public static bool operator >=(BigRational a, BigRational b)
        {
            return Compare(a, b) >= 0;
        }
        public static bool operator <(BigRational a, BigRational b)
        {
            return Compare(a, b) < 0;
        }
        public static bool operator >(BigRational a, BigRational b)
        {
            return Compare(a, b) > 0;
        }
        public static BigRational operator -(BigRational value)
        {
            if (value._sign != 0)
            {
                value._sign ^= 1 << 31;
            }

            return value;
        }
        public static implicit operator BigRational(int value)
        {
            var a = (uint)(value < 0 ? -value : value);
            if (a <= 0x7fff)
            {
                BigRational r;
                r._sign = (int)(a << 16) | (value & (1 << 31));
                r._bits = null;
                return r;
            }
            return (Tmp)value;
        }
        public static implicit operator BigRational(float value)
        {
            return (Tmp)value;
        }
        public static implicit operator BigRational(double value)
        {
            return (Tmp)value;
        }
        public static implicit operator BigRational(decimal value)
        {
            return (Tmp)value;
        }
        public static explicit operator double(BigRational value)
        {
            double r;
            if (value._bits == null)
            {
                r = (double)((value._sign & 0x7fff0000) >> 16) / ((value._sign & 0xffff) + 1);
            }
            else
            {
                var na = value._sign & 0x7fffffff;
                var nb = value._bits.Length - na;

                fixed (uint* p = value._bits)
                {
                    r = Double(p, na);
                    if (nb != 0)
                    {
                        r /= Double(p + na, nb);
                    }
                }
            }
            return value._sign < 0 ? -r : r;
        }
        public static explicit operator float(BigRational value)
        {
            return (float)(double)value;
        }
        public static explicit operator long(BigRational value)
        {
            long result;
            if (value._bits == null)
            {
                result = ((value._sign & 0x7fff0000) >> 16) / ((value._sign & 0xffff) + 1);
            }
            else
            {
                fixed (uint* p = value._bits)
                {
                    Rational c;
                    value.Fix(&c, p);
                    var p1 = stackalloc uint[(c._numerator._num << 1) + 1];
                    var p2 = p1 + c._numerator._num;

                    for (int i = 0; i < c._numerator._num; i++)
                    {
                        p1[i] = c._numerator._ptr[i];
                    }

                    var n = Mod(p1, c._numerator._num, c._denominator._ptr, c._denominator._num, p2) >> 16;
                    result = checked((long)*(ulong*)p2);
                    if (n > 2)
                    {
                        throw new OverflowException();
                    }
                }
            }

            return value._sign < 0 ? -result : result;
        }
        public static Tmp operator +(BigRational a, BigRational b)
        {
            fixed (uint* pa = a._bits, pb = b._bits)
            {
                Rational ca, cb;
                a.Fix(&ca, pa);
                b.Fix(&cb, pb);
                return Add(&ca, &cb);
            }
        }
        public static Tmp operator +(BigRational a, Tmp b)
        {
            fixed (uint* p = a._bits)
            {
                Rational c;
                a.Fix(&c, p);
                return Add(&c, b._ptrRational);
            }
        }
        public static Tmp operator +(Tmp a, BigRational b)
        {
            fixed (uint* p = b._bits)
            {
                Rational c;
                b.Fix(&c, p);
                return Add(a._ptrRational, &c);
            }
        }
        public static Tmp operator -(BigRational a, BigRational b)
        {
            fixed (uint* pa = a._bits, pb = b._bits)
            {
                Rational ca, cb;
                a.Fix(&ca, pa);
                b.Fix(&cb, pb);
                cb._sign = -cb._sign;
                return Add(&ca, &cb);
            }
        }
        public static Tmp operator -(BigRational a, Tmp b)
        {
            fixed (uint* p = a._bits)
            {
                Rational c;
                a.Fix(&c, p);
                b._ptrRational->_sign = -b._ptrRational->_sign;
                return Add(&c, b._ptrRational);
            }
        }
        public static Tmp operator -(Tmp a, BigRational b)
        {
            fixed (uint* p = b._bits)
            {
                Rational c;
                b.Fix(&c, p);
                c._sign = -c._sign;
                return Add(a._ptrRational, &c);
            }
        }
        public static Tmp operator *(BigRational a, BigRational b)
        {
            fixed (uint* pa = a._bits, pb = b._bits)
            {
                Rational ca, cb;
                a.Fix(&ca, pa);
                b.Fix(&cb, pb);
                return Multiply(&ca, &cb);
            }
        }
        public static Tmp operator *(BigRational a, Tmp b)
        {
            fixed (uint* p = a._bits)
            {
                Rational c;
                a.Fix(&c, p);
                return Multiply(&c, b._ptrRational);
            }
        }
        public static Tmp operator *(Tmp a, BigRational b)
        {
            fixed (uint* p = b._bits)
            {
                Rational c;
                b.Fix(&c, p);
                return Multiply(a._ptrRational, &c);
            }
        }
        public static Tmp operator /(BigRational a, BigRational b)
        {
            fixed (uint* pa = a._bits, pb = b._bits)
            {
                Rational ca, cb;
                a.Fix(&ca, pa);
                b.Fix(&cb, pb);
                return Divide(&ca, &cb);
            }
        }
        public static Tmp operator /(BigRational a, Tmp b)
        {
            fixed (uint* p = a._bits)
            {
                Rational c;
                a.Fix(&c, p);
                return Divide(&c, b._ptrRational);
            }
        }
        public static Tmp operator /(Tmp a, BigRational b)
        {
            fixed (uint* p = b._bits)
            {
                Rational c;
                b.Fix(&c, p);
                return Divide(a._ptrRational, &c);
            }
        }
        public struct Tmp
        {
            internal Rational* _ptrRational;
            public override int GetHashCode()
            {
                return 0;
            }
            public override bool Equals(object obj)
            {
                throw new NotImplementedException();
            }
            public override string ToString()
            {
                return ((BigRational)this).ToString();
            }
            public int Sign
            {
                get
                {
                    return _ptrRational->_sign;
                }
            }
            internal Tmp(uint* a, int na, uint* b, int nb, int sign)
            {
                for (; na > 1 && a[na - 1] == 0; na--) ;
                for (; nb > 1 && b[nb - 1] == 0; nb--) ; Debug.Assert(sign >= -1 && sign <= 1 && (sign != 0 || (na == 1 && nb == 1 && a[0] == 0)));
                _ptrRational = (Rational*)Alloc(((sizeof(Rational) >> 2) - 2) + na + nb);
                _ptrRational->_numerator._ptr = (uint*)&_ptrRational->_tmp;
                _ptrRational->_denominator._ptr = _ptrRational->_numerator._ptr + na;
                _ptrRational->_numerator._num = na;

                for (int i = 0; i < na; i++)
                    _ptrRational->_numerator._ptr[i] = a[i];
                _ptrRational->_denominator._num = nb;
                for (int i = 0; i < nb; i++)
                    _ptrRational->_denominator._ptr[i] = b[i];

                _ptrRational->_sign = sign;
            }
            public static implicit operator Tmp(int value)
            {
                var p = (Rational*)Alloc(sizeof(Rational) >> 2);
                p->_denominator._ptr = (p->_numerator._ptr = (uint*)&p->_tmp) + (p->_numerator._num = p->_denominator._num = 1);
                p->_numerator._ptr[0] = (uint)(value < 0 ? -value : value);
                p->_denominator._ptr[0] = 1;
                p->_sign = value == 0 ? 0 : value > 0 ? +1 : -1;
                Tmp t;
                t._ptrRational = p;
                return t;
            }
            public static implicit operator Tmp(float value)
            {
                var bits = *(uint*)&value;
                if ((bits & 0x7FFFFFFF) == 0)
                    return 0;

                var man = bits & 0x7FFFFF;
                var exp = (int)(bits >> 23) & 0xFF;
                Debug.Assert(exp != 0); //NaN

                man |= 0x800000;
                exp -= 150;
                int n1 = 1, n2 = 1;

                if (exp > 0)
                {
                    n1 += exp >> 5;
                }
                else
                {
                    n2 += -exp >> 5;
                }

                var p = (Rational*)Alloc(((sizeof(Rational) >> 2) - 2) + n1 + n2);
                p->_numerator._num = 1;
                *(p->_numerator._ptr = (uint*)&p->_tmp) = man;
                p->_denominator._num = 1;
                *(p->_denominator._ptr = p->_numerator._ptr + n1) = 1;

                if (exp > 0)
                {
                    ShiftLeft(&p->_numerator, exp);
                }
                else if (exp < 0)
                {
                    ShiftLeft(&p->_denominator, -exp);
                }

                p->_sign = (bits >> 31) == 0 ? +1 : -1;
                Tmp t;
                t._ptrRational = p;
                return t;
            }
            public static implicit operator Tmp(double value)
            {
                var bits = *(ulong*)&value;
                if ((bits & 0x7FFFFFFFFFFFFFFF) == 0)
                    return 0;

                var man = bits & 0x000FFFFFFFFFFFFF;
                var exp = (int)(bits >> 52) & 0x7FF;
                Debug.Assert(exp != 0 && exp != 0x7FF); //NaN
                man |= 0x0010000000000000;
                exp -= 1075;
                int n1 = (man >> 32) != 0 ? 2 : 1, n2 = 1, s1 = n1, s2 = n2;
                if (exp > 0)
                    n1 += exp >> 5;
                else
                    n2 += -exp >> 5;

                var p = (Rational*)Alloc(((sizeof(Rational) >> 2) - 2) + n1 + n2);
                p->_numerator._num = s1;
                *(ulong*)(p->_numerator._ptr = (uint*)&p->_tmp) = man;
                p->_denominator._num = s2;
                *(p->_denominator._ptr = p->_numerator._ptr + n1) = 1;

                if (exp > 0)
                    ShiftLeft(&p->_numerator, exp);
                else if (exp < 0)
                    ShiftLeft(&p->_denominator, -exp);

                p->_sign = (bits >> 63) == 0 ? +1 : -1;
                Tmp t;
                t._ptrRational = p;
                return t;
            }
            public static implicit operator Tmp(decimal value)
            {
                if (value == 0) return 0;
                var d = 1M; Big a, b; a._ptr = (uint*)&value; b._ptr = (uint*)&d;
                var s = a._ptr[0]; var e = (s >> 16) & 0xff; //0-28
                for (var t = 10UL; ; t = t * t) { if ((e & 1) != 0) d *= t; if ((e >>= 1) == 0) break; } //pow(10, e)
                a._ptr[0] = a._ptr[2]; a._ptr[2] = a._ptr[1]; a._ptr[1] = a._ptr[3];
                b._ptr[0] = b._ptr[2]; b._ptr[2] = b._ptr[1]; b._ptr[1] = b._ptr[3];
                return new Tmp(a._ptr, 3, b._ptr, 3, (s >> 31) == 0 ? +1 : -1);
            }
            public static Tmp operator -(Tmp v)
            {
                v._ptrRational->_sign = -v._ptrRational->_sign;
                return v;
            }
            public static Tmp operator +(Tmp a, Tmp b)
            {
                return Add(a._ptrRational, b._ptrRational);
            }
            public static Tmp operator -(Tmp a, Tmp b)
            {
                b._ptrRational->_sign = -b._ptrRational->_sign;
                var t = Add(a._ptrRational, b._ptrRational);
                b._ptrRational->_sign = -b._ptrRational->_sign;
                return t;
            }
            public static Tmp operator *(Tmp a, Tmp b)
            {
                return Multiply(a._ptrRational, b._ptrRational);
            }
            public static Tmp operator /(Tmp a, Tmp b)
            {
                return Divide(a._ptrRational, b._ptrRational);
            }
            public static bool operator ==(Tmp a, Tmp b)
            {
                return Compare(a, b) == 0;
            }
            public static bool operator !=(Tmp a, Tmp b)
            {
                return Compare(a, b) != 0;
            }
            public static bool operator <=(Tmp a, Tmp b)
            {
                return Compare(a, b) <= 0;
            }
            public static bool operator >=(Tmp a, Tmp b)
            {
                return Compare(a, b) >= 0;
            }
            public static bool operator <(Tmp a, Tmp b)
            {
                return Compare(a, b) < 0;
            }
            public static bool operator >(Tmp a, Tmp b)
            {
                return Compare(a, b) > 0;
            }
            public static implicit operator BigRational(Tmp value)
            {
                BigRational r;
                var a = &value._ptrRational->_numerator;
                var b = &value._ptrRational->_denominator;

                r._sign = 0;
                r._bits = null;
                if (a->_num == 1 && a->_ptr[0] == 0)
                    return r; //0

                Simplify(a, b);
                if (a->_num == 1 && b->_num == 1 && a->_ptr[0] <= 0x7fff && (b->_ptr[0] - 1) <= 0xffff)
                {
                    r._sign = ((int)a->_ptr[0] << 16) | ((int)b->_ptr[0] - 1) | (value._ptrRational->_sign & (1 << 31));
                    return r;
                }

                if (b->_num == 1 && b->_ptr[0] == 1)
                    b->_num = 0;

                r._sign = a->_num;
                r._bits = new uint[a->_num + b->_num]; //the one and only new on the GC heap (except ToString)

                for (int i = 0; i < a->_num; i++)
                    r._bits[i] = a->_ptr[i];

                for (int i = 0; i < b->_num; i++)
                    r._bits[a->_num + i] = b->_ptr[i];

                r._sign |= value._ptrRational->_sign & (1 << 31);

                return r;
            }
            public static explicit operator double(Tmp v)
            {
                var f = Double(v._ptrRational->_numerator._ptr, v._ptrRational->_numerator._num) / Double(v._ptrRational->_denominator._ptr, v._ptrRational->_denominator._num);
                if (v._ptrRational->_sign < 0) f = -f; return f;
            }
        }

        [ThreadStatic]
        static int _imem;
        [ThreadStatic]
        static uint* _pmem;
        static uint* Alloc(int n)
        {
            if (_pmem == null) _pmem = (uint*)Marshal.AllocCoTaskMem(4096 << 2).ToPointer();
            if (_imem + n > 4096) { _imem = 0; if (n > 4096) throw new OutOfMemoryException(); }
            var p = _pmem + _imem; _imem += n; return p;
        }

        static Tmp Add(Rational* a, Rational* b)
        {
            if (a->_sign == 0) return new Tmp(b->_numerator._ptr, b->_numerator._num, b->_denominator._ptr, b->_denominator._num, b->_sign);
            if (b->_sign == 0) return new Tmp(a->_numerator._ptr, a->_numerator._num, a->_denominator._ptr, a->_denominator._num, a->_sign);
            var m1 = a->_numerator._num + b->_denominator._num + 1;
            var m2 = a->_denominator._num + b->_numerator._num + 1;
            var m3 = a->_denominator._num + b->_denominator._num + 1; var m4 = m1 + m2 + m3;
            Tmp t; t._ptrRational = (Rational*)Alloc(((sizeof(Rational) >> 2) - 2) + m4);
            var p1 = (uint*)&t._ptrRational->_tmp; var p2 = p1 + m1; var p3 = p2 + m2;
            for (int i = 0; i < m4; i++) p1[i] = 0;
            var n1 = Multiply(a->_numerator, b->_denominator, p1);
            var n2 = Multiply(a->_denominator, b->_numerator, p2);
            int si; Big s1;
            if (a->_sign > 0 == b->_sign > 0)
            {
                s1 = Add(n1, n2, p1); si = a->_sign;
            }
            else
            {
                si = Compare(n1, n2); if (si == 0) return 0;
                s1 = si > 0 ? Subtract(n1, n2, p1) : Subtract(n2, n1, p1); si = a->_sign == si ? +1 : -1;
            }
            t._ptrRational->_denominator = Multiply(a->_denominator, b->_denominator, p3);
            t._ptrRational->_numerator = s1; t._ptrRational->_sign = si;
            return t;
        }
        static Tmp Multiply(Rational* a, Rational* b)
        {
            if (a->_sign == 0) return 0;
            if (b->_sign == 0) return 0;
            var m1 = a->_numerator._num + b->_numerator._num + 1;
            var m2 = a->_denominator._num + b->_denominator._num + 1; var m3 = m1 + m2;
            Tmp t; t._ptrRational = (Rational*)Alloc(((sizeof(Rational) >> 2) - 2) + m3);
            var p1 = (uint*)&t._ptrRational->_tmp; var p2 = p1 + m1;
            for (int i = 0; i < m3; i++) p1[i] = 0;
            t._ptrRational->_numerator = Multiply(a->_numerator, b->_numerator, p1);
            t._ptrRational->_denominator = Multiply(a->_denominator, b->_denominator, p2);
            t._ptrRational->_sign = a->_sign == b->_sign ? +1 : -1;
            return t;
        }
        static Tmp Divide(Rational* a, Rational* b)
        {
            if (b->_sign == 0) throw new DivideByZeroException();
            var t = b->_numerator; b->_numerator = b->_denominator; b->_denominator = t; return Multiply(a, b);
        }
        static int Compare(Tmp a, Tmp b)
        {
            b._ptrRational->_sign = -b._ptrRational->_sign; var s = Add(a._ptrRational, b._ptrRational)._ptrRational->_sign; b._ptrRational->_sign = -b._ptrRational->_sign; return s;
        }

        static void Simplify(Big* a, Big* b)
        {
            int na; if ((na = a->_num) == 1 && a->_ptr[0] == 1) return;
            int nb; if ((nb = b->_num) == 1 && b->_ptr[0] == 1) return;
            Debug.Assert(!(a->_num == 1 && a->_ptr[0] == 0));
            Debug.Assert(!(b->_num == 1 && b->_ptr[0] == 0));
            if (na <= 2 && nb <= 2)
            {
                Big ca; var ua = (ca._num = na) == 2 ? *(ulong*)a->_ptr : a->_ptr[0]; ca._ptr = (uint*)&ua; var ra = ua;
                Big cb; var ub = (cb._num = nb) == 2 ? *(ulong*)b->_ptr : b->_ptr[0]; cb._ptr = (uint*)&ub; var rb = ub;
                var cc = GreatestCommonDivisor(ca, cb); var d = cc._num != 1 ? *(ulong*)cc._ptr : cc._ptr[0]; if (d == 1) return;
                ra /= d; if ((ra >> 32) != 0) *(ulong*)a->_ptr = ra; else { a->_ptr[0] = (uint)ra; a->_num = 1; }
                rb /= d; if ((rb >> 32) != 0) *(ulong*)b->_ptr = rb; else { b->_ptr[0] = (uint)rb; b->_num = 1; }
                return;
            }
            var p1 = stackalloc uint[(na + nb) << 1]; var p2 = p1 + na;
            Big ba; ba._ptr = p1; ba._num = na; for (int i = 0; i < na; i++) ba._ptr[i] = a->_ptr[i];
            Big bb; bb._ptr = p2; bb._num = nb; for (int i = 0; i < nb; i++) bb._ptr[i] = b->_ptr[i];
            var nr = GreatestCommonDivisor(ba, bb); if (nr._num == 1 && nr._ptr[0] == 1) return;
            var t1 = p2 + nb; var t2 = t1 + na;
            for (int i = 0; i < na; i++) t1[i] = a->_ptr[i];
            for (int i = 0; i < nb; i++) t2[i] = b->_ptr[i];
            a->_num = Mod(t1, na, nr._ptr, nr._num, a->_ptr) >> 16;
            b->_num = Mod(t2, nb, nr._ptr, nr._num, b->_ptr) >> 16;
        }
        static Big GreatestCommonDivisor(Big a, Big b)
        {
            int shift = 0;
            if (a._ptr[0] == 0 || b._ptr[0] == 0)
            {
                int i1 = 0;
                for (; a._ptr[i1] == 0; i1++) ;
                i1 = clz(a._ptr[i1]) + (i1 << 5);
                if (i1 != 0)
                    ShiftRight(&a, i1);

                int i2 = 0;
                for (; b._ptr[i2] == 0; i2++) ;
                i2 = clz(b._ptr[i2]) + (i2 << 5);
                if (i2 != 0)
                    ShiftRight(&b, i2);

                shift = i1 < i2 ? i1 : i2;
            }
            for (;;)
            {
                if (a._num < b._num) { var t = a; a = b; b = t; }
                int max = a._num, min = b._num;
                if (min == 1)
                {
                    if (max != 1)
                    {
                        if (b._ptr[0] == 0) break;
                        ulong u = 0; for (int i = a._num; i-- != 0; u = (u << 32) | a._ptr[i], u %= b._ptr[0]) ;
                        a._num = 1; if (u == 0) { a._ptr[0] = b._ptr[0]; break; }
                        a._ptr[0] = (uint)u;
                    }
                    uint xa = a._ptr[0], xb = b._ptr[0]; for (; (xa > xb ? xa %= xb : xb %= xa) != 0;) ; a._ptr[0] = xa | xb; break;
                }
                if (max == 2)
                {
                    var xa = a._num == 2 ? *(ulong*)a._ptr : a._ptr[0];
                    var xb = b._num == 2 ? *(ulong*)b._ptr : b._ptr[0];
                    for (; (xa > xb ? xa %= xb : xb %= xa) != 0;) ;
                    *(ulong*)a._ptr = xa | xb; a._num = a._ptr[1] != 0 ? 2 : 1; break;
                }
                if (min <= max - 2) { a._num = Mod(a._ptr, a._num, b._ptr, b._num, null); continue; }
                ulong uu1 = a._num >= max ? ((ulong)a._ptr[max - 1] << 32) | a._ptr[max - 2] : a._num == max - 1 ? a._ptr[max - 2] : 0;
                ulong uu2 = b._num >= max ? ((ulong)b._ptr[max - 1] << 32) | b._ptr[max - 2] : b._num == max - 1 ? b._ptr[max - 2] : 0;
                int cbit = chz(uu1 | uu2);
                if (cbit > 0)
                {
                    uu1 = (uu1 << cbit) | (a._ptr[max - 3] >> (32 - cbit));
                    uu2 = (uu2 << cbit) | (b._ptr[max - 3] >> (32 - cbit));
                }
                if (uu1 < uu2) { var t1 = uu1; uu1 = uu2; uu2 = t1; var t2 = a; a = b; b = t2; }
                if (uu1 == 0xffffffffffffffff || uu2 == 0xffffffffffffffff) { uu1 >>= 1; uu2 >>= 1; }
                if (uu1 == uu2) { a = Subtract(a, b, a._ptr); continue; }
                if ((uu2 >> 32) == 0) { a._num = Mod(a._ptr, a._num, b._ptr, b._num, null); continue; }
                uint ma = 1, mb = 0, mc = 0, md = 1;
                for (;;)
                {
                    uint uQuo = 1; ulong uuNew = uu1 - uu2;
                    for (; uuNew >= uu2 && uQuo < 32; uuNew -= uu2, uQuo++) ;
                    if (uuNew >= uu2)
                    {
                        ulong uuQuo = uu1 / uu2; if (uuQuo > 0xffffffff) break;
                        uQuo = (uint)uuQuo; uuNew = uu1 - uQuo * uu2;
                    }
                    ulong uuAdNew = ma + (ulong)uQuo * mc;
                    ulong uuBcNew = mb + (ulong)uQuo * md;
                    if (uuAdNew > 0x7FFFFFFF || uuBcNew > 0x7FFFFFFF) break;
                    if (uuNew < uuBcNew || uuNew + uuAdNew > uu2 - mc) break;
                    ma = (uint)uuAdNew; mb = (uint)uuBcNew;
                    uu1 = uuNew; if (uu1 <= mb) break;
                    uQuo = 1; uuNew = uu2 - uu1;
                    for (; uuNew >= uu1 && uQuo < 32; uuNew -= uu1, uQuo++) ;
                    if (uuNew >= uu1)
                    {
                        ulong uuQuo = uu2 / uu1; if (uuQuo > 0xffffffff) break;
                        uQuo = (uint)uuQuo; uuNew = uu2 - uQuo * uu1;
                    }
                    uuAdNew = md + (ulong)uQuo * mb;
                    uuBcNew = mc + (ulong)uQuo * ma;
                    if (uuAdNew > 0x7FFFFFFF || uuBcNew > 0x7FFFFFFF) break;
                    if (uuNew < uuBcNew || uuNew + uuAdNew > uu1 - mb) break;
                    md = (uint)uuAdNew; mc = (uint)uuBcNew;
                    uu2 = uuNew; if (uu2 <= mc) break;
                }
                if (mb == 0) { if (uu1 / 2 >= uu2) a._num = Mod(a._ptr, a._num, b._ptr, b._num, null); else a = Subtract(a, b, a._ptr); continue; }
                int c1 = 0, c2 = 0; b._num = a._num = min;
                for (int iu = 0; iu < min; iu++)
                {
                    uint u1 = a._ptr[iu], u2 = b._ptr[iu];
                    long nn1 = (long)u1 * ma - (long)u2 * mb + c1; a._ptr[iu] = (uint)nn1; c1 = (int)(nn1 >> 32);
                    long nn2 = (long)u2 * md - (long)u1 * mc + c2; b._ptr[iu] = (uint)nn2; c2 = (int)(nn2 >> 32);
                }
                while (a._num > 1 && a._ptr[a._num - 1] == 0) a._num--;
                while (b._num > 1 && b._ptr[b._num - 1] == 0) b._num--;
            }
            if (shift != 0) ShiftLeft(&a, shift); return a;
        }
        static void ShiftRight(Big* p, int c)
        {
            var s = c & 31;
            var d = c >> 5;
            if (s == 0)
            {
                p->_num -= d;
                for (int i = 0; i < p->_num; i++)
                    p->_ptr[i] = p->_ptr[i + d];
                return;
            }
            var r = 32 - s;
            p->_num -= d + 1;

            for (int i = 0; i < p->_num; i++)
                p->_ptr[i] = (p->_ptr[i + d] >> s) | (p->_ptr[i + d + 1] << r);

            var t = p->_ptr[p->_num + d] >> s;
            if (t != 0)
                p->_ptr[p->_num++] = t;
        }
        static void ShiftLeft(Big* p, int c)
        {
            var s = c & 31;
            var d = c >> 5;
            if (s == 0)
            {
                p->_num += d;
                for (int i = p->_num; i-- > d;)
                    p->_ptr[i] = p->_ptr[i - d];
            }
            else
            {
                var r = 32 - s;
                var l = p->_num;
                var t = p->_ptr[l - 1] >> r;
                if (t != 0)
                {
                    p->_ptr[l + d] = t;
                    p->_num = l + d + 1;
                }
                else
                    p->_num = l + d;

                for (int i = l - 1; i > 0; i--)
                    p->_ptr[i + d] = (p->_ptr[i] << s) | (p->_ptr[i - 1] >> r);

                p->_ptr[d] = p->_ptr[0] << s;
            }
            for (int i = 0; i < d; i++)
                p->_ptr[i] = 0;
        }
        static int chz(uint u)
        {
            int c = 0;
            if ((u & 0xFFFF0000) == 0) { c += 16; u <<= 16; }
            if ((u & 0xFF000000) == 0) { c += 8; u <<= 8; }
            if ((u & 0xF0000000) == 0) { c += 4; u <<= 4; }
            if ((u & 0xC0000000) == 0) { c += 2; u <<= 2; }
            if ((u & 0x80000000) == 0) c += 1; return c;
        }
        static int chz(ulong uu)
        {
            return (uu & 0xFFFFFFFF00000000) == 0 ? 32 + chz((uint)uu) : chz((uint)(uu >> 32));
        }
        static int clz(uint u)
        {
            int c = 0;
            if ((u & 0x0000FFFF) == 0) { c += 16; u >>= 16; }
            if ((u & 0x000000FF) == 0) { c += 8; u >>= 8; }
            if ((u & 0x0000000F) == 0) { c += 4; u >>= 4; }
            if ((u & 0x00000003) == 0) { c += 2; u >>= 2; }
            if ((u & 0x00000001) == 0) c += 1; return c;
        }
        static Big Add(Big a, Big b, uint* p)
        {
            if (a._num < b._num)
            {
                var t = a;
                a = b;
                b = t;
            }

            Big r;
            r._ptr = p;
            r._num = a._num;
            uint c = 0;
            int i = 0;

            for (; i < b._num; i++)
            {
                var u = (ulong)a._ptr[i] + b._ptr[i] + c;
                r._ptr[i] = ((uint*)&u)[0];
                c = ((uint*)&u)[1];
            }

            for (; i < a._num; i++)
            {
                var u = (ulong)a._ptr[i] + c;
                /*    */
                r._ptr[i] = ((uint*)&u)[0];
                c = ((uint*)&u)[1];
            }

            if (c != 0)
                r._ptr[r._num++] = c;

            return r;
        }
        static Big Subtract(Big a, Big b, uint* p)
        {
            Big r;
            r._ptr = p;
            uint c = 0;
            int i = 0;
            Debug.Assert(a._num >= b._num);

            for (; i < b._num; i++)
            {
                var u = (ulong)a._ptr[i] - b._ptr[i] - c;
                r._ptr[i] = ((uint*)&u)[0];
                c = (uint)-((int*)&u)[1];
            }

            for (; i < a._num; i++)
            {
                var u = (ulong)a._ptr[i] /*    */ - c; r._ptr[i] = ((uint*)&u)[0];
                c = (uint)-((int*)&u)[1];
            }

            for (r._num = i; r._num > 1 && r._ptr[r._num - 1] == 0; r._num--) ;
            Debug.Assert(c == 0);
            return r;
        }
        static Big Multiply(Big a, Big b, uint* p)
        {
            Big r;
            r._ptr = p;
            r._num = a._num + b._num - 1;
            if (a._num == 1 && a._ptr[0] == 0)
            {
                *r._ptr = 0;
                r._num = 1;
                return r;
            }

            if (b._num == 1 && b._ptr[0] == 0)
            {
                *r._ptr = 0;
                r._num = 1;
                return r;
            }

            for (int i = a._num, k; i-- != 0;)
            {
                uint c = 0;
                for (k = 0; k < b._num; k++)
                {
                    var t = (ulong)b._ptr[k] * a._ptr[i] + r._ptr[i + k] + c;
                    r._ptr[i + k] = (uint)t;
                    c = (uint)(t >> 32);
                }

                if (c == 0)
                    continue;

                for (k = i + b._num; c != 0 && k < r._num; k++)
                {
                    var t = (ulong)r._ptr[k] + c;
                    r._ptr[k] = (uint)t;
                    c = (uint)(t >> 32);
                }
                if (c == 0)
                    continue;

                r._ptr[r._num++] = c;
            }
            return r;
        }
        static int Mod(uint* a, int na, uint* b, int nb, uint* p)
        {
            if (na < nb) { if (p == null) return na; *p = 0; return na | (1 << 16); }
            if (nb == 1)
            {
                ulong uu = 0, ub = b[0];
                for (int i = na; i-- != 0;)
                {
                    uu = ((ulong)(uint)uu << 32) | a[i];
                    if (p != null)
                        p[i] = (uint)(uu / ub);

                    uu %= ub;
                }
                a[0] = (uint)uu;

                if (p == null)
                    return 1;

                for (; na > 1 && p[na - 1] == 0; na--) ;

                return 1 | (na << 16);
            }
            if (nb == 2 && na == 2)
            {
                if (p != null)
                    *(ulong*)p = *(ulong*)a / *(ulong*)b; *(ulong*)a %= *(ulong*)b;
                if (a[na - 1] == 0)
                    na = 1;
                if (p == null)
                    return na;
                if (p[nb - 1] == 0)
                    nb = 1;

                return (nb << 16) | na;
            }

            int diff = na - nb, nc = diff;
            for (int i = na - 1; ; i--)
            {
                if (i < diff)
                {
                    nc++;
                    break;
                }

                if (b[i - diff] != a[i])
                {
                    if (b[i - diff] < a[i])
                        nc++;
                    break;
                }
            }
            if (nc == 0)
            {
                if (p == null)
                    return na;

                *p = 0;
                return na | (1 << 16);
            }
            uint uden = b[nb - 1], unex = nb > 1 ? b[nb - 2] : 0;
            int shl = chz(uden), shr = 32 - shl;
            if (shl > 0)
            {
                uden = (uden << shl) | (unex >> shr);
                unex <<= shl;
                if (nb > 2) unex |= b[nb - 3] >> shr;
            }
            for (int i = nc; --i >= 0;)
            {
                uint hi = i + nb < na ? a[i + nb] : 0;
                ulong uu = ((ulong)hi << 32) | a[i + nb - 1];
                uint un = i + nb - 2 >= 0 ? a[i + nb - 2] : 0;
                if (shl > 0)
                {
                    uu = (uu << shl) | (un >> shr);
                    un <<= shl;
                    if (i + nb >= 3) un |= a[i + nb - 3] >> shr;
                }
                ulong quo = uu / uden, rem = (uint)(uu % uden);

                if (quo > 0xffffffff)
                {
                    rem += uden * (quo - 0xffffffff);
                    quo = 0xffffffff;
                }

                while (rem <= 0xffffffff && quo * unex > (((ulong)(uint)rem << 32) | un))
                {
                    quo--;
                    rem += uden;
                }

                if (quo > 0)
                {
                    ulong bor = 0;
                    for (int k = 0; k < nb; k++)
                    {
                        bor += b[k] * quo; uint sub = (uint)bor;
                        bor >>= 32;
                        if (a[i + k] < sub)
                            bor++;
                        a[i + k] -= sub;
                    }
                    if (hi < bor)
                    {
                        uint c = 0;
                        for (int k = 0; k < nb; k++)
                        {
                            ulong t = (ulong)a[i + k] + b[k] + c;
                            a[i + k] = (uint)t; c = (uint)(t >> 32);
                        }
                        quo--;
                    }
                    na = i + nb;
                }
                if (p != null) p[i] = (uint)quo;
            }
            for (; na > 1 && a[na - 1] == 0; na--) ; if (p == null) return na;
            for (; nc > 1 && p[nc - 1] == 0; nc--) ; return (nc << 16) | na;
        }
        static int Compare(Big a, Big b)
        {
            if (a._num != b._num)
                return a._num > b._num ? +1 : -1;

            for (var i = a._num; i-- != 0;)
                if (a._ptr[i] != b._ptr[i])
                    return a._ptr[i] > b._ptr[i] ? +1 : -1;

            return 0;
        }
        static int Compare(BigRational a, BigRational b)
        {
            var sa = (a._sign >> 31) - (-a._sign >> 31);
            var sb = (b._sign >> 31) - (-b._sign >> 31);
            if (sa != sb)
                return sa > sb ? +1 : -1;
            if (sa == 0)
                return 0;
            fixed (uint* pa = a._bits, pb = b._bits)
            {
                Rational aa, bb;
                a.Fix(&aa, pa);
                b.Fix(&bb, pb);
                var sn = Compare(aa._numerator, bb._numerator);
                var sd = Compare(aa._denominator, bb._denominator);

                if (sd == 0)
                    return +sn * sa;

                if (sn == 0)
                    return -sd * sa;

                if (sn > 0 && sd < 0)
                    return +sa;

                if (sd < 0 && sn > 0)
                    return -sa;

                var m1 = aa._numerator._num + bb._denominator._num + 1;
                var m2 = aa._denominator._num + bb._numerator._num + 1;
                var p1 = stackalloc uint[m1 + m2];
                var p2 = p1 + m1;
                var n1 = Multiply(aa._numerator, bb._denominator, p1);
                var n2 = Multiply(aa._denominator, bb._numerator, p2);
                return Compare(n1, n2) * sa;
            }
        }

        static double Double(uint* p, int n)
        {
            if (n == 1)
                return p[0];

            if (n == 2)
                return *(ulong*)p;

            var man = ((ulong)p[n - 1] << 32) | p[n - 2];
            var exp = (n - 2) * 32;
            int cbit;

            if ((cbit = chz(p[n - 1])) > 0)
            {
                man = (man << cbit) | (p[n - 3] >> (32 - cbit));
                exp -= cbit;
            }

            if (man == 0)
            {
                return 0;
            }

            ulong uu;
            int csh = chz(man) - 11;

            if (csh < 0)
            {
                man >>= -csh;
            }
            else
            {
                man <<= csh;
            }

            exp -= csh;
            exp += 1075;

            if (exp >= 0x7FF)
            {
                uu = 0x7FF0000000000000;
            }
            else if (exp <= 0)
            {
                exp--;
                if (exp < -52)
                {
                    uu = 0;
                }
                else
                {
                    uu = man >> -exp;
                }
            }
            else
            {
                uu = (man & 0x000FFFFFFFFFFFFF) | ((ulong)exp << 52);
            }

            return *(double*)&uu;
        }

        internal struct Big
        {
            internal uint* _ptr;
            internal int _num;
            public override string ToString()
            {
                Rational c;
                c._sign = 1;
                c._numerator = this;
                c._denominator._ptr = (uint*)&c._denominator._num;
                c._denominator._num = 1;

                Tmp t;
                t._ptrRational = &c;
                return ((BigRational)t).ToString();
            }
        }
        internal struct Rational
        {
            internal int _sign;
            internal Big _numerator, _denominator;
            internal ulong _tmp;
            public override string ToString()
            {
                Rational c = this;
                Tmp t;
                t._ptrRational = &c;

                var p1 = stackalloc uint[_numerator._num + _denominator._num];
                var p2 = p1 + _numerator._num;

                for (int i = 0; i < _numerator._num; i++)
                {
                    p1[i] = _numerator._ptr[i];
                    c._numerator._ptr = p1;
                }

                for (int i = 0; i < _denominator._num; i++)
                {
                    p2[i] = _denominator._ptr[i];
                    c._denominator._ptr = p2;
                }

                return ((BigRational)t).ToString();
            }
        }

        void Fix(Rational* ptrRational, uint* t)
        {
            ptrRational->_sign = (_sign >> 31) - (-_sign >> 31);

            if ((ptrRational->_numerator._ptr = t) == null)
            {
                ptrRational->_numerator._ptr = (ptrRational->_denominator._ptr = (uint*)&ptrRational->_tmp) + (ptrRational->_numerator._num = ptrRational->_denominator._num = 1);
                ptrRational->_numerator._ptr[0] = ((uint)_sign >> 16) & 0x7fff;
                ptrRational->_denominator._ptr[0] = ((uint)_sign & 0xffff) + 1;
                return;
            }

            ptrRational->_numerator._num = _sign & 0x7fffffff;
            ptrRational->_denominator._num = _bits.Length - ptrRational->_numerator._num;

            if (ptrRational->_denominator._num != 0)
            {
                ptrRational->_denominator._ptr = ptrRational->_numerator._ptr + ptrRational->_numerator._num;
            }
            else
            {
                *(ptrRational->_denominator._ptr = (uint*)&ptrRational->_tmp) = 1;
                ptrRational->_denominator._num = 1;
            }
        }
    }
}
