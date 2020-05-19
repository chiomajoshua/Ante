using Ante.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ante.Utils
{
    public class PickerService
    {
        public static List<Country> GetCountries()
        {
            var countries = new List<Country>()
            {
                new Country() {codevalue=1, code="+234", name = "Nigeria"},
                new Country() {codevalue=2, code="+233", name = "Ghana"},
                new Country() {codevalue=3, code="+237", name = "Cameroon"},
                new Country() {codevalue=4, code="+228", name = "Togo"},
                new Country() {codevalue=5, code="+229", name = "Benin"}
            };
            return countries;
        }
    }
}