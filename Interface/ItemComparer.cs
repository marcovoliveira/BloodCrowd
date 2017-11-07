using System;
using System.Collections;
using System.Windows.Forms;

namespace Interface
{
    public class ItemComparer : IComparer
    {
        // Vai buscar a coluna que vai ordenar
        public int Column { get; set; }

        // Vai buscar a ordem da ordenação
        public SortOrder Order { get; set; }

        public ItemComparer(int colIndex)
        {
            Column = colIndex;
            Order = SortOrder.None;
        }

        public int Compare(object a, object b)
        {
            int result;
            ListViewItem itemA = a as ListViewItem;
            ListViewItem itemB = b as ListViewItem;
            if (itemA == null && itemB == null)
                result = 0;
            else if (itemA == null)
                result = -1;
            else if (itemB == null)
                result = 1;
            if (itemA == itemB)
                result = 0;
            // Compara as datas 
            DateTime x1, y1;
            // Tenta fazer parse das dos objectos para data 
            if (!DateTime.TryParse(itemA.SubItems[Column].Text, out x1))
                x1 = DateTime.MinValue;
            if (!DateTime.TryParse(itemB.SubItems[Column].Text, out y1))
                y1 = DateTime.MinValue;
            result = DateTime.Compare(x1, y1);
            if (x1 != DateTime.MinValue && y1 != DateTime.MinValue)
                goto done;
            //Comparação de numeros
            decimal x2, y2;
            if (!Decimal.TryParse(itemA.SubItems[Column].Text, out x2))
                x2 = Decimal.MinValue;

            if (!Decimal.TryParse(itemB.SubItems[Column].Text, out y2))
                y2 = Decimal.MinValue;
            result = Decimal.Compare(x2, y2);

            if (x2 != Decimal.MinValue && y2 != Decimal.MinValue)
                goto done;
            //Comparação de duas strings
            result = String.Compare(itemA.SubItems[Column].Text, itemB.SubItems[Column].Text);

            done:
            // Se a ordem for descendente
            if (Order == SortOrder.Descending)
                // Vai inverter o valor devolvido na comparaçao
                result *= -1;
            return result;
        }
    }
}