#pragma checksum "/Users/alexlinneman/Projects/MyPortfolio/MyPortfolio/Views/IDC/Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "28af2d6e5b930196d20e52942cbd1970a58fc069"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_IDC_Details), @"mvc.1.0.view", @"/Views/IDC/Details.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "/Users/alexlinneman/Projects/MyPortfolio/MyPortfolio/Views/_ViewImports.cshtml"
using MyPortfolio;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/alexlinneman/Projects/MyPortfolio/MyPortfolio/Views/_ViewImports.cshtml"
using MyPortfolio.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"28af2d6e5b930196d20e52942cbd1970a58fc069", @"/Views/IDC/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2b0fdc90dd0e45556f54000adf4887349491b671", @"/Views/_ViewImports.cshtml")]
    public class Views_IDC_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<YelpCompleteDetails>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<style>
    #IDC {
        color: #F28500
    }

    #IDCButton {
        color: white;
        background-color: #F28500;
        border-radius: 7px;
        padding-bottom: 10px;
        padding-top: 10px;
        padding-right: 18px;
        padding-left: 18px;
        font-size: 20px;
    }


        .mySlides {
            text-align: center;
            display: none;
        }
        img {
            vertical-align: middle;
            object-fit: cover;
            width: auto;
            height: auto;
            max-height: 400px;
            max-width: 350px;
        }

/* Slideshow container */
.slideshow-container {
    width: auto;
    height: 400px;
    position: relative;
    margin: auto;
}

