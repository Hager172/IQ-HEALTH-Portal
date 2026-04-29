using ACMS_ONLINE_INFRASTRUCTURE.Interfaces;
using ACMS_ONLINE_INFRASTRUCTURE.Utility.ResponseModel;
using AutoMapper;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

using System.Reflection.Metadata;

//using iTextSharp.text.pdf;
//using iTextSharp.text;
//using iTextSharp.text.pdf.qrcode;
using QRCoder;
using ACMS_ONLINE_INFRASTRUCTURE.Utility.Helpers;
using Microsoft.AspNetCore.Identity;
using static System.Runtime.InteropServices.JavaScript.JSType;
using ACMS_ONLINE_INFRASTRUCTURE.Data.Models;



namespace ACMS_ONLINE_APPLICATION.ApprovalService.Commands.PrintApproval
{
    //public class PrintApprovalHandler : IRequestHandler<PrintApprovalCommand, ServiceResponse<PrintApprovalResponse>>
    //{
    //    private readonly IUnitOfWork _unitOfWork;
    //    private readonly IHttpContextAccessor _contextAccessor;

    //    public PrintApprovalHandler(IUnitOfWork unitOfWork, IHttpContextAccessor contextAccessor)
    //    {
    //        _unitOfWork = unitOfWork;
    //        _contextAccessor = contextAccessor;
    //    }

     

//public async Task<ServiceResponse<PrintApprovalResponse>> Handle(PrintApprovalCommand request, CancellationToken cancellationToken)
//    {
//        var response = new ServiceResponse<PrintApprovalResponse>();

//        try
//        {
//            using (var memoryStream = new MemoryStream())
//            {
                    
//                    // Initialize Document and PdfWriter
//                    var document = new iTextSharp.text.Document(PageSize.A4, 25, 25, 30, 30);
//                    PdfWriter writer = PdfWriter.GetInstance(document, memoryStream);
//                    document.Open();

//                    // Load the images (logos)
//                    var logoPathLeft = "";
                    
                    
//                    var ClientId = _contextAccessor.HttpContext?.User.Claims.FirstOrDefault(x => x.Type == "ClientId")?.Value;
//                    var clientname = ClientId == "2" ? "ALMASHREQ" : "MedGold";
//                    var BranchId = _contextAccessor.HttpContext?.User.Claims.FirstOrDefault(x => x.Type == "BranchId")?.Value;
//                   var approval= _unitOfWork.ApprovalRepository.Find(x => x.ApprovalId == request.ApprovalId);

//                    var approvalservices = _unitOfWork.ApprovalServiceRepository.FindAll(x=>x.ApprovalId== request.ApprovalId);
//                    var connectionString = _unitOfWork.getCurrentConnectionString();
//                    List<AppService> listofser = new List<AppService>();
//                    List<string> diagnoesnamesforapproval = new List<string>();
//                    using (AdoHelper adoHelper1 = new(connectionString))
//                    {
//                    string diagnocesIds = $"  select od.name from online_diagnosis  od\r\n  where id in(select ad.diagnose_id from approval_diagnose ad where ad.approval_id ={request.ApprovalId})";
//                        adoHelper1.CommandTimeout = 1800;
//                        var result = adoHelper1.ExecuteQueryList(diagnocesIds, reader =>
//                        {
//                            return

//                                 reader.IsDBNull(reader.GetOrdinal("name")) ? null : reader.GetString(reader.GetOrdinal("name"));
                           
//                        });
//                        diagnoesnamesforapproval = result.Where(name=>name !=null).ToList();
                   
//                    }

//                    using (AdoHelper adoHelper = new(connectionString))
//                    {







//                        string approvalsers = $@"select * from  [dbo].[f_get_app_serv]  ({request.ApprovalId})";

//                        adoHelper.CommandTimeout = 1800;
//                        var result = adoHelper.ExecuteQueryList(approvalsers, reader =>
//                        {
//                            return new AppService
//                            {
//                                //IsActualValue = reader.GetBoolean(reader.GetOrdinal("is_actual_value")),
//                                //IsPool = reader.GetBoolean(reader.GetOrdinal("ispool")),
//                                ApprovalDate = reader.GetDateTime(reader.GetOrdinal("approval_date")),
//                                //MedItemName = reader.GetString(reader.GetOrdinal("med_item_name")),
//                                //SerId = reader.GetInt32(reader.GetOrdinal("ser_id")),
//                                SerName = reader.IsDBNull(reader.GetOrdinal("ser_name")) ? null : reader.GetString(reader.GetOrdinal("ser_name")),

//                                //Serial = reader.GetInt32(reader.GetOrdinal("serial")),
//                                MedItem = reader.IsDBNull(reader.GetOrdinal("med_item")) ? null : reader.GetInt32(reader.GetOrdinal("med_item")),
//                                Qty = reader.IsDBNull(reader.GetOrdinal("qty")) ? null : (float)reader.GetDouble(reader.GetOrdinal("qty")),
//                                Price = reader.IsDBNull(reader.GetOrdinal("price")) ? null : (float)reader.GetDouble(reader.GetOrdinal("price")),
//                                //Chronic = reader.GetBoolean(reader.GetOrdinal("chronic")),
//                                //ItemRepeat = reader.GetInt32(reader.GetOrdinal("item_repeat")),
//                                //Notes = reader.GetString(reader.GetOrdinal("notes")),
//                                LastUpdateBy = reader.IsDBNull(reader.GetOrdinal("last_update_by")) ? null : reader.GetString(reader.GetOrdinal("last_update_by")),
//                                //LastUpdateDate = reader.GetDateTime(reader.GetOrdinal("last_update_date")),
//                                //LastUpdateFrom = reader.GetString(reader.GetOrdinal("last_update_from")),
//                                  Coinsurance = (double)reader.GetDouble(reader.GetOrdinal("coinsurance")),
//                                //DoseUnits = (float)reader.GetDouble(reader.GetOrdinal("dose_units")),
//                                //DoseRepeat = reader.GetInt32(reader.GetOrdinal("dose_repeat")),
//                                //DoseDuration = reader.GetInt32(reader.GetOrdinal("dose_duration")),
//                                ApprovalId = reader.GetInt64(reader.GetOrdinal("approval_id")),
//                                //ItemDesc = reader.GetString(reader.GetOrdinal("item_desc")),
//                                //InsurerMedItem = reader.GetInt32(reader.GetOrdinal("insurer_meditem")),
//                                //OnlineStatus = reader.GetString(reader.GetOrdinal("online_status")),
//                                //Days = reader.GetInt32(reader.GetOrdinal("days")),
//                                //ApQty = (float)reader.GetDouble(reader.GetOrdinal("ap_qty")),
//                                //DoseDurType = reader.GetInt32(reader.GetOrdinal("dose_dur_type")),
//                                //MinUnits = reader.GetInt32(reader.GetOrdinal("min_units")),
//                                //OriginalPrice = (float)reader.GetDouble(reader.GetOrdinal("original_price")),
//                                //EditQty = reader.GetInt32(reader.GetOrdinal("editqty")),
//                                //ApType = reader.GetString(reader.GetOrdinal("ap_type")),
//                                //SubUnitNo = reader.GetInt32(reader.GetOrdinal("sub_unit_no")),
//                                //DoseUnitNo = (float)reader.GetDouble(reader.GetOrdinal("dose_unit_no")),
//                                //DoseForm = reader.GetString(reader.GetOrdinal("dose_form")),
//                                //Availability = reader.GetString(reader.GetOrdinal("availability"))
//                            };

//                        });
//                        listofser = result;
//                    }

//                    // Load the image (logo)
//                    var logoPath = "";

//                    var directoryPath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot\\Logo");
//                    if (ClientId == "2")
//                    {
//                        logoPath = $"{directoryPath}\\logo-mash__.png";
                       
//                    }
//                    else
//                    {
//                        logoPath = "${directoryPath}\\Logo\\medi.png";
//                    }
//                    iTextSharp.text.Image logo;
//                    using (var fs = new FileStream(logoPath, FileMode.Open, FileAccess.Read))
//                    {
//                        logo = iTextSharp.text.Image.GetInstance(fs);
//                        logo.ScaleToFit(100f, 100f); // Scale the logo size (adjust as needed)
//                        logo.Alignment = iTextSharp.text.Image.ALIGN_LEFT; // Align logo to the right

//                        // Title font
//                        var titleFont = FontFactory.GetFont("Arial", 25, Font.BOLD);
//                        var titleChunk = new Chunk("Invoice", titleFont);

//                        // Create a Paragraph for title and logo
//                        var titleWithLogo = new Paragraph();
//                        titleWithLogo.Alignment = Element.ALIGN_CENTER;

//                        // Add the logo and title to the Paragraph
//                        titleWithLogo.Add(new Chunk("  "));  // Space before logo
//                        titleWithLogo.Add(titleChunk);  // Add the title text

//                        // Add title with logo to the document
//                        document.Add(logo); // Add the logo first
//                        document.Add(titleWithLogo); // Then add the title

//                        // Create a line under the title
//                        float titleWidth = titleChunk.GetWidthPoint();
//                        PdfPTable lineTable3 = new PdfPTable(1);
//                        lineTable3.TotalWidth = titleWidth;
//                        lineTable3.LockedWidth = true;

//                        PdfPCell lineCell3 = new PdfPCell(new Phrase(string.Empty))
//                        {
//                            Border = Rectangle.BOTTOM_BORDER,
//                            BorderWidthBottom = 1f,
//                            FixedHeight = 1f,
//                            HorizontalAlignment = Element.ALIGN_CENTER,
//                            MinimumHeight = 1f
//                        };

//                        lineTable3.AddCell(lineCell3);
//                        document.Add(lineTable3);
//                        document.Add(new Paragraph(" "));

//                        // Header Table
//                        PdfPTable headerTable = new PdfPTable(2); // Use 2 columns
//                        headerTable.WidthPercentage = 100;
//                        BaseColor customColor = new BaseColor(0, 153, 153);

//                        // Add cells to the header table
//                        headerTable.AddCell(CreateCellWithTextBackground("From:", _contextAccessor.HttpContext?.User.Identity.Name, true, customColor));
//                        headerTable.AddCell(CreateCellWithTextBackground("Invoice:", request.ApprovalId.ToString(), true, customColor));
//                        headerTable.AddCell(CreateCellWithTextBackground("Branch:", _contextAccessor.HttpContext?.User.Identity.Name, false, customColor));
//                        headerTable.AddCell(CreateCellWithTextBackground("Client Name", clientname, false, customColor));
//                        //headerTable.AddCell(CreateCellWithTextBackground("To:", "", false, customColor));
//                        //headerTable.AddCell(CreateCellWithTextBackground("Client id", "", false, customColor));

//                        headerTable.AddCell(CreateCellWithTextBackground("Printed:", DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss"), false, customColor));
//                        headerTable.AddCell(CreateCellWithTextBackground("Service Date:", approval.ApprovalDate.ToString(), false, customColor));




//                        //headerTable.AddCell(CreateCellWithTextBackground("Diagnoses:", string.Join(", ", diagnoesnamesforapproval), false, customColor));
//                        headerTable.AddCell(CreateCellWithTextBackground("Max Value:", approval.MaxValue.ToString(), false, customColor));



//                        document.Add(headerTable);

//                        // Create a new table or cell for Diagnoses
//                        // Create a table for Diagnoses with 2 columns (matching headerTable)
//                        //PdfPTable diagnosesTable = new PdfPTable(2);
//                        //diagnosesTable.WidthPercentage = 100;

//                        //// Create a cell for Diagnoses that spans across both columns
//                        //PdfPCell diagnosesCell = CreateCellWithTextBackground("Diagnoses:", string.Join(", ", diagnoesnamesforapproval), false, customColor);
//                        //diagnosesCell.Colspan = 2; // Make the cell span across both columns
//                        //diagnosesCell.HorizontalAlignment = Element.ALIGN_LEFT; // Optional: Align text to the left
//                        //diagnosesCell.Border = Rectangle.NO_BORDER; // Optional: Remove borders if needed

//                        //// Add the cell to the table
//                        //diagnosesTable.AddCell(diagnosesCell);

//                        //// Add the diagnoses table to the document
//                        //document.Add(diagnosesTable);
//                        PdfPTable diagnosesTable = new PdfPTable(2);
//                        diagnosesTable.WidthPercentage = 100;
//                        diagnosesTable.SetWidths(new float[] { .8f, 4f }); 

//                        BaseColor labelBackgroundColor = new BaseColor(0, 153, 153);
//                        BaseColor textColor = BaseColor.WHITE;

//                        PdfPCell diagnoseLabelCell = new PdfPCell(new Phrase("Diagnose", FontFactory.GetFont("Arial", 10, Font.BOLD, textColor)))
//                        {
//                            BackgroundColor = labelBackgroundColor,
//                            HorizontalAlignment = Element.ALIGN_LEFT,
//                            VerticalAlignment = Element.ALIGN_MIDDLE,
//                            Padding = 5f,
//                            Border = Rectangle.NO_BORDER,
//                            FixedHeight = 20f, 
//                        };

//                        PdfPCell diagnosesValueCell = new PdfPCell(new Phrase(string.Join(", ", diagnoesnamesforapproval), FontFactory.GetFont("Arial", 10)))
//                        {
//                            HorizontalAlignment = Element.ALIGN_LEFT,
//                            VerticalAlignment = Element.ALIGN_MIDDLE,
//                            Padding = 5f,
//                            Border = Rectangle.NO_BORDER
//                        };

//                        diagnosesTable.AddCell(diagnoseLabelCell);
//                        diagnosesTable.AddCell(diagnosesValueCell);

//                        document.Add(diagnosesTable);





//                        document.Add(new Paragraph(" "));



//                        // Draw a line between tables
//                        PdfPTable lineTable = new PdfPTable(1);
//                        lineTable.WidthPercentage = 100;
//                        PdfPCell lineCell = new PdfPCell(new Phrase(string.Empty))
//                        {
//                            Border = Rectangle.BOTTOM_BORDER,
//                            BorderWidthBottom = 1f,
//                            FixedHeight = 1f,
//                            HorizontalAlignment = Element.ALIGN_CENTER,
//                        };
//                        lineTable.AddCell(lineCell);
//                        document.Add(lineTable);
//                        document.Add(new Paragraph(" "));

//                        // Items Table
//                        PdfPTable itemsTable = new PdfPTable(5);
//                        itemsTable.WidthPercentage = 100;
//                        BaseColor headerBackgroundColor = new BaseColor(0, 153, 153);
//                        BaseColor headerTextColor = BaseColor.WHITE;
//                        itemsTable.AddCell(CreateHeaderCell("Name", headerBackgroundColor, headerTextColor));
//                        itemsTable.AddCell(CreateHeaderCell("Qty/Approv", headerBackgroundColor, headerTextColor));
//                        itemsTable.AddCell(CreateHeaderCell("Price", headerBackgroundColor, headerTextColor));
                  
//                        itemsTable.AddCell(CreateHeaderCell("Net ", headerBackgroundColor, headerTextColor));
                        
//                        itemsTable.AddCell(CreateHeaderCell("Total", headerBackgroundColor, headerTextColor));

//                        var sumnet = 0.0;
//                        var sumnetOne = 0.0;

//                        decimal totalCoinvalue =0;
//                        // Sample Data
//                        foreach (var service in listofser)
//                        {
//                            sumnetOne = 0;
//                            // Add a row for each service in the list
//                            //itemsTable.AddCell(CreateCell(service.SerName, false));
//                            //itemsTable.AddCell(CreateCell(service.Qty.ToString(), false));
//                            string serName = string.IsNullOrWhiteSpace(service.SerName) ? "N/A" : service.SerName;
//                            string qty = service.Qty.HasValue ? service.Qty.Value.ToString() : "0";

//                            itemsTable.AddCell(CreateCell(serName, false));
//                            itemsTable.AddCell(CreateCell(qty, false));
//                            itemsTable.AddCell(CreateCell(((double)(service.Price)).ToString("F2"), false));

//                            sumnetOne = ((double)(service.Qty ?? 0.0) * (double)(service.Price ?? 0.0)) * (double)(1 - (service.Coinsurance / 100));
//                            sumnet += sumnetOne;
//                            itemsTable.AddCell(CreateCell(
//                               sumnetOne.ToString("F2"), false));


//                            itemsTable.AddCell(CreateCell(((double)(service.Qty ?? 0.0) * (double)(service.Price ?? 0.0)).ToString("F2"), false));


//                            totalCoinvalue += (((decimal)(service.Qty ?? 0.0) * (decimal)(service.Price ?? 0.0)) * (decimal)(service.Coinsurance / 100));
//                        }
//                        //itemsTable.AddCell(CreateCell("CONCOR COR 2.5MG 30/SCORED F.C.", false));
//                        //itemsTable.AddCell(CreateCell("3.0", false));
//                        //itemsTable.AddCell(CreateCell("20.0", false));
//                        //itemsTable.AddCell(CreateCell("STRIP", false));
//                        //itemsTable.AddCell(CreateCell("60.0", false));

//                        //itemsTable.AddCell(CreateCell("VASTAREL MR 35MG 30TAB", false));
//                        //itemsTable.AddCell(CreateCell("5.0", false));
//                        //itemsTable.AddCell(CreateCell("8.5", false));
//                        //itemsTable.AddCell(CreateCell("STRIP", false));
//                        //itemsTable.AddCell(CreateCell("35.1", false));

//                        document.Add(itemsTable);

//                        document.Add(new Paragraph(" "));

//                        // Line Table 2 (second line)
//                        PdfPTable lineTable2 = new PdfPTable(1);
//                        lineTable2.WidthPercentage = 100;
//                        PdfPCell lineCell2 = new PdfPCell(new Phrase(string.Empty))
//                        {
//                            Border = Rectangle.BOTTOM_BORDER,
//                            BorderWidthBottom = 1f,
//                            FixedHeight = 1f,
//                            HorizontalAlignment = Element.ALIGN_CENTER,
//                        };
//                        lineTable2.AddCell(lineCell2);
//                        document.Add(lineTable2);

//                        document.Add(new Paragraph(" "));



//                        // Total Row
//                        PdfPTable totalTable = new PdfPTable(3);
//                        totalTable.WidthPercentage = 100;
//                        BaseColor footerBackgroundColor = new BaseColor(0, 153, 153);
//                        BaseColor footerTextColor = BaseColor.WHITE;
//                        double totalPriceSum = listofser.Sum(service => (service.Qty ?? 0.0) * (service.Price ?? 0.0));

//                        // Add "Total" cell
//                        totalTable.AddCell(CreateTotalCell("Total", footerBackgroundColor, footerTextColor, totalPriceSum.ToString("F2")));

//                        // Get Coinsurance (Co) and totalCoinvalue
//                        double Co = listofser?.Any() == true ? listofser.MaxBy(x => x.Coinsurance).Coinsurance : 0.0;
                       

//                        totalTable.AddCell(CreateTotalCell("CO", footerBackgroundColor, footerTextColor, $"{Co}%   -, {totalCoinvalue}"));

                       
//                        totalTable.AddCell(CreateTotalCell("Net", footerBackgroundColor, footerTextColor, sumnet.ToString("F2")));

//                        // Add the table to the document
//                        document.Add(totalTable);

//                        //PdfPTable totalTable = new PdfPTable(3);
//                        //totalTable.WidthPercentage = 100;
//                        //BaseColor footerBackgroundColor = new BaseColor(0, 153, 153);
//                        //BaseColor footerTextColor = BaseColor.WHITE;
//                        //double totalPriceSum = listofser.Sum(service => (service.Qty ?? 0.0) * (service.Price ?? 0.0));
//                        //totalTable.AddCell(CreateTotalCell("Total", footerBackgroundColor, footerTextColor, totalPriceSum.ToString("F2")));
//                        //double Co = listofser?.Any() == true? listofser.MaxBy(x => x.Coinsurance).Coinsurance: 0.0; 


//                        // totalTable.AddCell(CreateTotalCell("CO", footerBackgroundColor  , footerTextColor, $"{ Co } % , {totalCoinvalue}"));
//                        //totalTable.AddCell(CreateTotalCell("Net", footerBackgroundColor, footerTextColor, sumnet.ToString("F2")));
//                        //document.Add(totalTable);

//                        // Generate QR Code
//                        using (var qrGenerator = new QRCodeGenerator())
//                        {
//                            // Create QR code data from the ApprovalId
//                            var qrCodeData = qrGenerator.CreateQrCode(request.ApprovalId.ToString(), QRCodeGenerator.ECCLevel.Q);

//                            // Create the QR code using the QR code data
//                            var qrCode = new QRCoder.QRCode(qrCodeData);

//                            // Generate the graphic for the QR code
//                            using (var qrCodeImage = qrCode.GetGraphic(20)) // This should work if QRCoder is correctly referenced
//                            {
//                                // Convert the QR code image to a format that iTextSharp can use
//                                using (var ms = new MemoryStream())
//                                {
//                                    qrCodeImage.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
//                                    ms.Position = 0; // Reset the stream position

//                                    iTextSharp.text.Image qrCodeITextImage = iTextSharp.text.Image.GetInstance(ms.ToArray());
//                                    qrCodeITextImage.ScaleToFit(100f, 100f); // Scale the QR code size (adjust as needed)
//                                    qrCodeITextImage.Alignment = iTextSharp.text.Image.ALIGN_LEFT; // Align QR code to the left

//                                    // Wrap the image in a Paragraph to control alignment
//                                    var qrCodeParagraph = new Paragraph();
//                                    qrCodeParagraph.Add(qrCodeITextImage);
//                                    qrCodeParagraph.Alignment = Element.ALIGN_LEFT; // Set paragraph alignment to left

//                                    // Add QR code to the document
//                                    document.Add(qrCodeParagraph);
//                                }
//                            }
//                        }
//                        document.Add(new Paragraph(" "));

//                        // Draw a line between tables
//                        PdfPTable lineTable4 = new PdfPTable(1);
//                        lineTable4.WidthPercentage = 100;
//                        PdfPCell lineCell4 = new PdfPCell(new Phrase(string.Empty))
//                        {
//                            Border = Rectangle.BOTTOM_BORDER,
//                            BorderWidthBottom = 1f,
//                            FixedHeight = 1f,
//                            HorizontalAlignment = Element.ALIGN_CENTER,
//                        };
//                        lineTable4.AddCell(lineCell4);
//                        document.Add(lineTable4);
//                        document.Add(new Paragraph(" "));

//                        //PdfPTable footerTable = new PdfPTable(4);
//                        //footerTable.WidthPercentage = 100; 
//                        //footerTable.DefaultCell.Border = PdfPCell.NO_BORDER; 

//                        //var footerFont = FontFactory.GetFont("Arial", 8);

//                        //footerTable.AddCell(new PdfPCell(new Phrase("Last Updated by :", footerFont)) { Border = PdfPCell.NO_BORDER });
//                        //footerTable.AddCell(new PdfPCell(new Phrase("Online User", footerFont)) { Border = PdfPCell.NO_BORDER });
//                        //footerTable.AddCell(new PdfPCell(new Phrase("Terms & Condition", footerFont)) { Border = PdfPCell.NO_BORDER, HorizontalAlignment = Element.ALIGN_LEFT });
//                        //footerTable.AddCell(new PdfPCell(new Phrase("", footerFont)) { Border = PdfPCell.NO_BORDER }); 

//                        //footerTable.AddCell(new PdfPCell(new Phrase("Printed by :", footerFont)) { Border = PdfPCell.NO_BORDER });
//                        //footerTable.AddCell(new PdfPCell(new Phrase("woods pharma LLC", footerFont)) { Border = PdfPCell.NO_BORDER });
//                        //footerTable.AddCell(new PdfPCell(new Phrase("All prices and costs are supposed to be in EGP’s only. Kindly refer to our official website for more information about Terms & Condition.", footerFont)) { Border = PdfPCell.NO_BORDER, Colspan = 2 });


//                        //document.Add(footerTable);
//                        PdfPTable footerTable = new PdfPTable(3);
//                        footerTable.WidthPercentage = 100;
//                        footerTable.SetWidths(new float[] { 1f, 1f, 1.5f }); 

//                        var footerFont = FontFactory.GetFont("Arial", 8);
//                        var footerFontBold = FontFactory.GetFont("Arial", 8, Font.NORMAL);

                        
//                        footerTable.AddCell(new PdfPCell(new Phrase("Last Updated by :", footerFont))
//                        {
//                            Border = PdfPCell.NO_BORDER,
//                            HorizontalAlignment = Element.ALIGN_LEFT
//                        });

//                        footerTable.AddCell(new PdfPCell(new Phrase("Online User", footerFont))
//                        {
//                            Border = PdfPCell.NO_BORDER,
//                            HorizontalAlignment = Element.ALIGN_LEFT
//                        });

//                        footerTable.AddCell(new PdfPCell(new Phrase("Terms & Condition", footerFontBold))
//                        {
//                            Border = PdfPCell.NO_BORDER,
//                            HorizontalAlignment = Element.ALIGN_CENTER,
//                            PaddingBottom = 5 
//                        });

//                        footerTable.AddCell(new PdfPCell(new Phrase("Printed by :", footerFont))
//                        {
//                            Border = PdfPCell.NO_BORDER,
//                            HorizontalAlignment = Element.ALIGN_LEFT
//                        });

//                        footerTable.AddCell(new PdfPCell(new Phrase("woods pharma LLC", footerFont))
//                        {
//                            Border = PdfPCell.NO_BORDER,
//                            HorizontalAlignment = Element.ALIGN_LEFT
//                        });

//                        footerTable.AddCell(new PdfPCell(new Phrase("All prices and costs are supposed to be in EGP’s only. Kindly refer to our official website for more information about Terms & Condition.", footerFont))
//                        {
//                            Border = PdfPCell.NO_BORDER,
//                            HorizontalAlignment = Element.ALIGN_LEFT
//                        });

//                        document.Add(footerTable);



//                        document.Close();

//                    response.Data = new PrintApprovalResponse
//                    {
//                        FileName = $"Invoice_{request.ApprovalId}.pdf",
//                        FileContent = memoryStream.ToArray()
//                    };
//                    response.Success = true;
//                    response.MessageEn = "PDF generated successfully.";
//                }
//            }
//        }
//        catch (Exception ex)
//        {
//            response.Success = false;
//            response.MessageEn = $"Failed to generate PDF: {ex.Message}";
//        }

//        return response;
//    }


//        private PdfPCell CreateCellWithTextBackground(string label, string value, bool isBold, BaseColor backgroundColor = null)
//        {
//            // Create the label part (e.g., "From:")
//            var labelFont = isBold ? FontFactory.GetFont("Arial", 12, Font.BOLD, BaseColor.WHITE)
//                                   : FontFactory.GetFont("Arial", 12, BaseColor.WHITE); // Set white color for the label text

//            var labelParagraph = new Paragraph(label, labelFont)
//            {
//                Alignment = Element.ALIGN_LEFT,
//                Leading = 0f  // Prevent extra space before the text
//            };

//            // Create the value part (e.g., the actual value next to "From:")
//            var valueFont = FontFactory.GetFont("Arial", 12);
//            var valueParagraph = new Paragraph(value, valueFont)
//            {
//                Alignment = Element.ALIGN_LEFT,
//                Leading = 0f  // Prevent extra space before the text
//            };

//            // Create a table with two columns to align the label and value side by side
//            PdfPTable innerTable = new PdfPTable(2);
//            innerTable.WidthPercentage = 100;
//            innerTable.SetWidths(new float[] { 1, 2 }); // Control the width ratio between the label and value columns

//            // Add label and value to their respective columns
//            innerTable.AddCell(new PdfPCell(labelParagraph)
//            {
//                Border = PdfPCell.NO_BORDER,
//                BackgroundColor = backgroundColor,
//                HorizontalAlignment = Element.ALIGN_LEFT,
//                PaddingLeft = 5f
//            });
//            innerTable.AddCell(new PdfPCell(valueParagraph)
//            {
//                Border = PdfPCell.NO_BORDER,
//                HorizontalAlignment = Element.ALIGN_LEFT,
//                PaddingLeft = 10f
//            });

//            // Create the outer cell and add the inner table
//            var outerCell = new PdfPCell(innerTable)
//            {
//                Border = PdfPCell.NO_BORDER, // No border for outer cell
//                PaddingTop = 3f, // Optional: Adjust top padding
//                PaddingBottom = 3f // Optional: Adjust bottom padding
//            };

//            return outerCell;
//        }

//        // Create header cells with custom background color, white text, and no border
//        private static PdfPCell CreateHeaderCell(string content, BaseColor backgroundColor, BaseColor textColor)
//        {
//            Font font = FontFactory.GetFont("Arial", 12, Font.BOLD, textColor); // White text for header
//            var cell = new PdfPCell(new Phrase(content, font))
//            {
//                BackgroundColor = backgroundColor, // Set custom background color
//                HorizontalAlignment = Element.ALIGN_CENTER, // Center the text horizontally
//                VerticalAlignment = Element.ALIGN_MIDDLE, // Center the text vertically
//                Padding = 5f, // Optional: Add padding for spacing
//                Border = PdfPCell.NO_BORDER // Remove border for header cells
//            };
//            return cell;
//        }

      
//        private static PdfPCell CreateCell(string content, bool isBold)
//        {
            
//            string fontPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Fonts), "arial.ttf");
//            BaseFont bf = BaseFont.CreateFont(fontPath, BaseFont.IDENTITY_H, BaseFont.EMBEDDED);
//            Font font = isBold ? new Font(bf, 10, Font.BOLD) : new Font(bf, 10, Font.NORMAL);

           
//            Phrase phrase = new Phrase(content, font);

            
//            var cell = new PdfPCell(phrase)
//            {
//                HorizontalAlignment = Element.ALIGN_CENTER, 
//                VerticalAlignment = Element.ALIGN_MIDDLE, 
//                Padding = 5f, 
//                Border = PdfPCell.NO_BORDER, 
//                RunDirection = PdfWriter.RUN_DIRECTION_RTL 
//            };

//            return cell;
//        }


      
//        private PdfPCell CreateTotalCell(string label, BaseColor backgroundColor, BaseColor textColor, string value)
//        {
//            // Create a Phrase object to hold the chunks
//            Phrase phrase = new Phrase();

//            // Add label text with the standard font
//            Chunk labelChunk = new Chunk($"{label}: ", FontFactory.GetFont("Arial", 12, Font.BOLD, textColor));
//            phrase.Add(labelChunk);

//            // Add value text with custom formatting (e.g., spacing and color)
//            string[] parts = value.Split(',');
//            Chunk valueChunk = new Chunk(parts[0], FontFactory.GetFont("Arial", 12, Font.NORMAL, textColor)); // "Co" part
//            phrase.Add(valueChunk);

//            // Add space between the two values
//            phrase.Add(new Chunk("   ")); // Adding space between the two chunks

//            // Add the second part (totalCoinvalue) with custom color
//            Chunk totalCoinValueChunk = new Chunk(parts.Length > 1 ? parts[1] : "", FontFactory.GetFont("Arial", 12, Font.BOLD, textColor)); // Red color for totalCoinvalue
//            phrase.Add(totalCoinValueChunk);

//            // Create the cell with the formatted Phrase
//            PdfPCell cell = new PdfPCell(phrase)
//            {
//                BackgroundColor = backgroundColor,
//                HorizontalAlignment = Element.ALIGN_CENTER,  // Center the text in the cell
//                VerticalAlignment = Element.ALIGN_MIDDLE,  // Center the text vertically
//                FixedHeight = 25f, // Height of the cell
//                Border = Rectangle.NO_BORDER
//            };

//            return cell;
//        }


    }
    public class AppService
    {
        public bool IsActualValue { get; set; }
        public bool IsPool { get; set; }
        public DateTime ApprovalDate { get; set; }
        public string MedItemName { get; set; }
        public int SerId { get; set; }
        public string? SerName { get; set; }
        public int Serial { get; set; }
        public int? MedItem { get; set; }
        public float? Qty { get; set; }
        public float? Price { get; set; }
        public bool Chronic { get; set; }
        public int ItemRepeat { get; set; }
        public string Notes { get; set; }
        public string? LastUpdateBy { get; set; }
        public DateTime LastUpdateDate { get; set; }
        public string LastUpdateFrom { get; set; }
        public double Coinsurance { get; set; }
        public float DoseUnits { get; set; }
        public int DoseRepeat { get; set; }
        public int DoseDuration { get; set; }
        public long ApprovalId { get; set; }
        public string ItemDesc { get; set; }
        public int InsurerMedItem { get; set; }
        public string OnlineStatus { get; set; }
        public int Days { get; set; }
        public float ApQty { get; set; }
        public int DoseDurType { get; set; }
        public int MinUnits { get; set; }
        public float OriginalPrice { get; set; }
        public int EditQty { get; set; }
        public string ApType { get; set; }
        public int SubUnitNo { get; set; }
        public float DoseUnitNo { get; set; }
        public string DoseForm { get; set; }
        public string Availability { get; set; }
    }

