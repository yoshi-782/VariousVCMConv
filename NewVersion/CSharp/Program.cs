using System;
using System.Linq;
using System.Text;

string DakutenConv(string arg){
            return string.Join("", Enumerable.ToList<char>(arg).Select((c) =>{
                var normalize = c.ToString().Normalize(NormalizationForm.FormD);
                return normalize.Length > 1 ? normalize : $"{normalize}゛";
            }).ToArray());
        }

string EasyDakutenConv(string arg){
    var result = "";
    foreach(char c in arg){
        var normalize = c.ToString().Normalize(NormalizationForm.FormD);
        result += normalize.Length == 1 ? $"{normalize}゛" : normalize;
    }
    return result;
}

// LINQ
Console.WriteLine($"result1: {DakutenConv("だくてんテスト")}");
// foreach
Console.WriteLine($"result2: {EasyDakutenConv("だくてんテスト")}");
