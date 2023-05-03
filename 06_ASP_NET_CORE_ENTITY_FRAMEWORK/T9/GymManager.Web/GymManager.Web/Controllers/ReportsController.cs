using GymManager.DataAccess.Reports;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Reporting.Map.WebForms.BingMaps;
using Microsoft.Reporting.NETCore;
using Wkhtmltopdf.NetCore;
using Warning = Microsoft.Reporting.NETCore.Warning;

namespace GymManager.Web.Controllers
{
    public class ReportsController : Controller
    {
        private readonly IGeneratePdf _generatePdf;
        private readonly IWebHostEnvironment _webHostEnvironment;

        public ReportsController(IWebHostEnvironment webHostEnvironment, IGeneratePdf generatePdf)
        {
            _generatePdf = generatePdf;
            _webHostEnvironment = webHostEnvironment;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult NewMembers()
        {

            string path = System.IO.Path.Combine(_webHostEnvironment.ContentRootPath, "Reports\\NewMembers.rdlc");

            //Abrir el archivo NewMembers.rdlc
            Stream reportDefinition = System.IO.File.OpenRead(path);

            LocalReport report = new LocalReport();
            report.EnableExternalImages = true;
            report.LoadReportDefinition(reportDefinition);

            MembersDataSet dataSet = new MembersDataSet();
            Random random = new Random();
            string[] membershipTypes = new string[] { "Basic", "Family", "Gold" };

            for (int i = 0; i < 28; i++)

            {

                MembersDataSet.MemberRow row = dataSet.Member.NewMemberRow();
                row.Name = $"Member Pérez {i}";
                int day = random.Next(1, 10) * -1;
                int membershipIndex = random.Next(0, 2);
                row.RegisteredOn = DateTime.Today.AddDays(day);

                row.MembershipType = membershipTypes[membershipIndex];

                //Agregar los miembros a la tabla
                dataSet.Member.Rows.Add(row);


            }


            byte[] streambytes = null;
            string mimetype = "";
            string encoding = "";
            string filenameExtension = "";
            string reportName = "NewMembers";
            string[] streamids = null;
            Warning[] warnings = null;

            //Enviar parametros de fecha (se tienen que enviar como string)
            report.SetParameters(new ReportParameter[] { new ReportParameter("DateFrom", DateTime.Today.AddDays(-10).ToString()),
            new ReportParameter("DateTo", DateTime.Today.ToString())
            });

            report.DataSources.Add(new ReportDataSource("Members", (System.Data.DataTable)dataSet.Member));

            streambytes = report.Render("PDF", null, out mimetype, out encoding, out filenameExtension, out streamids, out warnings);

            //Devolver el contenido del archivo PDF
            return File(streambytes, mimetype, $"{reportName}.{filenameExtension}");
        }

    }
}