//}



//public async Task<ServiceResponse<PrintApprovalResponse>> Handle(PrintApprovalCommand request, CancellationToken cancellationToken)
//{
//    var response = new ServiceResponse<PrintApprovalResponse>();

//    try
//    {
//        using (var memoryStream = new MemoryStream())
//        {
//            // Initialize Document and PdfWriter
//            var document = new iTextSharp.text.Document(PageSize.A4, 25, 25, 30, 30);
//            PdfWriter writer = PdfWriter.GetInstance(document, memoryStream);
//            document.Open();

//            // Load the image (logo)
//            var logoPath = "";


//            var ClientId = _contextAccessor.HttpContext?.User.Claims.FirstOrDefault(x => x.Type == "ClientId")?.Value;
//            if (ClientId=="2")
//            {
//                logoPath = "D:\\Project\\IQ-Health-portal\\ACMS_ONLINE_API\\Logo\\logo-mash__.png"; 
//            }
//            else
//            {
//                logoPath = "D:\\Project\\IQ-Health-portal\\ACMS_ONLINE_API\\Logo\\medi.png"; 
//            }
//            iTextSharp.text.Image logo;
//            using (var fs = new FileStream(logoPath, FileMode.Open, FileAccess.Read))
//            {
//                logo = iTextSharp.text.Image.GetInstance(fs);
//                logo.ScaleToFit(100f, 100f); // Scale the logo size (adjust as needed)
//                logo.Alignment = iTextSharp.text.Image.ALIGN_RIGHT; // Align logo to the right

