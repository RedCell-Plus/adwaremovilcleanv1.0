using System.Diagnostics;
using System.Drawing;
using System.Media;
using System.Threading.Tasks;
using System.Windows.Forms;
using System;

using System;
using System.Drawing;
using System.Windows.Forms;
using System.Diagnostics;
using System.Media;
using System.Threading.Tasks;
using Microsoft.VisualBasic;

namespace AntiVirus
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
            await Task.Delay(500);

            bool isConnected = await ConnectDeviceAsync();
            if (!isConnected)
            {
                addlog("NO SE DETECTO EL DISPOSITIVO", Color.Red, true, false);
                return;
            }

            progressBar1.Value = 0;
            progressBar1.Maximum = 100;

            addlog("\r\n DISPOSITIVO ENCONTRADO ", Color.BlueViolet, true, false);
            addlog("\r\n ", Color.Black, true, false);
            addlog("\r\n NUMERO DE SERIE : ", Color.Black, true, false);

            string serialNo = await AdbCommandAsync("shell getprop ro.serialno");
            addlog(serialNo, Color.Green, true, false);

            progressBar1.Value = 10;
            addlog(" PROCESADOR : ", Color.Black, true, false);

            string brand = await AdbCommandAsync("shell getprop Build.BRAND");
            addlog(brand, Color.Green, true, false);

            await Task.Delay(100);
            addlog(" MARCA : ", Color.Black, true, false);
            await Task.Delay(100);

            string productBrand = await AdbCommandAsync("shell getprop ro.product.brand");
            addlog(productBrand, Color.Green, true, false);

            await Task.Delay(100);
            addlog(" MODELO : ", Color.Black, true, false);
            await Task.Delay(100);

            string productModel = await AdbCommandAsync("shell getprop ro.product.model");
            addlog(productModel, Color.Green, true, false);

            progressBar1.Value = 20;
            await Task.Delay(100);
            addlog(" NOMBRE DEL PRODUCTO : ", Color.Black, true, false);
            await Task.Delay(100);

            string productName = await AdbCommandAsync("shell getprop ro.product.name");
            addlog(productName, Color.Green, true, false);

            await Task.Delay(100);
            addlog(" PARCHE DE SEGURIDAD : ", Color.Black, true, false);
            await Task.Delay(300);

            string securityPatch = await AdbCommandAsync("shell getprop ro.build.version.security_patch");
            addlog(securityPatch, Color.Green, true, false);

            progressBar1.Value = 30;
            await Task.Delay(100);
            addlog(" VERSION DE ANDROID : ", Color.Black, true, false);

            string androidVersion = await AdbCommandAsync("shell getprop ro.build.version.release");
            addlog(androidVersion, Color.Green, true, false);

            await Task.Delay(100);
            addlog(" NOMBRE CODIGO : ", Color.Black, true, false);
            await Task.Delay(100);

            string platform = await AdbCommandAsync("shell getprop ro.board.platform");
            addlog(platform, Color.Green, true, false);

            progressBar1.Value = 40;
            await Task.Delay(100);
            addlog(" No DE COMPILACION : ", Color.Black, true, false);
            await Task.Delay(100);

            string buildId = await AdbCommandAsync("shell getprop ro.build.display.id");
            addlog(buildId, Color.Green, true, false);

            await Task.Delay(100);
            addlog(" FECHA : ", Color.Black, true, false);
            await Task.Delay(100);

            string buildDate = await AdbCommandAsync("shell getprop ro.bootimage.build.date");
            addlog(buildDate, Color.Green, true, false);

            await Task.Delay(100);
            addlog(" ESTATUS DE KG : ", Color.Black, true, false);
            await Task.Delay(100);

            string kgState = await AdbCommandAsync("shell getprop knox.kg.state");
            addlog(kgState, Color.Green, true, false);

            progressBar1.Value = 50;
            await Task.Delay(100);
            addlog(" COMPANIA : ", Color.Black, true, false);
            await Task.Delay(100);

            string salesCode = await AdbCommandAsync("shell getprop persist.audio.sales_code");
            addlog(salesCode, Color.Green, true, false);

            await Task.Delay(100);
            addlog(" BASEBAND : ", Color.Black, true, false);
            await Task.Delay(100);

            string baseband = await AdbCommandAsync("shell getprop gsm.version.baseband");
            addlog(baseband, Color.Green, true, false);

            progressBar1.Value = 60;
            Delay(0.1);
            addlog(" VERSION DEL KNOX : ", Color.Black, true, false);
            await Task.Delay(100);

            string knoxConfig = await AdbCommandAsync("shell getprop ro.config.knox");
            addlog(knoxConfig, Color.Green, true, false);

            await Task.Delay(100);
            addlog(" CPU : ", Color.Black, true, false);
            await Task.Delay(100);

            string cpuAbi = await AdbCommandAsync("shell getprop ro.product.cpu.abi");
            addlog(cpuAbi, Color.Green, true, false);

            addlog(" TAMANO DE MEMORIA : ", Color.Black, true, false);
            await Task.Delay(100);

            string emmcSize = await AdbCommandAsync("shell getprop ro.emmc_size");
            addlog(emmcSize, Color.Green, true, false);

            progressBar1.Value = 70;
            await Task.Delay(100);
            addlog(" USUARIO : ", Color.Black, true, false);
            await Task.Delay(100);

            string buildUser = await AdbCommandAsync("shell getprop ro.build.user");
            addlog(buildUser, Color.Green, true, false);

            addlog(" PAIS : ", Color.Black, true, false);
            await Task.Delay(100);

            string countryCode = await AdbCommandAsync("shell getprop ro.csc.country_code");
            addlog(countryCode, Color.Green, true, false);

            addlog(" CONFIGURACION USB : ", Color.Black, true, false);
            await Task.Delay(100);

            string usbConfig = await AdbCommandAsync("shell getprop sys.usb.config");
            addlog(usbConfig, Color.Green, true, false);

            progressBar1.Value = 80;
            addlog(" TIENE SIM O NO : ", Color.Black, true, false);
            await Task.Delay(100);

            string simState = await AdbCommandAsync("shell getprop gsm.sim.state");
            addlog(simState, Color.Green, true, false);

            addlog(" ZONA HORARIA : ", Color.Black, true, false);
            await Task.Delay(100);

            string timezone = await AdbCommandAsync("shell getprop persist.sys.timezone");
            addlog(timezone, Color.Green, true, false);

            progressBar1.Value = 90;
            await Task.Delay(100);
            addlog(" DONDE ESTA EL FRP : ", Color.Black, true, false);
            await Task.Delay(100);

            string frpPst = await AdbCommandAsync("shell getprop ro.frp.pst");
            addlog(frpPst, Color.Green, true, false);

            addlog(" BLOQUEADO O DESBLOQUEADO? : ", Color.Black, true, false);
            await Task.Delay(100);

            string ssuStatus = await AdbCommandAsync("shell getprop ssu.status");
            addlog(ssuStatus, Color.Green, true, false);

            progressBar1.Value = 100;
            addlog("\r\n  =========================================  ", Color.Green, true, false);
            Delay(0.5);
            addlog("\r\n ERES UN CHINGON MI AMIGO!!! ", Color.OrangeRed, true, false);

            PlaySound("Data/2.wav");
            await Task.Delay(30000);
        }

        private async void button2_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
            bool isConnected = await ConnectDeviceAsync();
            if (!isConnected)
            {
                addlog("CONECTA EL PINCHE TELEFONO PRIMERO WEI!!", Color.Red, true, false);
                return;
            }

            progressBar1.Value = 0;
            progressBar1.Maximum = 100;

            addlog("\r\n YA ENCONTRE EL TELEFONO, DEJA TE DIGO CUAL ES ", Color.BlueViolet, true, false);
            addlog("\r\n ", Color.Black, true, false);
            addlog("\r\n NUMERO DE SERIE : ", Color.Black, true, false);

            string serialNo = await AdbCommandAsync("shell getprop ro.serialno");
            addlog(serialNo, Color.Green, true, false);

            addlog("\r\n ", Color.Black, true, false);
            addlog("\r\n REMOVIENDO TODO EL VIRUS PORKY, ESPERA... ", Color.Black, true, false);

            // Lista completa de comandos de desinstalación
            await AdbCommandAsync("shell pm clear --user 0 com.google.android.webview");
            await AdbCommandAsync("shell pm clear --user 0 com.android.vending");
            await AdbCommandAsync("shell pm uninstall --user 0 com.facebook.katana");
            await AdbCommandAsync("shell pm uninstall --user 0 com.ezt.pdfreader.pdfviewer");
            await AdbCommandAsync("shell pm uninstall --user 0 com.trustedapp.pdfreaderpdfviewer");
            await AdbCommandAsync("shell pm uninstall --user 0 com.google.android.contactkeys");
            await AdbCommandAsync("shell pm uninstall --user 0 com.google.android.safetycore");
            await AdbCommandAsync("shell pm uninstall --user 0 com.lemon.lvoverseas");
            await AdbCommandAsync("shell pm uninstall --user 0 com.handmark.expressweather");
            await AdbCommandAsync("shell pm uninstall --user 0 com.recordpdf.savemerge");
            await AdbCommandAsync("shell pm uninstall --user 0 com.meetyou.intl");
            await AdbCommandAsync("shell pm uninstall --user 0 com.monotype.android.font.oppo.id3843365971z");
            await AdbCommandAsync("shell pm uninstall --user 0 itube.snaptube.videodervideoplayerall");
            await AdbCommandAsync("shell pm uninstall --user 0 com.mbsticker.manager");
            await AdbCommandAsync("shell pm uninstall --user 0 com.zhiliaoapp.musically");
            await AdbCommandAsync("shell pm uninstall --user 0 com.univision.prendetv");
            await AdbCommandAsync("shell pm uninstall --user 0 com.handmark.expressweather");

            progressBar1.Value = 10;
            await AdbCommandAsync("shell pm uninstall --user 0 cn.wps.moffice_eng");
            await AdbCommandAsync("shell pm uninstall --user 0 com.snaptube.premium");
            await AdbCommandAsync("shell pm uninstall --user 0 wallpaper.pixel.stacker.app");
            await AdbCommandAsync("shell pm uninstall --user 0 com.docscan.camscan.pdfscanner.pagescanner.documentscanner");
            await AdbCommandAsync("shell pm uninstall --user 0 com.trustedapp.pdfreaderpdfviewer");
            await AdbCommandAsync("shell pm uninstall --user 0 com.ezt.pdfreader.pdfviewer");
            await AdbCommandAsync("shell pm uninstall --user 0 com.lemon.lvoverseas");
            await AdbCommandAsync("shell pm uninstall --user 0 com.handmark.expressweather");
            await AdbCommandAsync("shell pm uninstall --user 0 com.recordpdf.savemerge");
            await AdbCommandAsync("shell pm uninstall --user 0 com.meetyou.intl");
            await AdbCommandAsync("shell pm uninstall --user 0 com.monotype.android.font.oppo.id3843365971z");
            await AdbCommandAsync("shell pm uninstall --user 0 itube.snaptube.videodervideoplayerall");
            await AdbCommandAsync("shell pm uninstall --user 0 com.mbsticker.manager");
            await AdbCommandAsync("shell pm uninstall --user 0 com.zhiliaoapp.musically");
            await AdbCommandAsync("shell pm uninstall --user 0 com.univision.prendetv");
            await AdbCommandAsync("shell pm uninstall --user 0 com.handmark.expressweather");
            await AdbCommandAsync("shell pm uninstall --user 0 cn.wps.moffice_eng");
            await AdbCommandAsync("shell pm uninstall --user 0 com.snaptube.premium");
            await AdbCommandAsync("shell pm uninstall --user 0 wallpaper.pixel.stacker.app");
            await AdbCommandAsync("shell pm uninstall --user 0 com.docscan.camscan.pdfscanner.pagescanner.documentscanner");
            await AdbCommandAsync("shell pm uninstall --user 0 com.trustedapp.pdfreaderpdfviewer");
            await AdbCommandAsync("shell pm uninstall --user 0 com.ezt.pdfreader.pdfviewer");
            await AdbCommandAsync("shell pm uninstall --user 0 com.lemon.lvoverseas");
            await AdbCommandAsync("shell pm uninstall --user 0 com.handmark.expressweather");
            await AdbCommandAsync("shell pm uninstall --user 0 com.recordpdf.savemerge");
            await AdbCommandAsync("shell pm uninstall --user 0 com.meetyou.intl");
            await AdbCommandAsync("shell pm uninstall --user 0 com.monotype.android.font.oppo.id3843365971z");
            await AdbCommandAsync("shell pm uninstall --user 0 itube.snaptube.videodervideoplayerall");
            await AdbCommandAsync("shell pm uninstall --user 0 com.mbsticker.manager");
            await AdbCommandAsync("shell pm uninstall --user 0 com.zhiliaoapp.musically");
            await AdbCommandAsync("shell pm uninstall --user 0 com.univision.prendetv");
            await AdbCommandAsync("shell pm uninstall --user 0 com.handmark.expressweather");
            await AdbCommandAsync("shell pm uninstall --user 0 cn.wps.moffice_eng");
            await AdbCommandAsync("shell pm uninstall --user 0 com.snaptube.premium");
            await AdbCommandAsync("shell pm uninstall --user 0 wallpaper.pixel.stacker.app");
            await AdbCommandAsync("shell pm uninstall --user 0 com.docscan.camscan.pdfscanner.pagescanner.documentscanner");

            progressBar1.Value = 100;
            addlog("\r\n VIRUS REMOVIDOS EXITOSAMENTE!", Color.Green, true, false);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Process.Start(new ProcessStartInfo
            {
                FileName = "https://www.tiktok.com/@ernestoherreraisp",
                UseShellExecute = true
            });
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Process.Start(new ProcessStartInfo
            {
                FileName = "https://www.facebook.com/Ernesto.Unlocker/",
                UseShellExecute = true
            });
        }

        public void addlog(string s, Color color, bool isBold, bool newline = false)
        {
            if (newline && richTextBox1.TextLength > 0)
                richTextBox1.AppendText("\r\n");

            richTextBox1.SelectionStart = richTextBox1.Text.Length;
            Color originalColor = richTextBox1.SelectionColor;
            richTextBox1.SelectionColor = color;

            if (isBold)
                richTextBox1.SelectionFont = new Font(richTextBox1.Font, FontStyle.Bold);

            richTextBox1.AppendText(s);
            richTextBox1.SelectionColor = originalColor;
            richTextBox1.SelectionFont = new Font(richTextBox1.Font, FontStyle.Regular);
            richTextBox1.ScrollToCaret();
        }

        public void Delay(double seconds)
        {
            DateTime start = DateTime.Now;
            DateTime end = start.AddSeconds(seconds);

            while (DateTime.Now < end)
            {
                Application.DoEvents();
            }
        }

        private void PlaySound(string path)
        {
            try
            {
                SoundPlayer player = new SoundPlayer(path);
                player.Play();
            }
            catch (Exception ex)
            {
                addlog($"\r\n Error al reproducir sonido: {ex.Message}", Color.Red, true, true);
            }
        }

        private async Task<bool> ConnectDeviceAsync()
        {
            try
            {
                string result = await AdbCommandAsync("devices");
                using (var reader = new System.IO.StringReader(result))
                {
                    string line;
                    while ((line = await reader.ReadLineAsync()) != null)
                    {
                        if (!line.StartsWith("List of devices attached") && !string.IsNullOrEmpty(line))
                        {
                            string status = line.Substring(line.IndexOf("\t")).Replace("\t", "");
                            return status == "device";
                        }
                    }
                }
                return false;
            }
            catch (Exception ex)
            {
                addlog($"\r\n Error al conectar: {ex.Message}", Color.Red, true, true);
                return false;
            }
        }

        private async Task<string> AdbCommandAsync(string cmd)
        {
            try
            {
                Process process = new Process();
                ProcessStartInfo startInfo = new ProcessStartInfo
                {
                    FileName = "Data\\adb.exe",
                    Arguments = cmd,
                    UseShellExecute = false,
                    CreateNoWindow = true,
                    RedirectStandardOutput = true
                };

                process.StartInfo = startInfo;
                process.Start();
                return await process.StandardOutput.ReadToEndAsync();
            }
            catch (Exception ex)
            {
                return $"Error: {ex.Message}";
            }
        }
    }
}