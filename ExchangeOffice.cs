using System;
using System.Collections.Generic;
using System.Text;

namespace ExOffice
{
    class ExchangeOffice
    
    {
        private List<CurrencySymbol> _Currencies ;
        public ExchangeOffice()
        {
            _Currencies = new List<CurrencySymbol>();
        }

        //updates acurrensy if at exists (returns true#, if id does not itr returrns false. 
        public bool UpdateCurrency(String Symbol, Decimal BuyRate, decimal SellRate)
        {
            string _sy = Symbol.ToUpper();
            foreach(CurrencySymbol s in _Currencies)
            {
                if (s.Symbol == _sy) 
                {
                    s.BuyRate = BuyRate;
                    s.SellRate = SellRate;
                    return true;
                    
                }

            }
            return false;
        }
        // Adds currency if it does not exsist, if it does  update the rates
        public void AddCurrency(String Symbol, decimal BuyRate, decimal SellRate) 
        {
            string _s = Symbol.ToUpper();
            if (UpdateCurrency(_s, BuyRate, SellRate)) { }
            else { _Currencies.Add(new CurrencySymbol(_s, BuyRate, SellRate)); }
        }
        
        public CurrencySymbol GetCurrency(String Symbol)
        {
           
            foreach( CurrencySymbol s in _Currencies)
            {
                if (s.Symbol ==Symbol.ToUpper())
                {
                    return s;
                }
            }
            return new CurrencySymbol(null, 0, 0);
        }
    }
}