//                // Title font
//                var titleFont = FontFactory.GetFont("Arial", 25, Font.BOLD);
//                var titleChunk = new Chunk("Invoice", titleFont);

//                // Create a Paragraph for title and logo
//                var titleWithLogo = new Paragraph();
//                titleWithLogo.Alignment = Element.ALIGN_CENTER;

//                // Add the logo and title to the Paragraph
//                titleWithLogo.Add(new Chunk("  "));  // Space before logo
//                titleWithLogo.Add(titleChunk);  // Add the title text

//                // Add title with logo to the document
//                document.Add(logo); // Add the logo first
//                document.Add(titleWithLogo); // Then add the title

//                // Create a line under the title
//                float titleWidth = titleChunk.GetWidthPoint();
//                PdfPTable lineTable3 = new PdfPTable(1);
//                lineTable3.TotalWidth = titleWidth;
//                lineTable3.LockedWidth = true;

//                PdfPCell lineCell3 = new PdfPCell(new Phrase(string.Empty))
//                {
//                    Border = Rectangle.BOTTOM_BORDER,
//                    BorderWidthBottom = 1f,
//                    FixedHeight = 1f,
//                    HorizontalAlignment = Element.ALIGN_CENTER,
//                    MinimumHeight = 1f
//                };

//                lineTable3.AddCell(lineCell3);
//                document.Add(lineTable3);
//                document.Add(new Paragraph(" "));

