using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayerr
{
    public class EntityPersonel //normal hali ile "class EntityLayer " 
                                //erişim belirleyicisi belirtilenmediğinde her zaman private olarak tanımlandığını biliyoruz,
                                //fakat biz bu katmandaki verileri DAL katmanındaki crud işlemlerinde
                                //kullanabilmek için başına mutlaka erişim belirleyicisi olarak "public" yazmalıyız.
    {
        private int id;
        private string ad;
        private string soyad;
        private string sehir;
        private string gorev;
        private short maas;//sql de smallint olan veriler short olarak tanımlanır !!!

        //bu verileri diğer katmanlarda kullanbilmek için(CRUD işlemlerinde) ve aynı zammanda 
        //orijinal verileri koruyabilmek için enkapsulatıon ile properti oluşturduk
        //kısa yolu = ctrl+r+e
        //bu durumda id olan orijanl veriyi kapsulleyıp Id adındaki bir property ile çağırarak
        //veriyi korumuş olduk.

        public int Id { get => id; set => id = value; }
        public string Ad { get => ad; set => ad = value; }
        public string Soyad { get => soyad; set => soyad = value; }
        public string Sehir { get => sehir; set => sehir = value; }
        public string Gorev { get => gorev; set => gorev = value; }
        public short Maas { get => maas; set => maas = value; }
    }
}
