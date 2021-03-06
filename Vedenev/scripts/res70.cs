 //##################################################################################################
    /// <summary>
    /// ��������� ��������� 58 f(x) = arctg(x) � arcctg(1/x)
    /// </summary>
    /// <param name="x">������������� �����</param>
    /// <returns>0</returns>
    [OpaqueFunction()]
    [FunctionName("L00_58_1_arctg_arcctg", "f(x) = arctg(x) � arcctg(1/x)")]
    [EquivalentIntConstant(0)]
    public static class CL00_58_1_arctg_arcctg
    {
        public static double Body(double x)
        {            
            double  X = 1, Y1, Y2;
            Y1 = Math.Atan(x);
Y2 = Math.PI/2 - Math.Atan(1/x);
X = Y1 - Y2;
            return X;
        }
    }
    /// <summary>
    /// ��������� ��������� 58 f(x) = arctg(x) � arcctg(1/x),
    /// ����������� ������� �������� ����� ����� X - ��������� ��������� ����� ����� ��������� ���� �� ���� ������� ���,
    /// ������� ������ �������� <paramref name="count"/>.
    /// </summary>
    /// <param name="x">������������� �����</param>
    /// <param name="count">���������� ��������� ������������</param>
    /// <returns>0</returns>
    [OpaqueFunction()]
    [FunctionName("L00_58_2_arctg_arcctg", "f(x) = arctg(x) � arcctg(1/x)")]
    [EquivalentIntConstant(0)]
    public static class CL00_58_2_arctg_arcctg
    {
        public static double Body(double x, int count)
        {
            double  X = 1, Y1, Y2;
            for (int i = 0; i < count; ++i) {
                Y1 = Math.Atan(x);
Y2 = Math.PI/2 - Math.Atan(1/x);
X = Y1 - Y2;
            }
            return X;
        }
    }
    /// <summary>
    /// ���������� ������� ����������� ��������� 58 f(x) = arctg(x) � arcctg(1/x)
    /// </summary>    
    /// <returns>(0, w)</returns>
    [OpaqueFunction()]
    [FunctionName("L00_58_1_arctg_arcctg_in", "(0, w)")]
    public static class CL00_58_1_arctg_arcctg_in
    {
        public static string Body()
        {
            return "(0, w)";
        }
    }


    
    //##################################################################################################
    /// <summary>
    /// ��������� ��������� 59 f(x) = arctg(x) � arccos(1/((1+x*x)^1/2))
    /// </summary>
    /// <param name="x">������������� �����</param>
    /// <returns>0</returns>
    [OpaqueFunction()]
    [FunctionName("L00_59_1_arctg_arccos", "f(x) = arctg(x) � arccos(1/((1+x*x)^1/2))")]
    [EquivalentIntConstant(0)]
    public static class CL00_59_1_arctg_arccos
    {
        public static double Body(double x)
        {            
            double  X = 1, Y1, Y2, Y3, Y4;
            Y1 = Math.Atan(x);
Y3 = 1+x*x;
Y2 = Math.Pow(Y3, 1/2);
Y4 = 1/Y2;
Y3 = Math.Acos(Y4);
X = Y1 - Y3;
            return X;
        }
    }
    /// <summary>
    /// ��������� ��������� 59 f(x) = arctg(x) � arccos(1/((1+x*x)^1/2)),
    /// ����������� ������� �������� ����� ����� X - ��������� ��������� ����� ����� ��������� ���� �� ���� ������� ���,
    /// ������� ������ �������� <paramref name="count"/>.
    /// </summary>
    /// <param name="x">������������� �����</param>
    /// <param name="count">���������� ��������� ������������</param>
    /// <returns>0</returns>
    [OpaqueFunction()]
    [FunctionName("L00_59_2_arctg_arccos", "f(x) = arctg(x) � arccos(1/((1+x*x)^1/2))")]
    [EquivalentIntConstant(0)]
    public static class CL00_59_2_arctg_arccos
    {
        public static double Body(double x, int count)
        {
            double  X = 1, Y1, Y2, Y3, Y4;
            for (int i = 0; i < count; ++i) {
                Y1 = Math.Atan(x);
Y3 = 1+x*x;
Y2 = Math.Pow(Y3, 1/2);
Y4 = 1/Y2;
Y3 = Math.Acos(Y4);
X = Y1 - Y3;
            }
            return X;
        }
    }
    /// <summary>
    /// ���������� ������� ����������� ��������� 59 f(x) = arctg(x) � arccos(1/((1+x*x)^1/2))
    /// </summary>    
    /// <returns>(0, w)</returns>
    [OpaqueFunction()]
    [FunctionName("L00_59_1_arctg_arccos_in", "(0, w)")]
    public static class CL00_59_1_arctg_arccos_in
    {
        public static string Body()
        {
            return "(0, w)";
        }
    }


    
    //##################################################################################################
    /// <summary>
    /// ��������� ��������� 60 f(x) = arcctg(1/x) - arccos(1/((1+x*x)^1/2))
    /// </summary>
    /// <param name="x">������������� �����</param>
    /// <returns>0</returns>
    [OpaqueFunction()]
    [FunctionName("L00_60_1_arcctg_arccos", "f(x) = arcctg(1/x) - arccos(1/((1+x*x)^1/2))")]
    [EquivalentIntConstant(0)]
    public static class CL00_60_1_arcctg_arccos
    {
        public static double Body(double x)
        {            
            double  X = 1, Y1, Y2, Y3;
            Y1 = Math.PI/2 - Math.Atan(1/x);
Y2 = 1/Math.Pow(1+x*x, 1/2);
Y3 = Math.Acos(Y2);
X = Y1 - Y3;
            return X;
        }
    }
    /// <summary>
    /// ��������� ��������� 60 f(x) = arcctg(1/x) - arccos(1/((1+x*x)^1/2)),
    /// ����������� ������� �������� ����� ����� X - ��������� ��������� ����� ����� ��������� ���� �� ���� ������� ���,
    /// ������� ������ �������� <paramref name="count"/>.
    /// </summary>
    /// <param name="x">������������� �����</param>
    /// <param name="count">���������� ��������� ������������</param>
    /// <returns>0</returns>
    [OpaqueFunction()]
    [FunctionName("L00_60_2_arcctg_arccos", "f(x) = arcctg(1/x) - arccos(1/((1+x*x)^1/2))")]
    [EquivalentIntConstant(0)]
    public static class CL00_60_2_arcctg_arccos
    {
        public static double Body(double x, int count)
        {
            double  X = 1, Y1, Y2, Y3;
            for (int i = 0; i < count; ++i) {
                Y1 = Math.PI/2 - Math.Atan(1/x);
Y2 = 1/Math.Pow(1+x*x, 1/2);
Y3 = Math.Acos(Y2);
X = Y1 - Y3;
            }
            return X;
        }
    }
    /// <summary>
    /// ���������� ������� ����������� ��������� 60 f(x) = arcctg(1/x) - arccos(1/((1+x*x)^1/2))
    /// </summary>    
    /// <returns>(0, w)</returns>
    [OpaqueFunction()]
    [FunctionName("L00_60_1_arcctg_arccos_in", "(0, w)")]
    public static class CL00_60_1_arcctg_arccos_in
    {
        public static string Body()
        {
            return "(0, w)";
        }
    }


    
    //##################################################################################################
    /// <summary>
    /// ��������� ��������� 61 f(x) = arcctg(x) - arccos(x/((1+x*x)^1/2))
    /// </summary>
    /// <param name="x">������������� �����</param>
    /// <returns>0</returns>
    [OpaqueFunction()]
    [FunctionName("L00_61_1_arcctg_arccos", "f(x) = arcctg(x) - arccos(x/((1+x*x)^1/2))")]
    [EquivalentIntConstant(0)]
    public static class CL00_61_1_arcctg_arccos
    {
        public static double Body(double x)
        {            
            double  X = 1, Y1, Y2, Y3;
            Y1 = Math.PI/2 - Math.Atan(x);
Y2 = x/Math.Pow(1+x*x, 1/2);
Y3 = Math.Acos(Y2);
X = Y1 - Y3;
            return X;
        }
    }
    /// <summary>
    /// ��������� ��������� 61 f(x) = arcctg(x) - arccos(x/((1+x*x)^1/2)),
    /// ����������� ������� �������� ����� ����� X - ��������� ��������� ����� ����� ��������� ���� �� ���� ������� ���,
    /// ������� ������ �������� <paramref name="count"/>.
    /// </summary>
    /// <param name="x">������������� �����</param>
    /// <param name="count">���������� ��������� ������������</param>
    /// <returns>0</returns>
    [OpaqueFunction()]
    [FunctionName("L00_61_2_arcctg_arccos", "f(x) = arcctg(x) - arccos(x/((1+x*x)^1/2))")]
    [EquivalentIntConstant(0)]
    public static class CL00_61_2_arcctg_arccos
    {
        public static double Body(double x, int count)
        {
            double  X = 1, Y1, Y2, Y3;
            for (int i = 0; i < count; ++i) {
                Y1 = Math.PI/2 - Math.Atan(x);
Y2 = x/Math.Pow(1+x*x, 1/2);
Y3 = Math.Acos(Y2);
X = Y1 - Y3;
            }
            return X;
        }
    }
    /// <summary>
    /// ���������� ������� ����������� ��������� 61 f(x) = arcctg(x) - arccos(x/((1+x*x)^1/2))
    /// </summary>    
    /// <returns>(0, w)</returns>
    [OpaqueFunction()]
    [FunctionName("L00_61_1_arcctg_arccos_in", "(0, w)")]
    public static class CL00_61_1_arcctg_arccos_in
    {
        public static string Body()
        {
            return "(0, w)";
        }
    }


    
    //##################################################################################################
    /// <summary>
    /// ��������� ��������� 62 f(x) = arcctg(x) � arcsin(1/((1+x*x)^1/2))
    /// </summary>
    /// <param name="x">������������� �����</param>
    /// <returns>0</returns>
    [OpaqueFunction()]
    [FunctionName("L00_62_1_arctg_arcsin", "f(x) = arcctg(x) � arcsin(1/((1+x*x)^1/2))")]
    [EquivalentIntConstant(0)]
    public static class CL00_62_1_arctg_arcsin
    {
        public static double Body(double x)
        {            
            double  X = 1, Y1, Y2, Y3;
            Y1 = Math.PI/2 - Math.Atan(1/x);
Y2 = 1/Math.Pow(1+x*x, 1/2);
Y3 = Math.Asin(Y2);
X = Y1 - Y3;
            return X;
        }
    }
    /// <summary>
    /// ��������� ��������� 62 f(x) = arcctg(x) � arcsin(1/((1+x*x)^1/2)),
    /// ����������� ������� �������� ����� ����� X - ��������� ��������� ����� ����� ��������� ���� �� ���� ������� ���,
    /// ������� ������ �������� <paramref name="count"/>.
    /// </summary>
    /// <param name="x">������������� �����</param>
    /// <param name="count">���������� ��������� ������������</param>
    /// <returns>0</returns>
    [OpaqueFunction()]
    [FunctionName("L00_62_2_arctg_arcsin", "f(x) = arcctg(x) � arcsin(1/((1+x*x)^1/2))")]
    [EquivalentIntConstant(0)]
    public static class CL00_62_2_arctg_arcsin
    {
        public static double Body(double x, int count)
        {
            double  X = 1, Y1, Y2, Y3;
            for (int i = 0; i < count; ++i) {
                Y1 = Math.PI/2 - Math.Atan(1/x);
Y2 = 1/Math.Pow(1+x*x, 1/2);
Y3 = Math.Asin(Y2);
X = Y1 - Y3;
            }
            return X;
        }
    }
    /// <summary>
    /// ���������� ������� ����������� ��������� 62 f(x) = arcctg(x) � arcsin(1/((1+x*x)^1/2))
    /// </summary>    
    /// <returns>(0, w)</returns>
    [OpaqueFunction()]
    [FunctionName("L00_62_1_arctg_arcsin_in", "(0, w)")]
    public static class CL00_62_1_arctg_arcsin_in
    {
        public static string Body()
        {
            return "(0, w)";
        }
    }


    
    //##################################################################################################
    /// <summary>
    /// ��������� ��������� 63 f(x) = cos(2x) � 2*cos(x)*cos(x) + 1
    /// </summary>
    /// <param name="x">���� � ��������</param>
    /// <returns>0</returns>
    [OpaqueFunction()]
    [FunctionName("L00_63_1_cos", "f(x) = cos(2x) � 2*cos(x)*cos(x) + 1")]
    [EquivalentIntConstant(0)]
    public static class CL00_63_1_cos
    {
        public static double Body(double x)
        {            
            double  Y1, Y2, Y3, X = 1;
            Y3 = 2*x;
Y1 = Math.Cos(Y3);
Y2 = Math.Cos(x);
X = Y1 - 2*Y2*Y2 + 1;
            return X;
        }
    }
    /// <summary>
    /// ��������� ��������� 63 f(x) = cos(2x) � 2*cos(x)*cos(x) + 1,
    /// ����������� ������� �������� ����� ����� X - ��������� ��������� ����� ����� ��������� ���� �� ���� ������� ���,
    /// ������� ������ �������� <paramref name="count"/>.
    /// </summary>
    /// <param name="x">���� � ��������</param>
    /// <param name="count">���������� ��������� ������������</param>
    /// <returns>0</returns>
    [OpaqueFunction()]
    [FunctionName("L00_63_2_cos", "f(x) = cos(2x) � 2*cos(x)*cos(x) + 1")]
    [EquivalentIntConstant(0)]
    public static class CL00_63_2_cos
    {
        public static double Body(double x, int count)
        {
            double  Y1, Y2, Y3, X = 1;
            for (int i = 0; i < count; ++i) {
                Y3 = 2*x;
Y1 = Math.Cos(Y3);
Y2 = Math.Cos(x);
X = Y1 - 2*Y2*Y2 + 1;
            }
            return X;
        }
    }
    /// <summary>
    /// ���������� ������� ����������� ��������� 63 f(x) = cos(2x) � 2*cos(x)*cos(x) + 1
    /// </summary>    
    /// <returns>(w, w)</returns>
    [OpaqueFunction()]
    [FunctionName("L00_63_1_cos_in", "(0, w)")]
    public static class CL00_63_1_cos_in
    {
        public static string Body()
        {
            return "(w, w)";
        }
    }


    
    //##################################################################################################
    /// <summary>
    /// ��������� ��������� 64 f(x) = cos(2x) � 1 + 2*sin(x)*sin(x)
    /// </summary>
    /// <param name="x">���� � ��������</param>
    /// <returns>0</returns>
    [OpaqueFunction()]
    [FunctionName("L00_64_1_cos_sin", "f(x) = cos(2x) � 1 + 2*sin(x)*sin(x)")]
    [EquivalentIntConstant(0)]
    public static class CL00_64_1_cos_sin
    {
        public static double Body(double x)
        {            
            double  Y1, Y2, Y3, X = 1;
            Y3 = 2*x;
Y1 = Math.Cos(Y3);
Y2 = Math.Sin(x);
X = Y1 - 1 + 2*Y2*Y2;
            return X;
        }
    }
    /// <summary>
    /// ��������� ��������� 64 f(x) = cos(2x) � 1 + 2*sin(x)*sin(x),
    /// ����������� ������� �������� ����� ����� X - ��������� ��������� ����� ����� ��������� ���� �� ���� ������� ���,
    /// ������� ������ �������� <paramref name="count"/>.
    /// </summary>
    /// <param name="x">���� � ��������</param>
    /// <param name="count">���������� ��������� ������������</param>
    /// <returns>0</returns>
    [OpaqueFunction()]
    [FunctionName("L00_64_2_cos_sin", "f(x) = cos(2x) � 1 + 2*sin(x)*sin(x)")]
    [EquivalentIntConstant(0)]
    public static class CL00_64_2_cos_sin
    {
        public static double Body(double x, int count)
        {
            double  Y1, Y2, Y3, X = 1;
            for (int i = 0; i < count; ++i) {
                Y3 = 2*x;
Y1 = Math.Cos(Y3);
Y2 = Math.Sin(x);
X = Y1 - 1 + 2*Y2*Y2;
            }
            return X;
        }
    }
    /// <summary>
    /// ���������� ������� ����������� ��������� 64 f(x) = cos(2x) � 1 + 2*sin(x)*sin(x)
    /// </summary>    
    /// <returns>(w, w)</returns>
    [OpaqueFunction()]
    [FunctionName("L00_64_1_cos_sin_in", "(0, w)")]
    public static class CL00_64_1_cos_sin_in
    {
        public static string Body()
        {
            return "(w, w)";
        }
    }


    
    //##################################################################################################
    /// <summary>
    /// ��������� ��������� 65 f(x) = tg(x) � 1/(tg(PI/2-x))
    /// </summary>
    /// <param name="x">���� � ��������</param>
    /// <returns>0</returns>
    [OpaqueFunction()]
    [FunctionName("L00_65_1_tg", "f(x) = tg(x) � 1/(tg(PI/2-x))")]
    [EquivalentIntConstant(0)]
    public static class CL00_65_1_tg
    {
        public static double Body(double x)
        {            
            double  Y1, Y2, Y3, X = 1;
            Y1 = Math.Tan(x);
Y2 = Math.PI/2 - x;
Y3 = Math.Tan(Y2);
X = Y1 - 1/Y3;
            return X;
        }
    }
    /// <summary>
    /// ��������� ��������� 65 f(x) = tg(x) � 1/(tg(PI/2-x)),
    /// ����������� ������� �������� ����� ����� X - ��������� ��������� ����� ����� ��������� ���� �� ���� ������� ���,
    /// ������� ������ �������� <paramref name="count"/>.
    /// </summary>
    /// <param name="x">���� � ��������</param>
    /// <param name="count">���������� ��������� ������������</param>
    /// <returns>0</returns>
    [OpaqueFunction()]
    [FunctionName("L00_65_2_tg", "f(x) = tg(x) � 1/(tg(PI/2-x))")]
    [EquivalentIntConstant(0)]
    public static class CL00_65_2_tg
    {
        public static double Body(double x, int count)
        {
            double  Y1, Y2, Y3, X = 1;
            for (int i = 0; i < count; ++i) {
                Y1 = Math.Tan(x);
Y2 = Math.PI/2 - x;
Y3 = Math.Tan(Y2);
X = Y1 - 1/Y3;
            }
            return X;
        }
    }
    /// <summary>
    /// ���������� ������� ����������� ��������� 65 f(x) = tg(x) � 1/(tg(PI/2-x))
    /// </summary>    
    /// <returns>(w, w)</returns>
    [OpaqueFunction()]
    [FunctionName("L00_65_1_tg_in", "(0, w)")]
    public static class CL00_65_1_tg_in
    {
        public static string Body()
        {
            return "(w, w)";
        }
    }


    
    //##################################################################################################
    /// <summary>
    /// ��������� ��������� 66 f(x) = tg(x) � (tg(a) + tg(x-a)/(1 � tg(a)*tg(x-a))
    /// </summary>
    /// <param name="x">���� � ��������</param>
	/// <param name="y">������������ ��������</param>
    /// <returns>0</returns>
    [OpaqueFunction()]
    [FunctionName("L00_66_2_tg", "f(x) = tg(x) � (tg(a) + tg(x-a)/(1 � tg(a)*tg(x-a))")]
    [EquivalentIntConstant(0)]
    public static class CL00_66_2_tg
    {
        public static double Body(double x, double y)
        {            
            double  Y1, Y2, Y3, X = 1;
            Y1 = x - y;
Y2 = Math.Tan(x);
Y3 = Math.Tan(Y1);
X = Y2-(Y2 + Y3)/(1 - Y2*Y3);
            return X;
        }
    }
    /// <summary>
    /// ��������� ��������� 66 f(x) = tg(x) � (tg(a) + tg(x-a)/(1 � tg(a)*tg(x-a)),
    /// ����������� ������� �������� ����� ����� X - ��������� ��������� ����� ����� ��������� ���� �� ���� ������� ���,
    /// ������� ������ �������� <paramref name="count"/>.
    /// </summary>
    /// <param name="x">���� � ��������</param>
	/// <param name="y">������������ ��������</param>
    /// <param name="count">���������� ��������� ������������</param>
    /// <returns>0</returns>
    [OpaqueFunction()]
    [FunctionName("L00_66_3_tg", "f(x) = tg(x) � (tg(a) + tg(x-a)/(1 � tg(a)*tg(x-a))")]
    [EquivalentIntConstant(0)]
    public static class CL00_66_3_tg
    {
        public static double Body(double x, double y, int count)
        {
            double  Y1, Y2, Y3, X = 1;
            for (int i = 0; i < count; ++i) {
                Y1 = x - y;
Y2 = Math.Tan(x);
Y3 = Math.Tan(Y1);
X = Y2-(Y2 + Y3)/(1 - Y2*Y3);
            }
            return X;
        }
    }
    /// <summary>
    /// ���������� ������� ����������� ��������� 66 f(x) = tg(x) � (tg(a) + tg(x-a)/(1 � tg(a)*tg(x-a))
    /// </summary>    
    /// <returns>(w, w) (w, w)</returns>
    [OpaqueFunction()]
    [FunctionName("L00_66_2_tg_in", "(0, w)")]
    public static class CL00_66_2_tg_in
    {
        public static string Body()
        {
            return "(w, w) (w, w)";
        }
    }	



   //##################################################################################################
    /// <summary>
    /// ��������� ��������� 67 f(x) = ch(x)*ch(x) � sh(x)*sh(x) � 1
    /// </summary>
    /// <param name="x">���� � ��������</param>
    /// <returns>0</returns>
    [OpaqueFunction()]
    [FunctionName("L00_67_1_ch_sh", "f(x) = ch(x)*ch(x) � sh(x)*sh(x) � 1")]
    [EquivalentIntConstant(0)]
    public static class CL00_67_1_ch_sh
    {
        public static double Body(double x)
        {            
            double  Y1, Y2, X=1;
            Y1 = Math.Cosh(x);
Y2 = Math.Sinh(x);
X = Y1*Y1-Y2*Y2-1;
            return X;
        }
    }
    /// <summary>
    /// ��������� ��������� 67 f(x) = ch(x)*ch(x) � sh(x)*sh(x) � 1,
    /// ����������� ������� �������� ����� ����� X - ��������� ��������� ����� ����� ��������� ���� �� ���� ������� ���,
    /// ������� ������ �������� <paramref name="count"/>.
    /// </summary>
    /// <param name="x">���� � ��������</param>
    /// <param name="count">���������� ��������� ������������</param>
    /// <returns>0</returns>
    [OpaqueFunction()]
    [FunctionName("L00_67_2_ch_sh", "f(x) = ch(x)*ch(x) � sh(x)*sh(x) � 1")]
    [EquivalentIntConstant(0)]
    public static class CL00_67_2_ch_sh
    {
        public static double Body(double x, int count)
        {
            double  Y1, Y2, X=1;
            for (int i = 0; i < count; ++i) {
                Y1 = Math.Cosh(x);
Y2 = Math.Sinh(x);
X = Y1*Y1-Y2*Y2-1;
            }
            return X;
        }
    }
    /// <summary>
    /// ���������� ������� ����������� ��������� 67 f(x) = ch(x)*ch(x) � sh(x)*sh(x) � 1
    /// </summary>    
    /// <returns>(w, w)</returns>
    [OpaqueFunction()]
    [FunctionName("L00_67_1_ch_sh_in", "(0, w)")]
    public static class CL00_67_1_ch_sh_in
    {
        public static string Body()
        {
            return "(w, w)";
        }
    }


    
    //##################################################################################################
    /// <summary>
    /// ��������� ��������� 68 f(x) = th(x) � sh(x)/ch(x)
    /// </summary>
    /// <param name="x">���� � ��������</param>
    /// <returns>0</returns>
    [OpaqueFunction()]
    [FunctionName("L00_68_1_th_sh_ch", "f(x) = th(x) � sh(x)/ch(x)")]
    [EquivalentIntConstant(0)]
    public static class CL00_68_1_th_sh_ch
    {
        public static double Body(double x)
        {            
            double  Y1, Y2, Y3, X = 1;
            Y1 = Math.Tanh(x);
Y2 = Math.Cosh(x);
Y3 = Math.Sinh(x);
X = Y1 - Y3/Y2;
            return X;
        }
    }
    /// <summary>
    /// ��������� ��������� 68 f(x) = th(x) � sh(x)/ch(x),
    /// ����������� ������� �������� ����� ����� X - ��������� ��������� ����� ����� ��������� ���� �� ���� ������� ���,
    /// ������� ������ �������� <paramref name="count"/>.
    /// </summary>
    /// <param name="x">���� � ��������</param>
    /// <param name="count">���������� ��������� ������������</param>
    /// <returns>0</returns>
    [OpaqueFunction()]
    [FunctionName("L00_68_2_th_sh_ch", "f(x) = th(x) � sh(x)/ch(x)")]
    [EquivalentIntConstant(0)]
    public static class CL00_68_2_th_sh_ch
    {
        public static double Body(double x, int count)
        {
            double  Y1, Y2, Y3, X = 1;
            for (int i = 0; i < count; ++i) {
                Y1 = Math.Tanh(x);
Y2 = Math.Cosh(x);
Y3 = Math.Sinh(x);
X = Y1 - Y3/Y2;
            }
            return X;
        }
    }
    /// <summary>
    /// ���������� ������� ����������� ��������� 68 f(x) = th(x) � sh(x)/ch(x)
    /// </summary>    
    /// <returns>(w, w)</returns>
    [OpaqueFunction()]
    [FunctionName("L00_68_1_th_sh_ch_in", "(0, w)")]
    public static class CL00_68_1_th_sh_ch_in
    {
        public static string Body()
        {
            return "(w, w)";
        }
    }


    
    //##################################################################################################
    /// <summary>
    /// ��������� ��������� 69 f(x) = cth(x) � ch(x)/sh(x)
    /// </summary>
    /// <param name="x">���� � ��������</param>
    /// <returns>0</returns>
    [OpaqueFunction()]
    [FunctionName("L00_69_1_cth_sh_ch", "f(x) = cth(x) � ch(x)/sh(x)")]
    [EquivalentIntConstant(0)]
    public static class CL00_69_1_cth_sh_ch
    {
        public static double Body(double x)
        {            
            double  Y1, Y2, Y3, X=1;
            Y1 = 1/Math.Tanh(x);
Y2 = Math.Cosh(x);
Y3 = Math.Sinh(x);
X = Y1 - Y2/Y3;
            return X;
        }
    }
    /// <summary>
    /// ��������� ��������� 69 f(x) = cth(x) � ch(x)/sh(x),
    /// ����������� ������� �������� ����� ����� X - ��������� ��������� ����� ����� ��������� ���� �� ���� ������� ���,
    /// ������� ������ �������� <paramref name="count"/>.
    /// </summary>
    /// <param name="x">���� � ��������</param>
    /// <param name="count">���������� ��������� ������������</param>
    /// <returns>0</returns>
    [OpaqueFunction()]
    [FunctionName("L00_69_2_cth_sh_ch", "f(x) = cth(x) � ch(x)/sh(x)")]
    [EquivalentIntConstant(0)]
    public static class CL00_69_2_cth_sh_ch
    {
        public static double Body(double x, int count)
        {
            double  Y1, Y2, Y3, X=1;
            for (int i = 0; i < count; ++i) {
                Y1 = 1/Math.Tanh(x);
Y2 = Math.Cosh(x);
Y3 = Math.Sinh(x);
X = Y1 - Y2/Y3;
            }
            return X;
        }
    }
    /// <summary>
    /// ���������� ������� ����������� ��������� 69 f(x) = cth(x) � ch(x)/sh(x)
    /// </summary>    
    /// <returns>(w, w)</returns>
    [OpaqueFunction()]
    [FunctionName("L00_69_1_cth_sh_ch_in", "(0, w)")]
    public static class CL00_69_1_cth_sh_ch_in
    {
        public static string Body()
        {
            return "(w, w)";
        }
    }


    
    //##################################################################################################
    /// <summary>
    /// ��������� ��������� 70 f(x) = sch(x) � 1/ch(x)
    /// </summary>
    /// <param name="x">���� � ��������</param>
    /// <returns>0</returns>
    [OpaqueFunction()]
    [FunctionName("L00_70_1_sch_ch", "f(x) = sch(x) � 1/ch(x)")]
    [EquivalentIntConstant(0)]
    public static class CL00_70_1_sch_ch
    {
        public static double Body(double x)
        {            
            double  Y1, Y2, X=1;
            Y1 = 1/Math.Cosh(x); //sch(x)
Y2 = 1/Math.Cosh(x);
X = Y1 - Y2;
            return X;
        }
    }
    /// <summary>
    /// ��������� ��������� 70 f(x) = sch(x) � 1/ch(x),
    /// ����������� ������� �������� ����� ����� X - ��������� ��������� ����� ����� ��������� ���� �� ���� ������� ���,
    /// ������� ������ �������� <paramref name="count"/>.
    /// </summary>
    /// <param name="x">���� � ��������</param>
    /// <param name="count">���������� ��������� ������������</param>
    /// <returns>0</returns>
    [OpaqueFunction()]
    [FunctionName("L00_70_2_sch_ch", "f(x) = sch(x) � 1/ch(x)")]
    [EquivalentIntConstant(0)]
    public static class CL00_70_2_sch_ch
    {
        public static double Body(double x, int count)
        {
            double  Y1, Y2, X=1;
            for (int i = 0; i < count; ++i) {
                Y1 = 1/Math.Cosh(x); //sch(x)
Y2 = 1/Math.Cosh(x);
X = Y1 - Y2;
            }
            return X;
        }
    }
    /// <summary>
    /// ���������� ������� ����������� ��������� 70 f(x) = sch(x) � 1/ch(x)
    /// </summary>    
    /// <returns>(w, w)</returns>
    [OpaqueFunction()]
    [FunctionName("L00_70_1_sch_ch_in", "(0, w)")]
    public static class CL00_70_1_sch_ch_in
    {
        public static string Body()
        {
            return "(w, w)";
        }
    }


    
    //##################################################################################################
    /// <summary>
    /// ��������� ��������� 71 f(x) = csch(x) � 1/sh(x)
    /// </summary>
    /// <param name="x">���� � ��������</param>
    /// <returns>0</returns>
    [OpaqueFunction()]
    [FunctionName("L00_71_1_sch_ch", "f(x) = csch(x) � 1/sh(x)")]
    [EquivalentIntConstant(0)]
    public static class CL00_71_1_sch_ch
    {
        public static double Body(double x)
        {            
            double  Y1, Y2, X=1;
            Y1 = 1/Math.Sinh(x); //csch(x)
Y2 = 1/Math.Sinh(x);
X = Y1 - Y2;
            return X;
        }
    }
    /// <summary>
    /// ��������� ��������� 71 f(x) = csch(x) � 1/sh(x),
    /// ����������� ������� �������� ����� ����� X - ��������� ��������� ����� ����� ��������� ���� �� ���� ������� ���,
    /// ������� ������ �������� <paramref name="count"/>.
    /// </summary>
    /// <param name="x">���� � ��������</param>
    /// <param name="count">���������� ��������� ������������</param>
    /// <returns>0</returns>
    [OpaqueFunction()]
    [FunctionName("L00_71_2_sch_ch", "f(x) = csch(x) � 1/sh(x)")]
    [EquivalentIntConstant(0)]
    public static class CL00_71_2_sch_ch
    {
        public static double Body(double x, int count)
        {
            double  Y1, Y2, X=1;
            for (int i = 0; i < count; ++i) {
                Y1 = 1/Math.Sinh(x); //csch(x)
Y2 = 1/Math.Sinh(x);
X = Y1 - Y2;
            }
            return X;
        }
    }
    /// <summary>
    /// ���������� ������� ����������� ��������� 71 f(x) = csch(x) � 1/sh(x)
    /// </summary>    
    /// <returns>(w, w)</returns>
    [OpaqueFunction()]
    [FunctionName("L00_71_1_sch_ch_in", "(0, w)")]
    public static class CL00_71_1_sch_ch_in
    {
        public static string Body()
        {
            return "(w, w)";
        }
    }


    
    //##################################################################################################
    /// <summary>
    /// ��������� ��������� 72 f(x,y) = sh(x+y) � (sh(x)*ch(y) + ch(x)*sh(y))
    /// </summary>
    /// <param name="x">���� � ��������</param>
	/// <param name="y">���� � ��������</param>
    /// <returns>0</returns>
    [OpaqueFunction()]
    [FunctionName("L00_72_2_sh_ch", "f(x,y) = sh(x+y) � (sh(x)*ch(y) + ch(x)*sh(y))")]
    [EquivalentIntConstant(0)]
    public static class CL00_72_2_sh_ch
    {
        public static double Body(double x, double y)
        {            
            double Y1, Y2, Y3, Y4, Y5, Y6, X = 1;
            Y1 = x+y;
Y2 = Math.Sinh(Y1);
Y3 = Math.Sinh(x);
Y4 = Math.Cosh(y);
Y5 = Math.Cosh(x);
Y6 = Math.Sinh(y);
X = Y2 - (Y3*Y4 + Y5*Y6);
            return X;
        }
    }
    /// <summary>
    /// ��������� ��������� 72 f(x,y) = sh(x+y) � (sh(x)*ch(y) + ch(x)*sh(y)),
    /// ����������� ������� �������� ����� ����� X - ��������� ��������� ����� ����� ��������� ���� �� ���� ������� ���,
    /// ������� ������ �������� <paramref name="count"/>.
    /// </summary>
    /// <param name="x">���� � ��������</param>
	/// <param name="y">���� � ��������</param>
    /// <param name="count">���������� ��������� ������������</param>
    /// <returns>0</returns>
    [OpaqueFunction()]
    [FunctionName("L00_72_3_sh_ch", "f(x,y) = sh(x+y) � (sh(x)*ch(y) + ch(x)*sh(y))")]
    [EquivalentIntConstant(0)]
    public static class CL00_72_3_sh_ch
    {
        public static double Body(double x, double y, int count)
        {
            double Y1, Y2, Y3, Y4, Y5, Y6, X = 1;
            for (int i = 0; i < count; ++i) {
                Y1 = x+y;
Y2 = Math.Sinh(Y1);
Y3 = Math.Sinh(x);
Y4 = Math.Cosh(y);
Y5 = Math.Cosh(x);
Y6 = Math.Sinh(y);
X = Y2 - (Y3*Y4 + Y5*Y6);
            }
            return X;
        }
    }
    /// <summary>
    /// ���������� ������� ����������� ��������� 72 f(x,y) = sh(x+y) � (sh(x)*ch(y) + ch(x)*sh(y))
    /// </summary>    
    /// <returns>(w, w) (w, w)</returns>
    [OpaqueFunction()]
    [FunctionName("L00_72_2_sh_ch_in", "(0, w)")]
    public static class CL00_72_2_sh_ch_in
    {
        public static string Body()
        {
            return "(w, w) (w, w)";
        }
    }	



   //##################################################################################################
    /// <summary>
    /// ��������� ��������� 73 f(x,y) = sh(x-y) � (sh(x)*ch(y) - ch(x)*sh(y))
    /// </summary>
    /// <param name="x">���� � ��������</param>
	/// <param name="y">���� � ��������</param>
    /// <returns>0</returns>
    [OpaqueFunction()]
    [FunctionName("L00_73_2_sh_ch", "f(x,y) = sh(x-y) � (sh(x)*ch(y) - ch(x)*sh(y))")]
    [EquivalentIntConstant(0)]
    public static class CL00_73_2_sh_ch
    {
        public static double Body(double x, double y)
        {            
            double Y1, Y2, Y3, Y4, Y5, Y6, X = 1;
            Y1 = x-y;
Y2 = Math.Sinh(Y1);
Y3 = Math.Sinh(x);
Y4 = Math.Cosh(y);
Y5 = Math.Cosh(x);
Y6 = Math.Sinh(y);
X = Y2 - (Y3*Y4 - Y5*Y6);
            return X;
        }
    }
    /// <summary>
    /// ��������� ��������� 73 f(x,y) = sh(x-y) � (sh(x)*ch(y) - ch(x)*sh(y)),
    /// ����������� ������� �������� ����� ����� X - ��������� ��������� ����� ����� ��������� ���� �� ���� ������� ���,
    /// ������� ������ �������� <paramref name="count"/>.
    /// </summary>
    /// <param name="x">���� � ��������</param>
	/// <param name="y">���� � ��������</param>
    /// <param name="count">���������� ��������� ������������</param>
    /// <returns>0</returns>
    [OpaqueFunction()]
    [FunctionName("L00_73_3_sh_ch", "f(x,y) = sh(x-y) � (sh(x)*ch(y) - ch(x)*sh(y))")]
    [EquivalentIntConstant(0)]
    public static class CL00_73_3_sh_ch
    {
        public static double Body(double x, double y, int count)
        {
            double Y1, Y2, Y3, Y4, Y5, Y6, X = 1;
            for (int i = 0; i < count; ++i) {
                Y1 = x-y;
Y2 = Math.Sinh(Y1);
Y3 = Math.Sinh(x);
Y4 = Math.Cosh(y);
Y5 = Math.Cosh(x);
Y6 = Math.Sinh(y);
X = Y2 - (Y3*Y4 - Y5*Y6);
            }
            return X;
        }
    }
    /// <summary>
    /// ���������� ������� ����������� ��������� 73 f(x,y) = sh(x-y) � (sh(x)*ch(y) - ch(x)*sh(y))
    /// </summary>    
    /// <returns>(w, w) (w, w)</returns>
    [OpaqueFunction()]
    [FunctionName("L00_73_2_sh_ch_in", "(0, w)")]
    public static class CL00_73_2_sh_ch_in
    {
        public static string Body()
        {
            return "(w, w) (w, w)";
        }
    }	



   //##################################################################################################
    /// <summary>
    /// ��������� ��������� 74 f(x,y) = ch(x+y) � (ch(x)*ch(y) + sh(x)*sh(y))
    /// </summary>
    /// <param name="x">���� � ��������</param>
	/// <param name="y">���� � ��������</param>
    /// <returns>0</returns>
    [OpaqueFunction()]
    [FunctionName("L00_74_2_sh_ch", "f(x,y) = ch(x+y) � (ch(x)*ch(y) + sh(x)*sh(y))")]
    [EquivalentIntConstant(0)]
    public static class CL00_74_2_sh_ch
    {
        public static double Body(double x, double y)
        {            
            double Y1, Y2, Y3, Y4, Y5, Y6, X = 1;
            Y1 = x+y;
Y2 = Math.Cosh(Y1);
Y3 = Math.Cosh(x);
Y4 = Math.Cosh(y);
Y5 = Math.Sinh(x);
Y6 = Math.Sinh(y);
X = Y2 - (Y3*Y4 + Y5*Y6);
            return X;
        }
    }
    /// <summary>
    /// ��������� ��������� 74 f(x,y) = ch(x+y) � (ch(x)*ch(y) + sh(x)*sh(y)),
    /// ����������� ������� �������� ����� ����� X - ��������� ��������� ����� ����� ��������� ���� �� ���� ������� ���,
    /// ������� ������ �������� <paramref name="count"/>.
    /// </summary>
    /// <param name="x">���� � ��������</param>
	/// <param name="y">���� � ��������</param>
    /// <param name="count">���������� ��������� ������������</param>
    /// <returns>0</returns>
    [OpaqueFunction()]
    [FunctionName("L00_74_3_sh_ch", "f(x,y) = ch(x+y) � (ch(x)*ch(y) + sh(x)*sh(y))")]
    [EquivalentIntConstant(0)]
    public static class CL00_74_3_sh_ch
    {
        public static double Body(double x, double y, int count)
        {
            double Y1, Y2, Y3, Y4, Y5, Y6, X = 1;
            for (int i = 0; i < count; ++i) {
                Y1 = x+y;
Y2 = Math.Cosh(Y1);
Y3 = Math.Cosh(x);
Y4 = Math.Cosh(y);
Y5 = Math.Sinh(x);
Y6 = Math.Sinh(y);
X = Y2 - (Y3*Y4 + Y5*Y6);
            }
            return X;
        }
    }
    /// <summary>
    /// ���������� ������� ����������� ��������� 74 f(x,y) = ch(x+y) � (ch(x)*ch(y) + sh(x)*sh(y))
    /// </summary>    
    /// <returns>(w, w) (w, w)</returns>
    [OpaqueFunction()]
    [FunctionName("L00_74_2_sh_ch_in", "(0, w)")]
    public static class CL00_74_2_sh_ch_in
    {
        public static string Body()
        {
            return "(w, w) (w, w)";
        }
    }	



   //##################################################################################################
    /// <summary>
    /// ��������� ��������� 75 f(x,y) = ch(x-y) � (ch(x)*ch(y) - sh(x)*sh(y))
    /// </summary>
    /// <param name="x">���� � ��������</param>
	/// <param name="y">���� � ��������</param>
    /// <returns>0</returns>
    [OpaqueFunction()]
    [FunctionName("L00_75_2_sh_ch", "f(x,y) = ch(x-y) � (ch(x)*ch(y) - sh(x)*sh(y))")]
    [EquivalentIntConstant(0)]
    public static class CL00_75_2_sh_ch
    {
        public static double Body(double x, double y)
        {            
            double Y1, Y2, Y3, Y4, Y5, Y6, X = 1;
            Y1 = x-y;
Y2 = Math.Cosh(Y1);
Y3 = Math.Cosh(x);
Y4 = Math.Cosh(y);
Y5 = Math.Sinh(x);
Y6 = Math.Sinh(y);
X = Y2 - (Y3*Y4 - Y5*Y6);
            return X;
        }
    }
    /// <summary>
    /// ��������� ��������� 75 f(x,y) = ch(x-y) � (ch(x)*ch(y) - sh(x)*sh(y)),
    /// ����������� ������� �������� ����� ����� X - ��������� ��������� ����� ����� ��������� ���� �� ���� ������� ���,
    /// ������� ������ �������� <paramref name="count"/>.
    /// </summary>
    /// <param name="x">���� � ��������</param>
	/// <param name="y">���� � ��������</param>
    /// <param name="count">���������� ��������� ������������</param>
    /// <returns>0</returns>
    [OpaqueFunction()]
    [FunctionName("L00_75_3_sh_ch", "f(x,y) = ch(x-y) � (ch(x)*ch(y) - sh(x)*sh(y))")]
    [EquivalentIntConstant(0)]
    public static class CL00_75_3_sh_ch
    {
        public static double Body(double x, double y, int count)
        {
            double Y1, Y2, Y3, Y4, Y5, Y6, X = 1;
            for (int i = 0; i < count; ++i) {
                Y1 = x-y;
Y2 = Math.Cosh(Y1);
Y3 = Math.Cosh(x);
Y4 = Math.Cosh(y);
Y5 = Math.Sinh(x);
Y6 = Math.Sinh(y);
X = Y2 - (Y3*Y4 - Y5*Y6);
            }
            return X;
        }
    }
    /// <summary>
    /// ���������� ������� ����������� ��������� 75 f(x,y) = ch(x-y) � (ch(x)*ch(y) - sh(x)*sh(y))
    /// </summary>    
    /// <returns>(w, w) (w, w)</returns>
    [OpaqueFunction()]
    [FunctionName("L00_75_2_sh_ch_in", "(0, w)")]
    public static class CL00_75_2_sh_ch_in
    {
        public static string Body()
        {
            return "(w, w) (w, w)";
        }
    }	



   //##################################################################################################
    /// <summary>
    /// ��������� ��������� 76 f(x,y) = th(x+y) � (th(x) + th(y)/(1 + th(x)*th(y))
    /// </summary>
    /// <param name="x">���� � ��������</param>
	/// <param name="y">���� � ��������</param>
    /// <returns>0</returns>
    [OpaqueFunction()]
    [FunctionName("L00_76_2_th", "f(x,y) = th(x+y) � (th(x) + th(y)/(1 + th(x)*th(y))")]
    [EquivalentIntConstant(0)]
    public static class CL00_76_2_th
    {
        public static double Body(double x, double y)
        {            
            double Y1, Y2, Y3, Y4, X=1;
            Y1 = x+y;
Y2 = Math.Tanh(Y1);
Y3 = Math.Tanh(x);
Y4 = Math.Tanh(y);
X = Y2 - (Y3+Y4)/(1+Y3*Y4);
            return X;
        }
    }
    /// <summary>
    /// ��������� ��������� 76 f(x,y) = th(x+y) � (th(x) + th(y)/(1 + th(x)*th(y)),
    /// ����������� ������� �������� ����� ����� X - ��������� ��������� ����� ����� ��������� ���� �� ���� ������� ���,
    /// ������� ������ �������� <paramref name="count"/>.
    /// </summary>
    /// <param name="x">���� � ��������</param>
	/// <param name="y">���� � ��������</param>
    /// <param name="count">���������� ��������� ������������</param>
    /// <returns>0</returns>
    [OpaqueFunction()]
    [FunctionName("L00_76_3_th", "f(x,y) = th(x+y) � (th(x) + th(y)/(1 + th(x)*th(y))")]
    [EquivalentIntConstant(0)]
    public static class CL00_76_3_th
    {
        public static double Body(double x, double y, int count)
        {
            double Y1, Y2, Y3, Y4, X=1;
            for (int i = 0; i < count; ++i) {
                Y1 = x+y;
Y2 = Math.Tanh(Y1);
Y3 = Math.Tanh(x);
Y4 = Math.Tanh(y);
X = Y2 - (Y3+Y4)/(1+Y3*Y4);
            }
            return X;
        }
    }
    /// <summary>
    /// ���������� ������� ����������� ��������� 76 f(x,y) = th(x+y) � (th(x) + th(y)/(1 + th(x)*th(y))
    /// </summary>    
    /// <returns>(w, w) (w, w)</returns>
    [OpaqueFunction()]
    [FunctionName("L00_76_2_th_in", "(0, w)")]
    public static class CL00_76_2_th_in
    {
        public static string Body()
        {
            return "(w, w) (w, w)";
        }
    }	



   //##################################################################################################
    /// <summary>
    /// ��������� ��������� 77 f(x,y) = th(x-y) � (th(x) - th(y)/(1 - th(x)*th(y))
    /// </summary>
    /// <param name="x">���� � ��������</param>
	/// <param name="y">���� � ��������</param>
    /// <returns>0</returns>
    [OpaqueFunction()]
    [FunctionName("L00_77_2_th", "f(x,y) = th(x-y) � (th(x) - th(y)/(1 - th(x)*th(y))")]
    [EquivalentIntConstant(0)]
    public static class CL00_77_2_th
    {
        public static double Body(double x, double y)
        {            
            double Y1, Y2, Y3, Y4, X=1;
            Y1 = x-y;
Y2 = Math.Tanh(Y1);
Y3 = Math.Tanh(x);
Y4 = Math.Tanh(y);
X = Y2 - (Y3-Y4)/(1-Y3*Y4);
            return X;
        }
    }
    /// <summary>
    /// ��������� ��������� 77 f(x,y) = th(x-y) � (th(x) - th(y)/(1 - th(x)*th(y)),
    /// ����������� ������� �������� ����� ����� X - ��������� ��������� ����� ����� ��������� ���� �� ���� ������� ���,
    /// ������� ������ �������� <paramref name="count"/>.
    /// </summary>
    /// <param name="x">���� � ��������</param>
	/// <param name="y">���� � ��������</param>
    /// <param name="count">���������� ��������� ������������</param>
    /// <returns>0</returns>
    [OpaqueFunction()]
    [FunctionName("L00_77_3_th", "f(x,y) = th(x-y) � (th(x) - th(y)/(1 - th(x)*th(y))")]
    [EquivalentIntConstant(0)]
    public static class CL00_77_3_th
    {
        public static double Body(double x, double y, int count)
        {
            double Y1, Y2, Y3, Y4, X=1;
            for (int i = 0; i < count; ++i) {
                Y1 = x-y;
Y2 = Math.Tanh(Y1);
Y3 = Math.Tanh(x);
Y4 = Math.Tanh(y);
X = Y2 - (Y3-Y4)/(1-Y3*Y4);
            }
            return X;
        }
    }
    /// <summary>
    /// ���������� ������� ����������� ��������� 77 f(x,y) = th(x-y) � (th(x) - th(y)/(1 - th(x)*th(y))
    /// </summary>    
    /// <returns>(w, w) (w, w)</returns>
    [OpaqueFunction()]
    [FunctionName("L00_77_2_th_in", "(0, w)")]
    public static class CL00_77_2_th_in
    {
        public static string Body()
        {
            return "(w, w) (w, w)";
        }
    }	



   //##################################################################################################
    /// <summary>
    /// ��������� ��������� 78 f(x,y)  = cth(x+y) � (1 + cth(x)*cth(y))/(cth(x) + cth(y))
    /// </summary>
    /// <param name="x">���� � ��������</param>
	/// <param name="y">���� � ��������</param>
    /// <returns>0</returns>
    [OpaqueFunction()]
    [FunctionName("L00_78_2_cth", "f(x,y)  = cth(x+y) � (1 + cth(x)*cth(y))/(cth(x) + cth(y))")]
    [EquivalentIntConstant(0)]
    public static class CL00_78_2_cth
    {
        public static double Body(double x, double y)
        {            
            double Y1, Y2, Y3, Y4, X=1;
            Y1 = x+y;
Y2 = Math.Tan(x+y);
Y3 = Math.Tan(x);
Y4 = Math.Tan(y);
X = 1/Y2 - (1 + 1/Y3 * 1/Y4)/(1 / Y3 + 1 / Y4);
            return X;
        }
    }
    /// <summary>
    /// ��������� ��������� 78 f(x,y)  = cth(x+y) � (1 + cth(x)*cth(y))/(cth(x) + cth(y)),
    /// ����������� ������� �������� ����� ����� X - ��������� ��������� ����� ����� ��������� ���� �� ���� ������� ���,
    /// ������� ������ �������� <paramref name="count"/>.
    /// </summary>
    /// <param name="x">���� � ��������</param>
	/// <param name="y">���� � ��������</param>
    /// <param name="count">���������� ��������� ������������</param>
    /// <returns>0</returns>
    [OpaqueFunction()]
    [FunctionName("L00_78_3_cth", "f(x,y)  = cth(x+y) � (1 + cth(x)*cth(y))/(cth(x) + cth(y))")]
    [EquivalentIntConstant(0)]
    public static class CL00_78_3_cth
    {
        public static double Body(double x, double y, int count)
        {
            double Y1, Y2, Y3, Y4, X=1;
            for (int i = 0; i < count; ++i) {
                Y1 = x+y;
Y2 = Math.Tan(x+y);
Y3 = Math.Tan(x);
Y4 = Math.Tan(y);
X = 1/Y2 - (1 + 1/Y3 * 1/Y4)/(1 / Y3 + 1 / Y4);
            }
            return X;
        }
    }
    /// <summary>
    /// ���������� ������� ����������� ��������� 78 f(x,y)  = cth(x+y) � (1 + cth(x)*cth(y))/(cth(x) + cth(y))
    /// </summary>    
    /// <returns>(w, w) (w, w)</returns>
    [OpaqueFunction()]
    [FunctionName("L00_78_2_cth_in", "(0, w)")]
    public static class CL00_78_2_cth_in
    {
        public static string Body()
        {
            return "(w, w) (w, w)";
        }
    }	



   //##################################################################################################
    /// <summary>
    /// ��������� ��������� 79 f(x,y)  = cth(x-y) � (1 - cth(x)*cth(y))/(cth(x) - cth(y))
    /// </summary>
    /// <param name="x">���� � ��������</param>
	/// <param name="y">���� � ��������</param>
    /// <returns>0</returns>
    [OpaqueFunction()]
    [FunctionName("L00_79_2_cth", "f(x,y)  = cth(x-y) � (1 - cth(x)*cth(y))/(cth(x) - cth(y))")]
    [EquivalentIntConstant(0)]
    public static class CL00_79_2_cth
    {
        public static double Body(double x, double y)
        {            
            double Y1, Y2, Y3, Y4, X=1;
            Y1 = x-y;
Y2 = Math.Tan(x+y);
Y3 = Math.Tan(x);
Y4 = Math.Tan(y);
X = 1/Y2 - (1 - 1/Y3 * 1/Y4)/(1 / Y3 - 1 / Y4);
            return X;
        }
    }
    /// <summary>
    /// ��������� ��������� 79 f(x,y)  = cth(x-y) � (1 - cth(x)*cth(y))/(cth(x) - cth(y)),
    /// ����������� ������� �������� ����� ����� X - ��������� ��������� ����� ����� ��������� ���� �� ���� ������� ���,
    /// ������� ������ �������� <paramref name="count"/>.
    /// </summary>
    /// <param name="x">���� � ��������</param>
	/// <param name="y">���� � ��������</param>
    /// <param name="count">���������� ��������� ������������</param>
    /// <returns>0</returns>
    [OpaqueFunction()]
    [FunctionName("L00_79_3_cth", "f(x,y)  = cth(x-y) � (1 - cth(x)*cth(y))/(cth(x) - cth(y))")]
    [EquivalentIntConstant(0)]
    public static class CL00_79_3_cth
    {
        public static double Body(double x, double y, int count)
        {
            double Y1, Y2, Y3, Y4, X=1;
            for (int i = 0; i < count; ++i) {
                Y1 = x-y;
Y2 = Math.Tan(x+y);
Y3 = Math.Tan(x);
Y4 = Math.Tan(y);
X = 1/Y2 - (1 - 1/Y3 * 1/Y4)/(1 / Y3 - 1 / Y4);
            }
            return X;
        }
    }
    /// <summary>
    /// ���������� ������� ����������� ��������� 79 f(x,y)  = cth(x-y) � (1 - cth(x)*cth(y))/(cth(x) - cth(y))
    /// </summary>    
    /// <returns>(w, w) (w, w)</returns>
    [OpaqueFunction()]
    [FunctionName("L00_79_2_cth_in", "(0, w)")]
    public static class CL00_79_2_cth_in
    {
        public static string Body()
        {
            return "(w, w) (w, w)";
        }
    }	



   //##################################################################################################
    /// <summary>
    /// ��������� ��������� 80 f(x,y) = 2*sh(x)*sh(y) � ch(x+y) + ch(x-y)
    /// </summary>
    /// <param name="x">���� � ��������</param>
	/// <param name="y">���� � ��������</param>
    /// <returns>0</returns>
    [OpaqueFunction()]
    [FunctionName("L00_80_2_sh_ch", "f(x,y) = 2*sh(x)*sh(y) � ch(x+y) + ch(x-y)")]
    [EquivalentIntConstant(0)]
    public static class CL00_80_2_sh_ch
    {
        public static double Body(double x, double y)
        {            
            double Y1, Y2, Y3, Y4, Y5, Y6, X = 1;
            Y1 = Math.Cosh(x);
Y2 = Math.Sinh(y);
Y3 = x + y;
Y4 = x - y;
Y5 = Math.Cosh(Y3);
Y6 = Math.Cosh(Y4);
X = 2*Y2*Y1 - Y5 + Y6;
            return X;
        }
    }
    /// <summary>
    /// ��������� ��������� 80 f(x,y) = 2*sh(x)*sh(y) � ch(x+y) + ch(x-y),
    /// ����������� ������� �������� ����� ����� X - ��������� ��������� ����� ����� ��������� ���� �� ���� ������� ���,
    /// ������� ������ �������� <paramref name="count"/>.
    /// </summary>
    /// <param name="x">���� � ��������</param>
	/// <param name="y">���� � ��������</param>
    /// <param name="count">���������� ��������� ������������</param>
    /// <returns>0</returns>
    [OpaqueFunction()]
    [FunctionName("L00_80_3_sh_ch", "f(x,y) = 2*sh(x)*sh(y) � ch(x+y) + ch(x-y)")]
    [EquivalentIntConstant(0)]
    public static class CL00_80_3_sh_ch
    {
        public static double Body(double x, double y, int count)
        {
            double Y1, Y2, Y3, Y4, Y5, Y6, X = 1;
            for (int i = 0; i < count; ++i) {
                Y1 = Math.Cosh(x);
Y2 = Math.Sinh(y);
Y3 = x + y;
Y4 = x - y;
Y5 = Math.Cosh(Y3);
Y6 = Math.Cosh(Y4);
X = 2*Y2*Y1 - Y5 + Y6;
            }
            return X;
        }
    }
    /// <summary>
    /// ���������� ������� ����������� ��������� 80 f(x,y) = 2*sh(x)*sh(y) � ch(x+y) + ch(x-y)
    /// </summary>    
    /// <returns>(w, w) (w, w)</returns>
    [OpaqueFunction()]
    [FunctionName("L00_80_2_sh_ch_in", "(0, w)")]
    public static class CL00_80_2_sh_ch_in
    {
        public static string Body()
        {
            return "(w, w) (w, w)";
        }
    }	



   //##################################################################################################
    /// <summary>
    /// ��������� ��������� 81 f(x,y) = 2*ch(x)*ch(y) � ch(x+y) � ch(x-y)
    /// </summary>
    /// <param name="x">���� � ��������</param>
	/// <param name="y">���� � ��������</param>
    /// <returns>0</returns>
    [OpaqueFunction()]
    [FunctionName("L00_81_2_sh_ch", "f(x,y) = 2*ch(x)*ch(y) � ch(x+y) � ch(x-y)")]
    [EquivalentIntConstant(0)]
    public static class CL00_81_2_sh_ch
    {
        public static double Body(double x, double y)
        {            
            double Y1, Y2, Y3, Y4, Y5, Y6,X = 1;
            Y1 = Math.Cosh(x);
Y2 = Math.Cosh(y);
Y3 = x + y;
Y4 = x - y;
Y5 = Math.Cosh(Y3);
Y6 = Math.Cosh(Y4);
X = 2*Y2*Y1 - Y5 - Y6;
            return X;
        }
    }
    /// <summary>
    /// ��������� ��������� 81 f(x,y) = 2*ch(x)*ch(y) � ch(x+y) � ch(x-y),
    /// ����������� ������� �������� ����� ����� X - ��������� ��������� ����� ����� ��������� ���� �� ���� ������� ���,
    /// ������� ������ �������� <paramref name="count"/>.
    /// </summary>
    /// <param name="x">���� � ��������</param>
	/// <param name="y">���� � ��������</param>
    /// <param name="count">���������� ��������� ������������</param>
    /// <returns>0</returns>
    [OpaqueFunction()]
    [FunctionName("L00_81_3_sh_ch", "f(x,y) = 2*ch(x)*ch(y) � ch(x+y) � ch(x-y)")]
    [EquivalentIntConstant(0)]
    public static class CL00_81_3_sh_ch
    {
        public static double Body(double x, double y, int count)
        {
            double Y1, Y2, Y3, Y4, Y5, Y6,X = 1;
            for (int i = 0; i < count; ++i) {
                Y1 = Math.Cosh(x);
Y2 = Math.Cosh(y);
Y3 = x + y;
Y4 = x - y;
Y5 = Math.Cosh(Y3);
Y6 = Math.Cosh(Y4);
X = 2*Y2*Y1 - Y5 - Y6;
            }
            return X;
        }
    }
    /// <summary>
    /// ���������� ������� ����������� ��������� 81 f(x,y) = 2*ch(x)*ch(y) � ch(x+y) � ch(x-y)
    /// </summary>    
    /// <returns>(w, w) (w, w)</returns>
    [OpaqueFunction()]
    [FunctionName("L00_81_2_sh_ch_in", "(0, w)")]
    public static class CL00_81_2_sh_ch_in
    {
        public static string Body()
        {
            return "(w, w) (w, w)";
        }
    }	



   //##################################################################################################
    /// <summary>
    /// ��������� ��������� 82 f(x,y) = 2*sh(x)*ch(y) � sh(x+y) � sh(x-y)
    /// </summary>
    /// <param name="x">���� � ��������</param>
	/// <param name="y">���� � ��������</param>
    /// <returns>0</returns>
    [OpaqueFunction()]
    [FunctionName("L00_82_2_sh_ch", "f(x,y) = 2*sh(x)*ch(y) � sh(x+y) � sh(x-y)")]
    [EquivalentIntConstant(0)]
    public static class CL00_82_2_sh_ch
    {
        public static double Body(double x, double y)
        {            
            double Y1, Y2, Y3, Y4, Y5, Y6,X = 1;
            Y1 = Math.Cosh(x);
Y2 = Math.Sinh(y);
Y3 = x + y;
Y4 = x - y;
Y5 = Math.Sinh(Y3);
Y6 = Math.Sinh(Y4);
X = 2*Y2*Y1 - Y5 - Y6;
            return X;
        }
    }
    /// <summary>
    /// ��������� ��������� 82 f(x,y) = 2*sh(x)*ch(y) � sh(x+y) � sh(x-y),
    /// ����������� ������� �������� ����� ����� X - ��������� ��������� ����� ����� ��������� ���� �� ���� ������� ���,
    /// ������� ������ �������� <paramref name="count"/>.
    /// </summary>
    /// <param name="x">���� � ��������</param>
	/// <param name="y">���� � ��������</param>
    /// <param name="count">���������� ��������� ������������</param>
    /// <returns>0</returns>
    [OpaqueFunction()]
    [FunctionName("L00_82_3_sh_ch", "f(x,y) = 2*sh(x)*ch(y) � sh(x+y) � sh(x-y)")]
    [EquivalentIntConstant(0)]
    public static class CL00_82_3_sh_ch
    {
        public static double Body(double x, double y, int count)
        {
            double Y1, Y2, Y3, Y4, Y5, Y6,X = 1;
            for (int i = 0; i < count; ++i) {
                Y1 = Math.Cosh(x);
Y2 = Math.Sinh(y);
Y3 = x + y;
Y4 = x - y;
Y5 = Math.Sinh(Y3);
Y6 = Math.Sinh(Y4);
X = 2*Y2*Y1 - Y5 - Y6;
            }
            return X;
        }
    }
    /// <summary>
    /// ���������� ������� ����������� ��������� 82 f(x,y) = 2*sh(x)*ch(y) � sh(x+y) � sh(x-y)
    /// </summary>    
    /// <returns>(w, w) (w, w)</returns>
    [OpaqueFunction()]
    [FunctionName("L00_82_2_sh_ch_in", "(0, w)")]
    public static class CL00_82_2_sh_ch_in
    {
        public static string Body()
        {
            return "(w, w) (w, w)";
        }
    }	



   //##################################################################################################
    /// <summary>
    /// ��������� ��������� 83 f(x) = ch(2x) � sh(x)*sh(x) + ch(x)*ch(x)
    /// </summary>
    /// <param name="x">���� � ��������</param>
    /// <returns>0</returns>
    [OpaqueFunction()]
    [FunctionName("L00_83_1_sh_ch", "f(x) = ch(2x) � sh(x)*sh(x) + ch(x)*ch(x)")]
    [EquivalentIntConstant(0)]
    public static class CL00_83_1_sh_ch
    {
        public static double Body(double x)
        {            
            double Y1, Y2, Y3, Y4, X = 1;
            Y1 = 2*x;
Y2 = Math.Cosh(Y1);
Y3 = Math.Sinh(x);
Y4 = Math.Cosh(x);
X = Y2 - Y3*Y3+Y4*Y4; 
            return X;
        }
    }
    /// <summary>
    /// ��������� ��������� 83 f(x) = ch(2x) � sh(x)*sh(x) + ch(x)*ch(x),
    /// ����������� ������� �������� ����� ����� X - ��������� ��������� ����� ����� ��������� ���� �� ���� ������� ���,
    /// ������� ������ �������� <paramref name="count"/>.
    /// </summary>
    /// <param name="x">���� � ��������</param>
    /// <param name="count">���������� ��������� ������������</param>
    /// <returns>0</returns>
    [OpaqueFunction()]
    [FunctionName("L00_83_2_sh_ch", "f(x) = ch(2x) � sh(x)*sh(x) + ch(x)*ch(x)")]
    [EquivalentIntConstant(0)]
    public static class CL00_83_2_sh_ch
    {
        public static double Body(double x, int count)
        {
            double Y1, Y2, Y3, Y4, X = 1;
            for (int i = 0; i < count; ++i) {
                Y1 = 2*x;
Y2 = Math.Cosh(Y1);
Y3 = Math.Sinh(x);
Y4 = Math.Cosh(x);
X = Y2 - Y3*Y3+Y4*Y4; 
            }
            return X;
        }
    }
    /// <summary>
    /// ���������� ������� ����������� ��������� 83 f(x) = ch(2x) � sh(x)*sh(x) + ch(x)*ch(x)
    /// </summary>    
    /// <returns>(w, w)</returns>
    [OpaqueFunction()]
    [FunctionName("L00_83_1_sh_ch_in", "(0, w)")]
    public static class CL00_83_1_sh_ch_in
    {
        public static string Body()
        {
            return "(w, w)";
        }
    }


    
    //##################################################################################################
    /// <summary>
    /// ��������� ��������� 84 f(x) = cth(2x) � (1 + cth(x)*cth(x))/(2*cth(x))
    /// </summary>
    /// <param name="x">���� � ��������</param>
    /// <returns>0</returns>
    [OpaqueFunction()]
    [FunctionName("L00_84_1_cth", "f(x) = cth(2x) � (1 + cth(x)*cth(x))/(2*cth(x))")]
    [EquivalentIntConstant(0)]
    public static class CL00_84_1_cth
    {
        public static double Body(double x)
        {            
            double Y1, Y2, Y3, Y4, Y5, X=1;
            Y1 = 2*x;
Y2 = Math.Tanh(Y1);
Y3 = Math.Tanh(x);
Y4 = 1/Y2;
Y5 = 1/Y3;
X = Y4 - (1+Y5*Y5)/(2*Y5);
            return X;
        }
    }
    /// <summary>
    /// ��������� ��������� 84 f(x) = cth(2x) � (1 + cth(x)*cth(x))/(2*cth(x)),
    /// ����������� ������� �������� ����� ����� X - ��������� ��������� ����� ����� ��������� ���� �� ���� ������� ���,
    /// ������� ������ �������� <paramref name="count"/>.
    /// </summary>
    /// <param name="x">���� � ��������</param>
    /// <param name="count">���������� ��������� ������������</param>
    /// <returns>0</returns>
    [OpaqueFunction()]
    [FunctionName("L00_84_2_cth", "f(x) = cth(2x) � (1 + cth(x)*cth(x))/(2*cth(x))")]
    [EquivalentIntConstant(0)]
    public static class CL00_84_2_cth
    {
        public static double Body(double x, int count)
        {
            double Y1, Y2, Y3, Y4, Y5, X=1;
            for (int i = 0; i < count; ++i) {
                Y1 = 2*x;
Y2 = Math.Tanh(Y1);
Y3 = Math.Tanh(x);
Y4 = 1/Y2;
Y5 = 1/Y3;
X = Y4 - (1+Y5*Y5)/(2*Y5);
            }
            return X;
        }
    }
    /// <summary>
    /// ���������� ������� ����������� ��������� 84 f(x) = cth(2x) � (1 + cth(x)*cth(x))/(2*cth(x))
    /// </summary>    
    /// <returns>(w, w)</returns>
    [OpaqueFunction()]
    [FunctionName("L00_84_1_cth_in", "(0, w)")]
    public static class CL00_84_1_cth_in
    {
        public static string Body()
        {
            return "(w, w)";
        }
    }


    
    //##################################################################################################
    /// <summary>
    /// ��������� ��������� 85 f(x) = sh(2x) � 2*sh(x)*ch(x)
    /// </summary>
    /// <param name="x">���� � ��������</param>
    /// <returns>0</returns>
    [OpaqueFunction()]
    [FunctionName("L00_85_1_sh_ch", "f(x) = sh(2x) � 2*sh(x)*ch(x)")]
    [EquivalentIntConstant(0)]
    public static class CL00_85_1_sh_ch
    {
        public static double Body(double x)
        {            
            double Y1, Y2, Y3, Y4, X=1;
            Y1 = 2*x;
Y2 = Math.Sinh(Y1);
Y3 = Math.Sinh(x);
Y4 = Math.Cosh(x);
X = Y2 - 2*Y3*Y4;
            return X;
        }
    }
    /// <summary>
    /// ��������� ��������� 85 f(x) = sh(2x) � 2*sh(x)*ch(x),
    /// ����������� ������� �������� ����� ����� X - ��������� ��������� ����� ����� ��������� ���� �� ���� ������� ���,
    /// ������� ������ �������� <paramref name="count"/>.
    /// </summary>
    /// <param name="x">���� � ��������</param>
    /// <param name="count">���������� ��������� ������������</param>
    /// <returns>0</returns>
    [OpaqueFunction()]
    [FunctionName("L00_85_2_sh_ch", "f(x) = sh(2x) � 2*sh(x)*ch(x)")]
    [EquivalentIntConstant(0)]
    public static class CL00_85_2_sh_ch
    {
        public static double Body(double x, int count)
        {
            double Y1, Y2, Y3, Y4, X=1;
            for (int i = 0; i < count; ++i) {
                Y1 = 2*x;
Y2 = Math.Sinh(Y1);
Y3 = Math.Sinh(x);
Y4 = Math.Cosh(x);
X = Y2 - 2*Y3*Y4;
            }
            return X;
        }
    }
    /// <summary>
    /// ���������� ������� ����������� ��������� 85 f(x) = sh(2x) � 2*sh(x)*ch(x)
    /// </summary>    
    /// <returns>(w, w)</returns>
    [OpaqueFunction()]
    [FunctionName("L00_85_1_sh_ch_in", "(0, w)")]
    public static class CL00_85_1_sh_ch_in
    {
        public static string Body()
        {
            return "(w, w)";
        }
    }


    
    