//                // Header Table
//                PdfPTable headerTable = new PdfPTable(2);
//                headerTable.WidthPercentage = 100;
//                BaseColor customColor = new BaseColor(0, 153, 153);
//                headerTable.AddCell(CreateCellWithTextBackground("From:", request.ApprovalId.ToString(), true, customColor));
//                headerTable.AddCell(CreateCellWithTextBackground("Invoice:", request.ApprovalId.ToString(), true, customColor));
//                headerTable.AddCell(CreateCellWithTextBackground("Branch:", request.ApprovalId.ToString(), false, customColor));
//                headerTable.AddCell(CreateCellWithTextBackground(request.ApprovalId.ToString(), request.ApprovalId.ToString(), false, customColor));
//                headerTable.AddCell(CreateCellWithTextBackground("To:", "Client Name", false, customColor));
//                headerTable.AddCell(CreateCellWithTextBackground("Client Name", "MedGold For Healthcare", false, customColor));
//                headerTable.AddCell(CreateCellWithTextBackground("Printed:", DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss"), false, customColor));
//                headerTable.AddCell(CreateCellWithTextBackground("Service Date:", "15/01/2025 00:00", false, customColor));
//                document.Add(headerTable);
//                document.Add(new Paragraph(" "));

//                // Draw a line between tables
//                PdfPTable lineTable = new PdfPTable(1);
//                lineTable.WidthPercentage = 100;
//                PdfPCell lineCell = new PdfPCell(new Phrase(string.Empty))
//                {
//                    Border = Rectangle.BOTTOM_BORDER,
//                    BorderWidthBottom = 1f,
//                    FixedHeight = 1f,
//                    HorizontalAlignment = Element.ALIGN_CENTER,
//                };
//                lineTable.AddCell(lineCell);
//                document.Add(lineTable);
//                document.Add(new Paragraph(" "));

