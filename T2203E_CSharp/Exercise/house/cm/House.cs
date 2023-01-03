using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T2203E_CSharp.Exercise.house.cm
{
    public class House : IHouse
    {
        private string soNha;
        private string diaChi;
        private string loaiNha;

        public string SoNha
        {
            get { return soNha; }
            set { soNha = value; }
        }
        public string DiaChi { get; set; }
        public string LoaiNha { get; set; }



        public House() { }

        public House(string soNha, string diaChi, string loaiNha)
        {
            this.soNha = soNha;
            this.diaChi = diaChi;
            this.loaiNha = loaiNha;
        }

        public virtual void display()
        {
            throw new NotImplementedException();
        }

        public virtual void input()
        {
            throw new NotImplementedException();
        }
    }
}