/* Next & previous buttons */
    .prev, .next {
        cursor: pointer;
        position: absolute;
        top: 50%;
        width: auto;
        padding: 16px;
        margin-top: -22px;
        color: white;
        font-weight: bold;
        font-si");
            WriteLiteral(@"ze: 18px;
        transition: 0.6s ease;
        border-radius: 0 3px 3px 0;
        user-select: none;
        background-color: #F28500;
    }

/* Position the ""next button"" to the right */
.next {
  right: 0;
  border-radius: 3px 0 0 3px;
}

/* On hover, add a black background color with a little bit see-through */
    .prev:hover, .next:hover {
        background-color: #F28500;
    }

/* The dots/bullets/indicators */
.dot {
  cursor: pointer;
  height: 15px;
  width: 15px;
  margin: 0 2px;
  background-color: #bbb;
  border-radius: 50%;
  display: inline-block;
  transition: background-color 0.6s ease;
}

.active, .dot:hover {
  background-color: #717171;
}

/* Fading animation */
.fade {
  -webkit-animation-name: fade;
  -webkit-animation-duration: 1.5s;
  animation-name: fade;
  animation-duration: 1.5s;
}

");
            WriteLiteral("@-webkit-keyframes fade {\r\n  from {opacity: .4}\r\n  to {opacity: 1}\r\n}\r\n\r\n");
            WriteLiteral(@"@keyframes fade {
  from {opacity: .4}
  to {opacity: 1}
}

</style>
<h1 id=""IDC"" style=""text-align:center;"">And your selection is:</h1>
<div class=""loader"">
    <div class=""row"">
        <div class=""col-md-12"" style=""text-align:center;"">
            <h2>");
#nullable restore
#line 107 "/Users/alexlinneman/Projects/MyPortfolio/MyPortfolio/Views/IDC/Details.cshtml"
           Write(Model.YelpBusiness.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n        </div>\r\n    </div>\r\n    <div class=\"row\">\r\n        <div class=\"col-md-12\" style=\"text-align:center;\">\r\n            <h3 id=\"IDC\">Is this your first time meeting ");
#nullable restore
#line 112 "/Users/alexlinneman/Projects/MyPortfolio/MyPortfolio/Views/IDC/Details.cshtml"
                                                    Write(Model.YelpBusiness.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("?</h3>\r\n            <h3 id=\"IDC\">Let\'s get to know them.</h3>\r\n        </div>\r\n    </div>\r\n    <div class=\"row\">\r\n        <div class=\"col-md-8\">\r\n            <div class=\"slideshow-container\">\r\n");
#nullable restore
#line 119 "/Users/alexlinneman/Projects/MyPortfolio/MyPortfolio/Views/IDC/Details.cshtml"
                 foreach (var photo in Model.YelpBusiness.Photos)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <div class=\"mySlides\" style=\"text-align:center;\">\r\n                        <img");
            BeginWriteAttribute("src", " src=\"", 2862, "\"", 2874, 1);
#nullable restore
#line 122 "/Users/alexlinneman/Projects/MyPortfolio/MyPortfolio/Views/IDC/Details.cshtml"
WriteAttributeValue("", 2868, photo, 2868, 6, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                    </div>\r\n");
#nullable restore
#line 124 "/Users/alexlinneman/Projects/MyPortfolio/MyPortfolio/Views/IDC/Details.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                <a class=""prev"" onclick=""plusSlides(-1)"">&#10094;</a>
                <a class=""next"" onclick=""plusSlides(1)"">&#10095;</a>

            </div>
            <br>

            <div style=""text-align:center"">
                <span class=""dot"" onclick=""currentSlide(1)""></span>
                <span class=""dot"" onclick=""currentSlide(2)""></span>
                <span class=""dot"" onclick=""currentSlide(3)""></span>
            </div>
        </div>
        <div class=""col-md-4"">
            <br />
            <br />
");
#nullable restore
#line 141 "/Users/alexlinneman/Projects/MyPortfolio/MyPortfolio/Views/IDC/Details.cshtml"
             if (Model.YelpBusiness.IsClosed)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <h5 style=\"color:red\">Closed Now</h5>\r\n");
#nullable restore
#line 144 "/Users/alexlinneman/Projects/MyPortfolio/MyPortfolio/Views/IDC/Details.cshtml"
            }
            else
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <h5 style=\"color:green\">Open Now</h5>\r\n");
#nullable restore
#line 148 "/Users/alexlinneman/Projects/MyPortfolio/MyPortfolio/Views/IDC/Details.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("            <h5>");
#nullable restore
#line 149 "/Users/alexlinneman/Projects/MyPortfolio/MyPortfolio/Views/IDC/Details.cshtml"
           Write(Model.YelpBusiness.Categories.FirstOrDefault().Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n            <h5>Call now: <a");
            BeginWriteAttribute("href", " href=\"", 3809, "\"", 3853, 2);
            WriteAttributeValue("", 3816, "tel:", 3816, 4, true);
#nullable restore
#line 150 "/Users/alexlinneman/Projects/MyPortfolio/MyPortfolio/Views/IDC/Details.cshtml"
WriteAttributeValue(" ", 3820, Model.YelpBusiness.DisplayPhone, 3821, 32, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 150 "/Users/alexlinneman/Projects/MyPortfolio/MyPortfolio/Views/IDC/Details.cshtml"
                                                                     Write(Model.YelpBusiness.DisplayPhone);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></h5>\r\n            <h5>");
#nullable restore
#line 151 "/Users/alexlinneman/Projects/MyPortfolio/MyPortfolio/Views/IDC/Details.cshtml"
           Write(Model.YelpBusiness.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n            <h5><a");
            BeginWriteAttribute("href", " href=\"", 3964, "\"", 4093, 4);
            WriteAttributeValue("", 3971, "https://www.google.com/maps?saddr&daddr=", 3971, 40, true);
#nullable restore
#line 152 "/Users/alexlinneman/Projects/MyPortfolio/MyPortfolio/Views/IDC/Details.cshtml"
WriteAttributeValue("", 4011, Model.YelpBusiness.Coordinates.Latitude, 4011, 40, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 4051, ",", 4051, 1, true);
#nullable restore
#line 152 "/Users/alexlinneman/Projects/MyPortfolio/MyPortfolio/Views/IDC/Details.cshtml"
WriteAttributeValue("", 4052, Model.YelpBusiness.Coordinates.Longitude, 4052, 41, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 152 "/Users/alexlinneman/Projects/MyPortfolio/MyPortfolio/Views/IDC/Details.cshtml"
                                                                                                                                                Write(Model.YelpBusiness.Location.Address1);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 152 "/Users/alexlinneman/Projects/MyPortfolio/MyPortfolio/Views/IDC/Details.cshtml"
                                                                                                                                                                                      Write(Model.YelpBusiness.Location.City);

#line default
#line hidden
#nullable disable
            WriteLiteral(", ");
#nullable restore
#line 152 "/Users/alexlinneman/Projects/MyPortfolio/MyPortfolio/Views/IDC/Details.cshtml"
                                                                                                                                                                                                                         Write(Model.YelpBusiness.Location.State);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></h5>\r\n            <h5>Hours Today: ");
#nullable restore
#line 153 "/Users/alexlinneman/Projects/MyPortfolio/MyPortfolio/Views/IDC/Details.cshtml"
                        Write(Model.HoursToday);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n            <a");
            BeginWriteAttribute("href", " href=\"", 4280, "\"", 4310, 1);
#nullable restore
#line 154 "/Users/alexlinneman/Projects/MyPortfolio/MyPortfolio/Views/IDC/Details.cshtml"
WriteAttributeValue("", 4287, Model.YelpBusiness.Url, 4287, 23, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@"><img id=""yelpBurst"" style=""height:100px; width:100px;"" src=""https://i.imgur.com/chncIJM.png"" /><h5 style=""color:GrayText"">Read More On Yelp</h5></a>
        </div>
    </div>
    <br />
    <div class=""row"" style=""text-align:center;"">
        <div class=""col-md-12"">
            <h3 id=""IDC"">Not your style?</h3>
            <button id=""IDCButton"" onClick=""window.location.reload();"">Click here to generate another restaurant</button>
        </div>
    </div>
    <br />
    <br />
    <div class=""row"">
        <div class=""col-md-12"">
            <div id=""map"" style=""height:500px; margin-bottom: 3px; margin-top: 10px;""></div>
        </div>
    </div>
    <br />
    <br />
    <div class=""row"">
        <div class=""col-md-12"">
            <h2 id=""IDC"" style=""text-align: center"">Suggested Reviews</h2>
            <div style=""text-align:center;"">
                <a");
            BeginWriteAttribute("href", " href=\"", 5205, "\"", 5235, 1);
#nullable restore
#line 177 "/Users/alexlinneman/Projects/MyPortfolio/MyPortfolio/Views/IDC/Details.cshtml"
WriteAttributeValue("", 5212, Model.YelpBusiness.Url, 5212, 23, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("><img src=\"https://i.imgur.com/VWwglFk.png\" style=\"width: 200px; height:auto;\" /></a>\r\n                <img");
            BeginWriteAttribute("src", " src=\"", 5343, "\"", 5367, 1);
#nullable restore
#line 178 "/Users/alexlinneman/Projects/MyPortfolio/MyPortfolio/Views/IDC/Details.cshtml"
WriteAttributeValue("", 5349, Model.ReviewImage, 5349, 18, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n                <h5 style=\"text-align: center\">Based on ");
#nullable restore
#line 179 "/Users/alexlinneman/Projects/MyPortfolio/MyPortfolio/Views/IDC/Details.cshtml"
                                                   Write(Model.YelpReviews.Total);

#line default
#line hidden
#nullable disable
            WriteLiteral(" reviews</h5>\r\n            </div>\r\n\r\n");
#nullable restore
#line 182 "/Users/alexlinneman/Projects/MyPortfolio/MyPortfolio/Views/IDC/Details.cshtml"
             foreach (var review in Model.YelpReviews.Reviews)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div style=\"margin-left: 8px; margin-right:8px;\">\r\n                    <img id=\"review\" style=\"height:50px; width:50px; border-radius:50%\"");
            BeginWriteAttribute("src", " src=\"", 5723, "\"", 5750, 1);
#nullable restore
#line 185 "/Users/alexlinneman/Projects/MyPortfolio/MyPortfolio/Views/IDC/Details.cshtml"
WriteAttributeValue("", 5729, review.User.ImageUrl, 5729, 21, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n                    <br />\r\n                    <h4 id=\"IDC\"><a");
            BeginWriteAttribute("href", " href=\"", 5819, "\"", 5849, 1);
#nullable restore
#line 187 "/Users/alexlinneman/Projects/MyPortfolio/MyPortfolio/Views/IDC/Details.cshtml"
WriteAttributeValue("", 5826, review.User.ProfileUrl, 5826, 23, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" id=\"IDC\">");
#nullable restore
#line 187 "/Users/alexlinneman/Projects/MyPortfolio/MyPortfolio/Views/IDC/Details.cshtml"
                                                                       Write(review.User.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></h4>\r\n                    <h5>");
#nullable restore
#line 188 "/Users/alexlinneman/Projects/MyPortfolio/MyPortfolio/Views/IDC/Details.cshtml"
                   Write(review.TimeCreated.Date.ToString().Replace("00:00:00", ""));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n                    <img");
            BeginWriteAttribute("src", " src=\"", 6002, "\"", 6018, 1);
#nullable restore
#line 189 "/Users/alexlinneman/Projects/MyPortfolio/MyPortfolio/Views/IDC/Details.cshtml"
WriteAttributeValue("", 6008, review.Id, 6008, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n                    <br />\r\n                    <h5>");
#nullable restore
#line 191 "/Users/alexlinneman/Projects/MyPortfolio/MyPortfolio/Views/IDC/Details.cshtml"
                   Write(review.Text);

#line default
#line hidden
#nullable disable
            WriteLiteral(" <a");
            BeginWriteAttribute("href", " href=\"", 6091, "\"", 6109, 1);
#nullable restore
#line 191 "/Users/alexlinneman/Projects/MyPortfolio/MyPortfolio/Views/IDC/Details.cshtml"
WriteAttributeValue("", 6098, review.Url, 6098, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" style=\"color:GrayText\"> read more</a></h5>\r\n                    <br />\r\n                    <br />\r\n                </div>\r\n");
#nullable restore
#line 195 "/Users/alexlinneman/Projects/MyPortfolio/MyPortfolio/Views/IDC/Details.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"        </div>
    </div>
</div>
    <script>var slideIndex = 1;
        showSlides(slideIndex);

        function plusSlides(n) {
            showSlides(slideIndex += n);
        }

        function currentSlide(n) {
            showSlides(slideIndex = n);
        }

        function showSlides(n) {
            var i;
            var slides = document.getElementsByClassName(""mySlides"");
            var dots = document.getElementsByClassName(""dot"");
            if (n > slides.length) { slideIndex = 1 }
            if (n < 1) { slideIndex = slides.length }
            for (i = 0; i < slides.length; i++) {
                slides[i].style.display = ""none"";
            }
            for (i = 0; i < dots.length; i++) {
                dots[i].className = dots[i].className.replace("" active"", """");
            }
            slides[slideIndex - 1].style.display = ""block"";
            dots[slideIndex - 1].className += "" active"";
        }</script>

    <script>
        function initMap() ");
            WriteLiteral("{\r\n            var position = { lat: ");
#nullable restore
#line 228 "/Users/alexlinneman/Projects/MyPortfolio/MyPortfolio/Views/IDC/Details.cshtml"
                             Write(Model.YelpBusiness.Coordinates.Latitude);

#line default
#line hidden
#nullable disable
            WriteLiteral(", lng: ");
#nullable restore
#line 228 "/Users/alexlinneman/Projects/MyPortfolio/MyPortfolio/Views/IDC/Details.cshtml"
                                                                            Write(Model.YelpBusiness.Coordinates.Longitude);

#line default
#line hidden
#nullable disable
            WriteLiteral(@" };
            var map = new google.maps.Map(document.getElementById('map'), {
                center: position,
                zoom: 17
            });
            var marker = new google.maps.Marker({
                position: position,
                map: map,
                title: '");
#nullable restore
#line 236 "/Users/alexlinneman/Projects/MyPortfolio/MyPortfolio/Views/IDC/Details.cshtml"
                   Write(Model.YelpBusiness.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("\'\n            });\r\n            }\r\n    </script>\r\n    <script");
            BeginWriteAttribute("src", " src=\"", 7779, "\"", 7875, 3);
            WriteAttributeValue("", 7785, "https://maps.googleapis.com/maps/api/js?key=", 7785, 44, true);
#nullable restore
#line 240 "/Users/alexlinneman/Projects/MyPortfolio/MyPortfolio/Views/IDC/Details.cshtml"
WriteAttributeValue("", 7829, Constants.googleMapsApiKey, 7829, 29, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 7858, "&callback=initMap", 7858, 17, true);
            EndWriteAttribute();
            WriteLiteral(" async defer></script>");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<YelpCompleteDetails> Html { get; private set; }
    }
}
#pragma warning restore 1591