//                // Items Table
//                PdfPTable itemsTable = new PdfPTable(5);
//                itemsTable.WidthPercentage = 100;
//                BaseColor headerBackgroundColor = new BaseColor(0, 153, 153);
//                BaseColor headerTextColor = BaseColor.WHITE;
//                itemsTable.AddCell(CreateHeaderCell("Name", headerBackgroundColor, headerTextColor));
//                itemsTable.AddCell(CreateHeaderCell("Qty/Approv", headerBackgroundColor, headerTextColor));
//                itemsTable.AddCell(CreateHeaderCell("Price", headerBackgroundColor, headerTextColor));
//                itemsTable.AddCell(CreateHeaderCell("Unit", headerBackgroundColor, headerTextColor));
//                itemsTable.AddCell(CreateHeaderCell("Total", headerBackgroundColor, headerTextColor));

//                // Sample Data
//                itemsTable.AddCell(CreateCell("CONCOR COR 2.5MG 30/SCORED F.C.", false));
//                itemsTable.AddCell(CreateCell("3.0", false));
//                itemsTable.AddCell(CreateCell("20.0", false));
//                itemsTable.AddCell(CreateCell("STRIP", false));
//                itemsTable.AddCell(CreateCell("60.0", false));

//                itemsTable.AddCell(CreateCell("VASTAREL MR 35MG 30TAB", false));
//                itemsTable.AddCell(CreateCell("5.0", false));
//                itemsTable.AddCell(CreateCell("8.5", false));
//                itemsTable.AddCell(CreateCell("STRIP", false));
//                itemsTable.AddCell(CreateCell("35.1", false));

