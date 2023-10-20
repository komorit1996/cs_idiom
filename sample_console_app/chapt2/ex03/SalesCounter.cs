/*

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sample_console_app.chapt2.ex03
{
    public class SalesCounter
    {
        private IEnumerable<Sale> _sales; // List<T> のみではなく、Sale の配列を受け付けることもできるようになる。さらに、add や delete もないので変更がされない。

        // コンストラクタ
        public SalesCounter(string filePath)
        {
            // SalesCounter が呼び出された時、csv ファイルを先に読み込んでしまうように変更
            _sales = ReadSales(filePath);
        }

        // 集計作業
        public IDictionary<string, int> GetPerStoreSales()
        {
            var dict = new Dictionary<string, int>();
            //
            foreach (Sale sale in _sales)
            {
                if (dict.ContainsKey(sale.ProductCategory))
                // change > if (dict.ContainsKey(sale.ShopName))
                {
                    dict[sale.ProductCategory] += sale.Amount;
                }
                else
                {
                    // 値が存在していなければ、初期値として設定する
                    dict[sale.ProductCategory] = sale.Amount;
                }
            }
            return dict;
        }
        // 売上ファイルの読み込み
        private static IEnumerable<Sale> ReadSales(string filePath)
        {
            List<Sale> sales = new List<Sale>();
            string[] lines = File.ReadAllLines(filePath);

            foreach (string line in lines)
            {
                string[] items = line.Split(",");
                Sale sale = new Sale
                {
                    ShopName = items[0],
                    ProductCategory = items[1],
                    Amount = int.Parse(items[2])
                };
                sales.Add(sale);
            }

            return sales;
        }

    }

}

*/
