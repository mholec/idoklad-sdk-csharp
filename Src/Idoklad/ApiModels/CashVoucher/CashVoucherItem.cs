﻿using IdokladSdk.Enums;

namespace IdokladSdk.ApiModels
{
    public class CashVoucherItem
    {
        public decimal Amount { get; set; }

        public string Name { get; set; }

        public decimal Price { get; set; }

        public PriceTypeEnum PriceType { get; set; }

        public byte Status { get; set; }

        public string VariableSymbol { get; set; }

        public decimal VatRate { get; set; }

        public VatRateTypeEnum VatRateType { get; set; }
    }
}