//                document.Add(itemsTable);

//                document.Add(new Paragraph(" "));

//                // Line Table 2 (second line)
//                PdfPTable lineTable2 = new PdfPTable(1);
//                lineTable2.WidthPercentage = 100;
//                PdfPCell lineCell2 = new PdfPCell(new Phrase(string.Empty))
//                {
//                    Border = Rectangle.BOTTOM_BORDER,
//                    BorderWidthBottom = 1f,
//                    FixedHeight = 1f,
//                    HorizontalAlignment = Element.ALIGN_CENTER,
//                };
//                lineTable2.AddCell(lineCell2);
//                document.Add(lineTable2);

//                document.Add(new Paragraph(" "));

//                // Total Row
//                PdfPTable Total = new PdfPTable(3);
//                Total.WidthPercentage = 100;
//                BaseColor footerBackgroundColor = new BaseColor(0, 153, 153);
//                BaseColor footerTextColor = BaseColor.WHITE;
//                Total.AddCell(CreateTotalCell("Total", footerBackgroundColor, footerTextColor, "100.0"));
//                Total.AddCell(CreateTotalCell("CO", footerBackgroundColor, footerTextColor, "50.0"));
//                Total.AddCell(CreateTotalCell("Net", footerBackgroundColor, footerTextColor, "150.0"));
//                document.Add(Total);

//                // Footer section with custom text
//                var footerFont = FontFactory.GetFont("Arial", 10);
//                var firstPart = new Chunk("Last Updated by : Online User", footerFont);
//                var secondPart = new Chunk("Printed by : woods pharma LLC", footerFont);
//                var footerPhrase = new Phrase();
//                footerPhrase.Add(firstPart);
//                footerPhrase.Add(new Chunk(new string(' ', 50))); // Add space between the two parts
//                footerPhrase.Add(secondPart);

//                document.Add(new Paragraph(footerPhrase)
//                {
//                    Alignment = Element.ALIGN_CENTER,
//                    SpacingBefore = 10
//                });

//                // Terms & Condition
//                var termsHeader = new Chunk("Terms & Condition", footerFont);
//                var termsHeaderPhrase = new Phrase(termsHeader);
//                document.Add(new Paragraph(termsHeaderPhrase)
//                {
//                    Alignment = Element.ALIGN_CENTER,
//                    SpacingBefore = 5
//                });

//                var termsContent = new Chunk("All prices and costs are supposed to be in EGPs only. Kindly refer to our official website for more information about Terms & Condition.", footerFont);
//                var termsContentPhrase = new Phrase(termsContent);
//                document.Add(new Paragraph(termsContentPhrase)
//                {
//                    Alignment = Element.ALIGN_CENTER,
//                    SpacingBefore = 5
//                });

