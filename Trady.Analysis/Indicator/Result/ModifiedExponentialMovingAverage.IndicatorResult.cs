﻿using System;
using static Trady.Analysis.Indicator.ModifiedExponentialMovingAverage;

namespace Trady.Analysis.Indicator
{
    public partial class ModifiedExponentialMovingAverage : IndicatorBase<IndicatorResult>
    {
        public class IndicatorResult : IndicatorResultBase
        {
            public IndicatorResult(DateTime dateTime, decimal? ema) : base(dateTime, ema)
            {
            }

            public decimal? Ema => Values[0];
        }
    }
}