using Ante.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace Ante.Helpers
{
    public class Essentials
    {
        public Essentials()
        {
            
        }

        private string ToFirstLetterUpper(string word)
        {
            return System.Globalization.CultureInfo.CurrentCulture.TextInfo.ToTitleCase(word.ToLower());
        }

        public async Task<List<Country>> LoadCountriesAsync()
        {
            try
            {
                var files = Newtonsoft.Json.JsonConvert.DeserializeObject<List<Country>>(await ReadTextFile());
                files.ForEach(a => a.name = ToFirstLetterUpper(a.name));
                return files;
            }
            catch(Exception ce)
            {
                throw ce;
            }
        }

        private async Task<string> ReadTextFile()
        {
            try
            {
                string text = "";
                Stream stream = this.GetType().Assembly.GetManifestResourceStream($"Ante.Resources.CountryCodeJson.txt");
                using (var reader = new System.IO.StreamReader(stream))
                {
                    text = reader.ReadToEnd();
                }
                return text;
            }
            catch (Exception ex)
            {
                string x = ex.Message;
                return "";
            }
        }
    }
}