//                // Close document
//                document.Close();

//                // Return the PDF as a byte array
//                response.Data = new PrintApprovalResponse
//                {
//                    FileName = $"Invoice_{request.ApprovalId}.pdf",
//                    FileContent = memoryStream.ToArray()
//                };
//                response.Success = true;
//                response.MessageEn = "PDF generated successfully.";
//            }
//        }
//    }
//    catch (Exception ex)
//    {
//        response.Success = false;
//        response.MessageEn = $"Failed to generate PDF: {ex.Message}";
//    }

//    return response;
//}


//public async Task<ServiceResponse<PrintApprovalResponse>> Handle(PrintApprovalCommand request, CancellationToken cancellationToken)
//{
//    var response = new ServiceResponse<PrintApprovalResponse>();

//    try
//    {
//        using (var memoryStream = new MemoryStream())
//        {
//            // Initialize Document and PdfWriter
//            var document = new iTextSharp.text.Document(PageSize.A4, 25, 25, 30, 30);
//            PdfWriter writer = PdfWriter.GetInstance(document, memoryStream);
//            document.Open();


//            // Title
//            var titleFont = FontFactory.GetFont("Arial", 25, Font.BOLD);
//            var titleChunk = new Chunk("Invoice", titleFont);
//            var titlePhrase = new Phrase(titleChunk);  

//            var title = new Paragraph(titlePhrase)
//            {
//                Alignment = Element.ALIGN_CENTER
//            };
//            document.Add(title);


//            float titleWidth = titleChunk.GetWidthPoint(); 


//            PdfPTable lineTable3 = new PdfPTable(1);
//            lineTable3.TotalWidth = titleWidth;  
//            lineTable3.LockedWidth = true; 

//            PdfPCell lineCell3 = new PdfPCell(new Phrase(string.Empty))
//            {
//                Border = Rectangle.BOTTOM_BORDER,  
//                BorderWidthBottom = 1f, 
//                FixedHeight = 1f,  
//                HorizontalAlignment = Element.ALIGN_CENTER, 
//                MinimumHeight = 1f 
//            };


//            lineTable3.AddCell(lineCell3);


//            document.Add(lineTable3);
//            document.Add(new Paragraph(" "));

//            // Header Table
//            PdfPTable headerTable = new PdfPTable(2);
//            headerTable.WidthPercentage = 100;
//            BaseColor customColor = new BaseColor(0, 153, 153);
//            // Add cells with background color and value next to label
//            headerTable.AddCell(CreateCellWithTextBackground("From:", request.ApprovalId.ToString(), true, customColor));  // "From:" with background
//            headerTable.AddCell(CreateCellWithTextBackground("Invoice:", request.ApprovalId.ToString(), true, customColor)); // "Invoice:" with background
//            headerTable.AddCell(CreateCellWithTextBackground("Branch:", request.ApprovalId.ToString(), false, customColor));
//            headerTable.AddCell(CreateCellWithTextBackground(request.ApprovalId.ToString(), request.ApprovalId.ToString(), false, customColor));
//            headerTable.AddCell(CreateCellWithTextBackground("To:", "Client Name", false, customColor));
//            headerTable.AddCell(CreateCellWithTextBackground("Client Name","MedGold For Healthcare",  false, customColor));
//            headerTable.AddCell(CreateCellWithTextBackground("Printed:", DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss"), false, customColor));
//            headerTable.AddCell(CreateCellWithTextBackground("Service Date:", "15/01/2025 00:00", false, customColor));
//            document.Add(headerTable);

//            // Diagnosis
//            //var diagnosisFont = FontFactory.GetFont("Arial", 12);
//            //var diagnosis = new Paragraph("Diagnosis: Essential (primary) hypertension", diagnosisFont)
//            //{
//            //    SpacingBefore = 10,
//            //    SpacingAfter = 10
//            //};
//            //document.Add(diagnosis);
//            // Add spacing between tables
//            document.Add(new Paragraph(" ")); // Blank line for distance (or use document.Add(new Paragraph(" ", titleFont)); for styled space)

//            // Draw a line between tables
//            PdfPTable lineTable = new PdfPTable(1);
//            lineTable.WidthPercentage = 100;
//            PdfPCell lineCell = new PdfPCell(new Phrase(string.Empty))
//            {
//                Border = Rectangle.BOTTOM_BORDER,  // Set bottom border to create a line
//                BorderWidthBottom = 1f,  // Set the thickness of the line
//                FixedHeight = 1f,  // Set the height of the line (thickness)
//                HorizontalAlignment = Element.ALIGN_CENTER,  // Center align the line
//            };
//            lineTable.AddCell(lineCell);
//            document.Add(lineTable);

//            // Add spacing after the line if needed
//            document.Add(new Paragraph(" "));
//            //Items Table
//            PdfPTable itemsTable = new PdfPTable(5);
//            itemsTable.WidthPercentage = 100;

//            // Define the header cell color and text color
//            BaseColor headerBackgroundColor = new BaseColor(0, 153, 153); // Custom color
//            BaseColor headerTextColor = BaseColor.WHITE; // White text color

//            // Add header cells with the custom background color and white text
//            itemsTable.AddCell(CreateHeaderCell("Name", headerBackgroundColor, headerTextColor));
//            itemsTable.AddCell(CreateHeaderCell("Qty/Approv", headerBackgroundColor, headerTextColor));
//            itemsTable.AddCell(CreateHeaderCell("Price", headerBackgroundColor, headerTextColor));
//            itemsTable.AddCell(CreateHeaderCell("Unit", headerBackgroundColor, headerTextColor));
//            itemsTable.AddCell(CreateHeaderCell("Total", headerBackgroundColor, headerTextColor));

//            // Sample Data
//            itemsTable.AddCell(CreateCell("CONCOR COR 2.5MG 30/SCORED F.C.", false));
//            itemsTable.AddCell(CreateCell("3.0", false));
//            itemsTable.AddCell(CreateCell("20.0", false));
//            itemsTable.AddCell(CreateCell("STRIP", false));
//            itemsTable.AddCell(CreateCell("60.0", false));

//            itemsTable.AddCell(CreateCell("VASTAREL MR 35MG 30TAB", false));
//            itemsTable.AddCell(CreateCell("5.0", false));
//            itemsTable.AddCell(CreateCell("8.5", false));
//            itemsTable.AddCell(CreateCell("STRIP", false));
//            itemsTable.AddCell(CreateCell("35.1", false));

//            // Total Row
//            //itemsTable.AddCell(CreateCell("Total", true));
//            //PdfPCell totalCell = new PdfPCell(new Phrase("507.0"))
//            //{
//            //    Colspan = 4,
//            //    HorizontalAlignment = Element.ALIGN_RIGHT
//            //};
//            //itemsTable.AddCell(totalCell);

//            // Add the table to the document (assuming you have a 'document' object)
//            document.Add(itemsTable);


