using System.Text.Json;
using System.Text.Json.Serialization;

namespace Program
{
    public class Program
    {
        public static void Main()
        {
            Console.WriteLine(new Dakuten().Conv("だくてんへんかん"));
        }
    }

    /// <summary>
    /// 濁点変換
    /// </summary>
    public class Dakuten
    {
        /// <summary>
        /// 濁点変換用データ
        /// </summary>
        private readonly Mark marks = new();

        /// <summary>
        /// Json用構造体
        /// </summary>
        public class Mark
        {
            [JsonPropertyName("dakuten")]
            public string[] Dakuten { get; set; }
            [JsonPropertyName("nomal")]
            public string[] Nomal { get; set; }
            [JsonPropertyName("skip")]
            public string[] Skip { get; set; }

            public Mark()
            {
                // 初期化
                this.Dakuten = Array.Empty<string>();
                this.Nomal = Array.Empty<string>();
                this.Skip = Array.Empty<string>();
            }
        }

        /// <summary>
        /// コンストラクタ
        /// </summary>
        /// <param name="jsonFile">Jsonファイル名</param>
        public Dakuten(string jsonFile = "mark.json")
        {
            // jsonファイル読み込み
            var json = File.ReadAllText(jsonFile);
            marks = JsonSerializer.Deserialize<Mark>(json)!;
        }

        /// <summary>
        /// 濁点変換
        /// </summary>
        /// <param name="value">変換文字</param>
        /// <returns>変換された文字</returns>
        public string Conv(string value)
        {
            return string.Join("", value.ToCharArray()
            .Select(c => c.ToString())
            .Select(c =>
            {
                if (Array.IndexOf(marks.Skip, c) > -1)
                {
                    return $"{c}";
                }
                else if (Array.IndexOf(marks.Dakuten, c) > -1)
                {
                    return $"{marks.Nomal[Array.IndexOf(marks.Dakuten, c)]}゛";
                }
                else
                {
                    return $"{c}゛";
                }
            }));
        }
    }
}
