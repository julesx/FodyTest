using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PropertyChanged;

namespace FodyTest.PCL
{
    [AddINotifyPropertyChangedInterface]
    public class FodyTestVm
    {
        public DateTime LabelText { get; set; } = DateTime.Now;

        public FodyTestVm()
        {
            UpdateDate();
        }

        private async void UpdateDate()
        {
            while (true)
            {
                LabelText = DateTime.Now;

                await Task.Delay(1000);
            }
        }
    }
}