//            document.Add(new Paragraph(" "));
//            // Line Table 2 (second line)
//            PdfPTable lineTable2 = new PdfPTable(1);
//            lineTable2.WidthPercentage = 100;  // Set the width percentage to 100
//            PdfPCell lineCell2 = new PdfPCell(new Phrase(string.Empty))
//            {
//                Border = Rectangle.BOTTOM_BORDER,  // Set bottom border to create a line
//                BorderWidthBottom = 1f,  // Set the thickness of the line
//                FixedHeight = 1f,  // Set the height of the line (thickness)
//                HorizontalAlignment = Element.ALIGN_CENTER,  // Center align the line
//            };
//            lineTable2.AddCell(lineCell2);
//            document.Add(lineTable2);

//            // Add another blank line after the line if necessary
//            document.Add(new Paragraph(" ")); // Blank line for additional distance

//            // Add row with "Total", "CO", "Net"
//            PdfPTable Total = new PdfPTable(3);  // 3 columns for Total, CO, and Net
//            Total.WidthPercentage = 100;  // Set the table width to 100%

//            // Define the background color and text color for the footer cells
//            BaseColor footerBackgroundColor = new BaseColor(0, 153, 153); // Same as header background color
//            BaseColor footerTextColor = BaseColor.WHITE; // White text color

//            // Add cells for "Total", "CO", and "Net"
//            Total.AddCell(CreateTotalCell("Total", footerBackgroundColor, footerTextColor, "100.0"));
//            Total.AddCell(CreateTotalCell("CO", footerBackgroundColor, footerTextColor, "50.0"));
//            Total.AddCell(CreateTotalCell("Net", footerBackgroundColor, footerTextColor, "150.0"));

//            // Add the footer table to the document
//            document.Add(Total);






//            // Footer section with custom text
//            var footerFont = FontFactory.GetFont("Arial", 10);

//            // Create the first part of the text (Last Updated by)
//            var firstPart = new Chunk("Last Updated by : Online User", footerFont);

//            // Create the second part of the text (Printed by)
//            var secondPart = new Chunk("Printed by : woods pharma LLC", footerFont);

//            // Create a Phrase to combine both parts and align them on opposite sides
//            var footerPhrase = new Phrase();
//            footerPhrase.Add(firstPart);
//            footerPhrase.Add(new Chunk(new string(' ', 50))); // Add space between the two parts
//            footerPhrase.Add(secondPart);

//            // Create a Paragraph with the Phrase and align it to the center
//            document.Add(new Paragraph(footerPhrase)
//            {
//                Alignment = Element.ALIGN_CENTER,
//                SpacingBefore = 10
//            });

//            // Create the second row for Terms & Condition
//            var termsHeader = new Chunk("Terms & Condition", footerFont);
//            var termsHeaderPhrase = new Phrase(termsHeader);

//            // Create a Paragraph for the Terms & Condition and center align it
//            document.Add(new Paragraph(termsHeaderPhrase)
//            {
//                Alignment = Element.ALIGN_CENTER,
//                SpacingBefore = 5
//            });

//            // Create the third row for the detailed Terms & Condition text
//            var termsContent = new Chunk("All prices and costs are supposed to be in EGPs only. Kindly refer to our official website for more information about Terms & Condition.", footerFont);
//            var termsContentPhrase = new Phrase(termsContent);

//            // Create a Paragraph for the Terms content and center align it
//            document.Add(new Paragraph(termsContentPhrase)
//            {
//                Alignment = Element.ALIGN_CENTER,
//                SpacingBefore = 5
//            });






//            // Close document
//            document.Close();

//            // Return the PDF as a byte array
//            response.Data = new PrintApprovalResponse
//            {
//                FileName = $"Invoice_{request.ApprovalId}.pdf",
//                FileContent = memoryStream.ToArray()
//            };
//            response.Success = true;
//            response.MessageEn = "PDF generated successfully.";
//        }
//    }
//    catch (Exception ex)
//    {
//        response.Success = false;
//        response.MessageEn = $"Failed to generate PDF: {ex.Message}";
//    }

//    return response;
//}




// Create body cells (no custom background for body, just alignment and no border)
//private static PdfPCell CreateCell(string content, bool isBold)
//{
//    Font font = isBold ? FontFactory.GetFont("Arial", 12, Font.BOLD) : FontFactory.GetFont("Arial", 12);
//    var cell = new PdfPCell(new Phrase(content, font))
//    {
//        HorizontalAlignment = Element.ALIGN_CENTER, // Center the text horizontally
//        VerticalAlignment = Element.ALIGN_MIDDLE, // Center the text vertically
//        Padding = 5f, // Optional: Add padding for spacing
//        Border = PdfPCell.NO_BORDER // Remove border for body cells
//    };

//    return cell;
//}
//private PdfPCell CreateTotalCell(string label, BaseColor backgroundColor, BaseColor textColor, string value)
//{
//    PdfPCell cell = new PdfPCell(new Phrase($"{label}: {value}", FontFactory.GetFont("Arial", 10, Font.BOLD, textColor)))
//    {
//        BackgroundColor = backgroundColor,
//        HorizontalAlignment = Element.ALIGN_CENTER,  // Center the text in the cell
//        VerticalAlignment = Element.ALIGN_MIDDLE,  // Center the text vertically
//        FixedHeight = 25f ,// Height of the cell
//        Border = Rectangle.NO_BORDER
//    };
//    return cell;
//}
//private static bool ContainsArabic(string text)
//{
//    foreach (char character in text)
//    {
//        if (character >= 0x0600 && character <= 0x06FF) // نطاق الحروف العربية في Unicode
//        {
//            return true;
//        }
//    }
//    return false;
//}
//private static bool IsArabic(string text)
//{
//    // Return true if text contains any Arabic character
//    return text.Any(c => (c >= 0x0600 && c <= 0x06FF));
//}
//private static Font GetArabicFont(bool isBold)
//{
//    // Make sure to use a proper Arabic font file (e.g., Amiri-Regular.ttf)
//    string fontPath = "path/to/Amiri-Regular.ttf"; // Specify the full path to the Arabic font file

//    return isBold
//        ? FontFactory.GetFont(fontPath, BaseFont.IDENTITY_H, BaseFont.EMBEDDED, 12, Font.BOLD)
//        : FontFactory.GetFont(fontPath, BaseFont.IDENTITY_H, BaseFont.EMBEDDED, 12);
//}

//private static PdfPCell CreateCell(string content, bool isBold)
//{
//    // Detect if the text is Arabic
//    bool isArabic = IsArabic(content);

//    // Use Arabic font if text is Arabic, otherwise use Helvetica for English
//    Font font = isArabic
//        ? GetArabicFont(isBold)  // Use the Arabic font
//        : FontFactory.GetFont("Helvetica", 12, isBold ? Font.BOLD : Font.NORMAL);

//    // Set alignment for Arabic (right-to-left) or English (left-to-right)
//    int horizontalAlignment = isArabic ? Element.ALIGN_RIGHT : Element.ALIGN_LEFT;

//    // Create the cell with proper font and alignment
//    var cell = new PdfPCell(new Phrase(content, font))
//    {
//        HorizontalAlignment = horizontalAlignment,
//        VerticalAlignment = Element.ALIGN_MIDDLE,
//        Padding = 5f,
//        Border = PdfPCell.NO_BORDER
//    };

//    return cell;
//}



// Function to create footer cell with text and background color