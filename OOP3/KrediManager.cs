using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    interface IKrediManager // interface oldugunu belirtmek amaçlı başına I harfi yazarız
    {
        void Hesapla();
        void BiseyYap();

        // interfaceleri birbirinin alternatifi olan ama kod içerikleri farklı olan durumlar için kullanırız
    }
}
