using Fit2.Models;
using Fit2.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fit2
{
    public static class AwesomeFormControllMagicWizzard
    {
        private static Control magic;

        private static UserControl menuHeader;

        private static Stack<AncientMagic> ancientMagics;

        class AncientMagic
        {
            public string Spell { get; set; }
            public Client Wizzard { get; set; }
        }

        public static void Init(Control control)
        {
            magic = control;
            menuHeader = new MenuHeader();
            ancientMagics = new Stack<AncientMagic>();
        }

        private static void nextPage(UserControl userControl)
        {
            newPage(userControl);
        }

        public static void AwesomeNextPageMagicFunction(string className, Client client=null, bool b = true)
        {
            if(b)
                ancientMagics.Push(new AncientMagic()
                {
                    Spell = className,
                    Wizzard = client
                });
            className = "Fit2.Views."+className;
            Type type = Type.GetType(className);
            if (type != null)
                if(client==null)
                    nextPage((UserControl)Activator.CreateInstance(type));
            else
                nextPage((UserControl)Activator.CreateInstance(type, client));
        }

        public static void AvadaKedavra()
        {
            AncientMagic am;
            try
            {
                ancientMagics.Pop();
                am = ancientMagics.Peek();
            }
            catch(Exception ex)
            {
                am = null;
            }
            
            if (am != null)
            {
                AwesomeNextPageMagicFunction(am.Spell, am.Wizzard, false);
            }
        }

        private static void newPage(UserControl userControl)
        {
            
            foreach(Control c in magic.Controls.Find("WXSD", true))
            {
                c.Dispose();
            }
            magic.Controls.Clear();
            userControl.Name = "WXSD";
            FlowLayoutPanel flowLayoutPanel = new FlowLayoutPanel();
            flowLayoutPanel.Controls.Add(menuHeader);
            flowLayoutPanel.Controls.Add(userControl);
            flowLayoutPanel.Size = magic.Size;
            magic.Controls.Add(flowLayoutPanel);
        }
    }
}
