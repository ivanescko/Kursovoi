using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HeatBalanceCalculation.Models
{

    public class ClassLibrary
    {
        #region Входные параметры 

        #region Параметры чугуна

        /// <summary>
        /// Содержание марганца в чугуне
        /// </summary>
        public double Con_Mn { set; get; }

        /// <summary>
        /// Содержание кремния в чугуне
        /// </summary>
        public double Con_Si { set; get; }

        /// <summary>
        /// Содержание фосфора в чугуне
        /// </summary>
        public double Con_P { set; get; }

        /// <summary>
        /// Содержание титана в чугуне
        /// </summary>
        public double Con_Ti { set; get; }

        /// <summary>
        /// Содержание ванадия в чугуне
        /// </summary>
        public double Con_V { set; get; }

        /// <summary>
        /// Содержание Железа в чугуне
        /// </summary>
        public double Con_Fe;

        /// <summary>
        /// теплоемкость жидкого чугуна
        /// </summary>
        public double c_H { set; get; }

        /// <summary>
        /// температура чугуна, °С
        /// </summary>
        public double t_H { set; get; }

        #endregion

        /// <summary>
        /// степень прямого восстановления, доли ед.
        /// </summary>
        public const double rd = 0.35;

        #region Характеристики кокса

        /// <summary>
        /// удельный расход кокса, кг/т
        /// </summary>
        public double k { set; get; }

        /// <summary>
        /// Зола кокса, %
        /// </summary>
        public double A { set; get; }

        /// <summary>
        /// Сера кокса, %
        /// </summary>
        public double Sk { set; get; }

        /// <summary>
        /// Летучие кокса, %
        /// </summary>
        public double Lk { set; get; }

        /// <summary>
        /// содержание влаги в коксе, мас. %.
        /// </summary>
        public double f_k { set; get; }

        #endregion

        #region Параметры дутья

        /// <summary>
        /// температура горячего дутья, °С.
        /// </summary>
        public double td { set; get; }

        /// <summary>
        /// влажность дутья, г/м3
        /// </summary>
        public double f { set; get; }

        /// <summary>
        /// содержание кислорода в дутье, %
        /// </summary>
        public double w { set; get; }

        /// <summary>
        /// расход природного газа, м3/т чугуна
        /// </summary>
        public double Vpg { set; get; }

        #endregion

        #region Параметры известянка 

        /// <summary>
        /// удельный расход загружаемого в печь известняка, кг/т чугуна
        /// </summary>
        public double G_i { set; get; }

        /// <summary>
        /// содержание влаги в известняке, мас. %.
        /// </summary>
        public double f_i { set; get; }

        /// <summary>
        /// потери массы при прокаливании известняка, %.
        /// </summary>
        public double Coef_i { set; get; }

        #endregion

        #region Параметры шлака

        /// <summary>
        /// удельный выход шлака, кг/т чугуна
        /// </summary>
        public double U_hl { set; get; }

        /// <summary>
        /// теплоемкость жидкого шлака
        /// </summary>
        public double c_hl { set; get; }

        /// <summary>
        /// Содержание серы в шлаке
        /// </summary>
        public double S_hl { set; get; }

        #endregion

        #region Параметры колошникового газа



        /// <summary>
        /// Содержание газов в кг
        /// </summary>
        public double mas_CO2 { set; get; }

        public double mas_N2 { set; get; }

        public double mas_CO { set; get; }

        public double mas_H2 { set; get; }

        /// <summary>
        /// Суммарный обём газов
        /// </summary>
        public double Vkg = 1677.8;

        /// <summary>
        /// Температура колошникового газа
        /// </summary>
        public double T_kg { set; get; }

        #endregion

        #region Характеристики ЖРМ

        /// <summary>
        /// удельный расход «горячего» агломерата, кг/т чугуна
        /// </summary>
        public double G_jrm { set; get; }

        /// <summary>
        /// теплоемкость «горячего» агломерата, кДж/(кг×К)
        /// </summary>
        public const double C_jrm = 0.95;

        /// <summary>
        /// температура «горячего» агломерата, °С
        /// </summary>
        public double t_jrm { set; get; }

        /// <summary>
        /// содержание влаги в агломерате, мас. %.
        /// </summary>
        public double f_jrm { set; get; }

        #endregion

        /// <summary>
        /// количество углерода кокса, сжигаемого у фурм, кг/т чугуна
        /// </summary>
        public double CocsFurm { set; get; }

        /// <summary>
        /// расход дутья, м3/т чугуна
        /// </summary>
        public double Vd { set; get; }

        /// <summary>
        /// Расчетный удельный расход дутья
        /// </summary>
        public double Qd = 1130.1;

        /// <summary>
        /// теплоемкости газов и паров воды, кДж/(м3×К)
        /// </summary>
        public const double c_O2 = 1.4276;

        public const double c_N2 = 1.308;

        public const double c_N2_d = 1.4276;

        public const double c_H2O = 1.547;

        public const double c_H2O_d = 1.7775;

        public const double c_CO = 1.323;

        public const double c_H2 = 1.301;

        public const double c_CO2 = 1.877;


        /// <summary>
        /// степень использования водорода в печи
        /// </summary>
        public double n { set; get; } //

       
        #endregion

        #region Обозначение формул

        /// ФОРМУЛЫ ДЛЯ ПРИХОДНОЙ ЧАСТИ 
        
        /// <summary>
        /// Количество тепла, получающегося при горении углерода кокса, определя-ется из уравнения
        /// </summary>
        public static double GetQ_Cocs { set; get; }


        public static double GetQ_Cocs_Pers
        {
            get
            {
                return Math.Round(GetQ_Cocs * 100 / GetQ_SumPrihod, 2);
            }
        }

        /// <summary>
        /// Приход тепла с нагретым дутьем
        /// </summary>
        public static double GetQ_N_D { set; get; }

        public static double GetQ_N_D_Pers
        {
            get
            {
                return Math.Round(GetQ_N_D * 100 / GetQ_SumPrihod, 2);
            }
        }

        /// <summary>
        /// Количество тепла, выделяющегося при конверсии природного газа
        /// </summary>
        public static double GetQ_pg { set; get; }

        public static double GetQ_pg_Pers
        {
            get
            {
                return Math.Round(GetQ_pg * 100 / GetQ_SumPrihod, 2);
            }
        }

        /// <summary>
        /// Количество тепла, выделяющегося при процессе шлакообразования
        /// </summary>
        public static double GetQ_G_i { set; get; }

        public static double GetQ_G_i_Pers
        {
            get
            {
                return Math.Round(GetQ_G_i * 100 / GetQ_SumPrihod, 2);
            }
        }

        /// <summary>
        /// физическое тепло шихты
        /// </summary>
        public static double GetQ_jrm { set; get; }

        public static double GetQ_jrm_Pers
        {
            get
            {
                return Math.Round(GetQ_jrm * 100 / GetQ_SumPrihod, 2);
            }
        }

        /// <summary>
        /// Суммарный приход тепла
        /// </summary>
        public static double GetQ_SumPrihod;

        public static double GetQ_SumPrihod_Pers
        {
            get
            {
                return Math.Round((GetQ_Cocs + GetQ_N_D + GetQ_pg + GetQ_G_i + GetQ_jrm) * 100 / GetQ_SumPrihod, 2);
            }
        }

        /// ФОРМУЛЫ ДЛЯ РАСХОДНОЙ ЧАСТИ 

        /// <summary>
        /// Расход тепла на прямое восстановление оксидов железа
        /// </summary>
        public static double GetQ_pr { set; get; }

        public static double GetQ_pr_Pers
        {
            get
            {
                return Math.Round(GetQ_pr * 100 / GetQ_SumRachod, 2);
            }
        }

        /// <summary>
        /// Расход тепла на прямое восстановление примесей чугуна
        /// </summary>
        public static double GetQ_PR { set; get; }

        public static double GetQ_PR_Pers
        {
            get
            {
                return Math.Round(GetQ_PR * 100 / GetQ_SumRachod, 2);
            }
        }

        /// <summary>
        /// Затраты тепла на процесс десульфурации чугуна
        /// </summary>
        public static double GetQS { set; get; }

        public static double GetQS_Pers
        {
            get
            {
                return Math.Round(GetQS * 100 / GetQ_SumRachod, 2);
            }
        }

        /// <summary>
        /// Затраты тепла на компенсацию отрицательного теплового эффекта восстановления оксидов железа водородом
        /// </summary>
        public static double GetQ_v_H2 { set; get; }

        public static double GetQ_v_H2_Pers
        {
            get
            {
                return Math.Round(GetQ_v_H2 * 100 / GetQ_SumRachod, 2);
            }
        }

        /// <summary>
        /// Количество тепла, уносимого из печи жидким чугуном
        /// </summary>
        public static double GetQ_H { set; get; }

        public static double GetQ_H_Pers
        {
            get
            {
                return Math.Round(GetQ_H * 100 / GetQ_SumRachod, 2);
            }
        }

        /// <summary>
        /// Количество тепла, уносимого из печи жидким шлаком
        /// </summary>
        public static double GetQ_hl { set; get; }

        public static double GetQ_hl_Pers
        {
            get
            {
                return Math.Round(GetQ_hl * 100 / GetQ_SumRachod, 2);
            }
        }

        /// <summary>
        /// Расход тепла на разложение влаги дутья
        /// </summary>
        public static double GetQ_vl { set; get; }

        public static double GetQ_vl_Pers
        {
            get
            {
                return Math.Round(GetQ_vl * 100 / GetQ_SumRachod, 2);
            }
        }

        /// <summary>
        /// Расход тепла на разложение известняка
        /// </summary>
        public static double GetQ_I { set; get; }

        public static double GetQ_I_Pers
        {
            get
            {
                return Math.Round(GetQ_I * 100 / GetQ_SumRachod, 2);
            }
        }

        /// <summary>
        /// Расход тепла на испарение влаги шихты
        /// </summary>
        public static double GetQ_vp_H { set; get; }

        public static double GetQ_vp_H_Pers
        {
            get
            {
                return Math.Round(GetQ_vp_H * 100 / GetQ_SumRachod, 2);
            }
        }

        /// <summary>
        /// Количество тепла, уносимого из печи колошниковым газом
        /// </summary>
        public static double GetQ_KG { set; get; }

        public static double GetQ_KG_Pers
        {
            get
            {
                return Math.Round(GetQ_KG * 100 / GetQ_SumRachod, 2);
            }
        }

        /// <summary>
        /// Тепловые потери печи 
        /// </summary>
        public static double GetQ_Poter { set; get; }

        public static double GetQ_Poter_Pers
        {
            get
            {
                return Math.Round(GetQ_Poter * 100 / GetQ_SumRachod, 2);
            }
        }

        /// <summary>
        /// Суммарный расход тепла
        /// </summary>
        public static double GetQ_SumRachod;

        public static double GetQ_SumRachod_Pers
        {
            get
            {
                return Math.Round((GetQ_pr + GetQ_PR + GetQS + GetQ_v_H2 + GetQ_H + GetQ_hl + GetQ_vl + GetQ_I + GetQ_vp_H + GetQ_KG + GetQ_Poter) * 100 / GetQ_SumRachod, 2);
            }
        }

        #endregion


        #region Расчетный метод программы

        public void Calculate()
        {
            CalculateForm();
            Rachet();
        }

        public void CalculateForm()
        {
            Con_Fe = 100 - Con_Mn - Con_P - Con_Si - Con_Ti - Con_V;

            /// ФОРМУЛЫ ДЛЯ ПРИХОДНОЙ ЧАСТИ 
            GetQ_Cocs = Math.Round(CocsFurm * 9800 * Math.Pow(10, -3), 3);//
            GetQ_N_D = Math.Round(0.001 * Qd * ((0.01 * w * c_O2 + (1 - 0.01 * w) * c_N2_d) * (1 - 0.00124 * f) + 0.00124 * f * c_H2O_d) * td, 3);//
            GetQ_pg = Math.Round(0.001 * Vpg * 1657, 3);
            GetQ_G_i = Math.Round(1128 * Math.Pow(10, -5) * G_i * Coef_i, 3);
            GetQ_jrm = Math.Round(0.001 * G_jrm * C_jrm * t_jrm, 3);
            GetQ_SumPrihod = Math.Round(GetQ_Cocs + GetQ_N_D + GetQ_pg + GetQ_G_i + GetQ_jrm, 3);

            /// ФОРМУЛЫ ДЛЯ РАСХОДНОЙ ЧАСТИ 
            GetQ_pr = Math.Round(0.01 * Con_Fe * rd * 2716, 3);//
            GetQ_PR = Math.Round(0.01 * (5220 * Con_Mn + 22600 * Con_Si + 15490 * Con_P + 36167 * Con_Ti + 7982 * Con_V), 3);//
            GetQS = Math.Round(1734 * Math.Pow(10, -5) * U_hl * S_hl, 3);//
            GetQ_v_H2 = Math.Round(1731 * Math.Pow(10, -4) * (0.00124 * f * Qd + 0.01 * Vpg * 200) * n, 3);//
            GetQ_H = Math.Round(1 * c_H * t_H, 3);//
            GetQ_hl = Math.Round(0.001 * U_hl * c_hl * (t_H + 50), 3);//
            GetQ_vl = Math.Round(1.24 * Math.Pow(10, -5) * Vd * f * 6912, 3);//
            GetQ_I = Math.Round(4042 * Math.Pow(10, -5) * G_i * Coef_i, 3);//
            GetQ_vp_H = Math.Round(2452 * Math.Pow(10, -5) * (G_jrm * f_jrm + G_i * f_i + f_k * k), 3);//
            GetQ_KG = Math.Round(Math.Pow(10, -5) * ((mas_CO2 * c_CO2 + mas_CO * c_CO + mas_N2 * c_N2 + mas_H2 * c_H2) * Vkg + (G_jrm * f_jrm + G_i * f_i + k * f_k + ((Vkg * mas_H2 * n) / (1 - n))) * c_H2O) * T_kg, 3);//

            GetQ_Poter = Math.Round(GetQ_SumPrihod - (GetQ_pr + GetQ_PR + GetQS + GetQ_v_H2 + GetQ_H + GetQ_hl + GetQ_vl + GetQ_I + GetQ_vp_H + GetQ_KG), 3);
            GetQ_SumRachod = Math.Round(GetQ_pr + GetQ_PR + GetQS + GetQ_v_H2 + GetQ_H + GetQ_hl + GetQ_vl + GetQ_I + GetQ_vp_H + GetQ_KG + GetQ_Poter, 3);

        }

        public Result Rachet()
        {
            return new Result
            {
                /// ФОРМУЛЫ ДЛЯ ПРИХОДНОЙ ЧАСТИ 
                _GetQ_Cocs = (double)GetQ_Cocs,
                _GetQ_N_D = (double)GetQ_N_D,
                _GetQ_pg = (double)GetQ_pg,
                _GetQ_G_i = (double)GetQ_G_i,
                _GetQ_jrm = (double)GetQ_jrm,

                /// ФОРМУЛЫ ДЛЯ РАСХОДНОЙ ЧАСТИ 
                _GetQ_pr = (double)GetQ_pr,
                _GetQ_PR = (double)GetQ_PR,
                _GetQS = (double)GetQS,
                _GetQ_v_H2 = (double)GetQ_v_H2,
                _GetQ_H = (double)GetQ_H,
                _GetQ_hl = (double)GetQ_hl,
                _GetQ_vl = (double)GetQ_vl,
                _GetQ_I = (double)GetQ_I,
                _GetQ_vp_H = (double)GetQ_vp_H,
                _GetQ_KG = (double)GetQ_KG,
                _GetQ_Poter = (double)GetQ_Poter
            };

        }

        #endregion
    }
    public class Result
    {
        #region Формулы для расчета 

        /// ФОРМУЛЫ ДЛЯ ПРИХОДНОЙ ЧАСТИ 
        public double _GetQ_Cocs { set; get; }
        public double _GetQ_N_D { set; get; }
        public double _GetQ_pg { set; get; }
        public double _GetQ_G_i { set; get; }
        public double _GetQ_jrm { set; get; }

        /// ФОРМУЛЫ ДЛЯ РАСХОДНОЙ ЧАСТИ 
        public double _GetQ_pr { set; get; }
        public double _GetQ_PR { set; get; }
        public double _GetQS { set; get; }
        public double _GetQ_v_H2 { set; get; }
        public double _GetQ_H { set; get; }
        public double _GetQ_hl { set; get; }
        public double _GetQ_vl { set; get; }
        public double _GetQ_I { set; get; }
        public double _GetQ_vp_H { set; get; }
        public double _GetQ_KG { set; get; }
        public double _GetQ_Poter { set; get; }
        #endregion
    }
}
