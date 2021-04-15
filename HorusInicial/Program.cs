using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HorusInicial
{
    class Program
    {
        static void Main(string[] args)
        {
            string ProgServidor = @"\\192.168.10.3\Volume_1\INFORMATICA\INSTALAÇÕES\HORUS\HorosExec.exe";
            string ProgLocal = @"C:\HORUS\HorosExec.exe";

            string PastaServidor = @"\\192.168.10.3\Volume_1\INFORMATICA\INSTALAÇÕES\HORUS";
            string PastaLocal = @"C:\HORUS";

            if (File.Exists(ProgServidor))
            {
                var versionInfoServidor = FileVersionInfo.GetVersionInfo(ProgServidor);
                string versionServidor = versionInfoServidor.FileVersion;

                if (File.Exists(ProgLocal))
                {
                    var versionInfoLocal = FileVersionInfo.GetVersionInfo(ProgLocal);
                    string versionLocal = versionInfoLocal.FileVersion;

                    if (versionServidor != versionLocal)
                    {
                        System.IO.DirectoryInfo di = new DirectoryInfo(PastaLocal);

                        foreach (FileInfo file in di.GetFiles())
                        {
                            file.Delete();
                        }
                        foreach (DirectoryInfo dir in di.GetDirectories())
                        {
                            dir.Delete(true);
                        }


                        foreach (string dir in System.IO.Directory.GetDirectories(PastaServidor, "*", System.IO.SearchOption.AllDirectories))
                        {
                            System.IO.Directory.CreateDirectory(System.IO.Path.Combine(PastaLocal, dir.Substring(PastaServidor.Length + 1)));
                        }

                        foreach (string file_name in System.IO.Directory.GetFiles(PastaServidor, "*", System.IO.SearchOption.AllDirectories))
                        {
                            System.IO.File.Copy(file_name, System.IO.Path.Combine(PastaLocal, file_name.Substring(PastaServidor.Length + 1)), true);
                        }

                        System.Diagnostics.Process.Start(ProgLocal);
                        System.Environment.Exit(1);
                    }
                    else
                    {
                        System.Diagnostics.Process.Start(ProgLocal);
                        System.Environment.Exit(1);
                    }
                }
                else
                {
                    foreach (string dir in System.IO.Directory.GetDirectories(PastaServidor, "*", System.IO.SearchOption.AllDirectories))
                    {
                        System.IO.Directory.CreateDirectory(System.IO.Path.Combine(PastaLocal, dir.Substring(PastaServidor.Length + 1)));
                    }

                    foreach (string file_name in System.IO.Directory.GetFiles(PastaServidor, "*", System.IO.SearchOption.AllDirectories))
                    {
                        System.IO.File.Copy(file_name, System.IO.Path.Combine(PastaLocal, file_name.Substring(PastaServidor.Length + 1)),true);
                    }

                    System.Diagnostics.Process.Start(ProgLocal);
                    System.Environment.Exit(1);
                }
            }
            else
            {
                System.Diagnostics.Process.Start(ProgLocal);
                System.Environment.Exit(1);
            }
        }
    }
}
