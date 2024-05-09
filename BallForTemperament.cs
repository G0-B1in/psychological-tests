﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace Курсовой_2._0
{
    /// <summary>
    /// банк данных для теста на темперамент
    /// </summary>
    public static class BallForTemperament
    {
        // общее количество плюсов
        public static int allCount { get; set; }

        // количество плюсов по каждому темпераменту
        public static int T1Count { get; set; }
        public static int T2Count { get; set; }
        public static int T3Count { get; set; }
        public static int T4Count { get; set; }

        // номер вопроса
        public static int page { get; set; }

        // процентное соотношение теммераментов
        public static double percent1 { get; set; }
        public static double percent2 { get; set; }
        public static double percent3 { get; set; }
        public static double percent4 { get; set; }

        // преобладающий тип темперамента
        public static double HightPercent { get; set; } 
        public static string HightPercentTemp { get; set; } 
        public static string TypeTemp { get; set; }



        // определение процентного сооьношения темпераментов
        public static void CheckTemperament()
        {
            percent1 = Math.Ceiling((double)T1Count / (double)allCount * 100);
            percent2 = Math.Ceiling((double)T2Count / (double)allCount * 100);
            percent3 = Math.Ceiling((double)T3Count / (double)allCount * 100);
            percent4 = Math.Ceiling((double)T4Count / (double)allCount * 100);

            // определение преобладающего типа темперамента
            if (percent1 > percent2 & percent1 > percent3 & percent1 > percent4)
            {
                HightPercentTemp = "Флегматик. Новые формы поведения вырабатываются медленно, но являются стойкими. Обладает медлительностью и спокойствием в действиях, мимике и речи, ровностью, постоянством, глубиной чувств и настроений. Настойчивый и упорный, он редко выходитиз себя, не склонен к аффектам, рассчитав свои силы, доводит дело до конца, ровен вотношениях, в меру общителен, не любит попусту болтать. Экономит силы, попусту их нетратит. В зависимости от условий в одних случаях флегматик может характеризоваться положительными чертами - выдержкой, глубиной мыслей, постоянством,основательностью, в других - ленью и склонностью к выполнению одних лишьпривычных действий. ";
                HightPercent = percent1;
                TypeTemp = "Флегматик";
            }
            else
            {
                if (percent2 > percent3 & percent2 > percent4)
                {
                    HightPercentTemp = "Меланхолик. Обладает высокой чувствительностью: присутствует глубина чувств при слабом их выражении.Ему свойственна сдержанность и приглушенность речи и движений, скромность, осторожность. В нормальных условиях меланхолик - человек глубокий, содержательный, ответственный, успешно справляться с жизненными задачами. При неблагоприятных условиях может превратиться в замкнутого, тревожного, ранимого человека, склонного к тяжелым внутренним переживаниям таких жизненных обстоятельств, которые этого не заслуживают.";
                    HightPercent = percent2;
                    TypeTemp = "Меланхолик";
                }
                else
                {
                    if (percent3 > percent4)
                    {
                        HightPercentTemp = "Холерик. Отличается повышенной возбудимостью, действия прерывисты. Ему свойственны резкость и стремительность движений, сила, импульсивность, яркая выраженность эмоциональных переживаний. Вследствие неуравновешенности, увлекшись делом, склонен действовать изо всех сил, истощаться больше, чем следует. Имея общественные интересы, темперамент проявляет в инициативности, энергичности, принципиальности. При отсутствии духовной жизни холерический темперамент часто проявляется в раздражительности, вспыльчивости при эмоциональных обстоятельствах.";
                        HightPercent = percent3;
                        TypeTemp = "Холерик";
                    }
                    else
                    {
                        HightPercentTemp = "Сангвиник. Быстро приспосабливается к новым условиям, быстро сходится с людьми, общителен. Чувства легко возникают и сменяются, эмоциональные переживания, как правило неглубоки. Мимика богатая, подвижная, выразительная. Несколько непоседлив, нуждается в новых впечатлениях, недостаточно регулирует свои импульсы, не умеет строго придерживаться выработанного распорядка жизни, системы в работе. В связи с этим не может успешно выполнять дело, требующее равной затраты сил, длительного и методичного напряжения, усидчивости, устойчивости внимания, терпения. При отсутствии серьезных целей, глубоких мыслей, творческой деятельности вырабатывается поверхностность и непостоянство.";
                        HightPercent = percent4;
                        TypeTemp = "Сангвиник";


                    }
                }
            }

        }
    }
}
