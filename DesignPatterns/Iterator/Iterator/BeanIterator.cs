using Iterator.Collection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterator.Iterator
{
    public class BeanIterator : IBeanIterator
    {
        private BertieBottsEveryFlavorBeanBox bertieBottsEveryFlavorBeanBox;
        private int current = 0;
        private int step = 1;

        public BeanIterator(BertieBottsEveryFlavorBeanBox bertieBottsEveryFlavorBeanBox)
        {
            this.bertieBottsEveryFlavorBeanBox = bertieBottsEveryFlavorBeanBox;
        }

        public bool IsDone => current >= bertieBottsEveryFlavorBeanBox.Count;

        public EveryFlavorBean? First()
        {
            current = 0;
            return bertieBottsEveryFlavorBeanBox[current] as EveryFlavorBean;
        }

        public EveryFlavorBean? Next()
        {
            current += step;
            if (!IsDone)
                return bertieBottsEveryFlavorBeanBox[current] as EveryFlavorBean;
            else
                return null;
        }

        public EveryFlavorBean CurrentBean => bertieBottsEveryFlavorBeanBox[current] as EveryFlavorBean;
    }
}
