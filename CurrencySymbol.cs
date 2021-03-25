using System;
using System.Collections.Generic;
using System.Text;


namespace ExOffice
{
    class CurrencySymbol
    {
#nullable enable
        private Decimal _SellRate,_BuyRate;
        private String _Symbol;
        public CurrencySymbol(String Symbol, Decimal BuyRate,Decimal SellRate)
        {
            _Symbol = Symbol.ToUpper();
            _BuyRate = BuyRate;
            _SellRate = SellRate;
        }
        public Decimal SellRate { set { _SellRate = value; } get { return _SellRate; } }
        public Decimal BuyRate { set { _BuyRate = value; } get { return _BuyRate; } }
        public String Symbol { get { return _Symbol; } }
    }
}
