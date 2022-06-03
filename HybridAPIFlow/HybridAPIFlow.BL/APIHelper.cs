using HybridAPIFlow.BL.AirServices;
using IO.Swagger.Api;
using IO.Swagger.Model;
using Newtonsoft.Json;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.ServiceModel;
using System.ServiceModel.Channels;
using System.ServiceModel.Description;
using System.ServiceModel.Dispatcher;
using System.Text;

namespace HybridAPIFlow.BL
{
    public class FlightSegments
    {
        public string Carrier { set; get; }
        public string FlightNumber { set; get; }
        public string Origin { set; get; }
        public string Destination { set; get; }
        public string DepDate { set; get; }
        public string DepTime { set; get; }
        public string ArrivalDate { set; get; }
        public string ArrivalTime { set; get; }
        public string ClassofService { set; get; }
        public int Group { set; get; }
        public string Tier { set; get; }
    }

    public class OptionalService
    {
        public string Type { set; get; }
        public string Tag { set; get; }
        public string Chargeable { set; get; }
        public string brandAttribute { set; get; }        
    }
    public class PricingSolution
    {
        public string TotalPrice { set; get; }
        public string BasePrice { set; get; }
        public string Taxes { set; get; }
        public string Fees { set; get; }
        public string BrandName { set; get; }
        public string BrandTier { set; get; }
        public OptionalService[] optionalService { set; get; }
    }


    public class HttpHeaderMessageInspector : IClientMessageInspector
    {
        private readonly Dictionary<string, string> _httpHeaders;

        public HttpHeaderMessageInspector()
        {

        }

        public HttpHeaderMessageInspector(Dictionary<string, string> httpHeaders)
        {
            this._httpHeaders = httpHeaders;
        }

        public void AfterReceiveReply(ref Message reply, object correlationState) { }

        public object BeforeSendRequest(ref Message request, IClientChannel channel)
        {
            HttpRequestMessageProperty httpRequestMessage;
            object httpRequestMessageObject;
            string userName = "";
            string passWord = "";

            if (request.Properties.TryGetValue(HttpRequestMessageProperty.Name, out httpRequestMessageObject))
            {
                httpRequestMessage = httpRequestMessageObject as HttpRequestMessageProperty;

                foreach (var httpHeader in _httpHeaders)
                {
                    //httpRequestMessage.Headers[httpHeader.Key] = httpHeader.Value;
                    if (httpHeader.Key.CompareTo("Username") == 0)
                    {
                        userName = httpHeader.Value;
                    }
                    else if (httpHeader.Key.CompareTo("Password") == 0)
                    {
                        passWord = httpHeader.Value;
                    }
                }

                httpRequestMessage.Headers[HttpRequestHeader.Authorization] = "Basic " +
                                   Convert.ToBase64String(Encoding.ASCII.GetBytes(userName + ":" + passWord));
            }
            else
            {
                httpRequestMessage = new HttpRequestMessageProperty();

                foreach (var httpHeader in _httpHeaders)
                {
                    httpRequestMessage.Headers.Add(httpHeader.Key, httpHeader.Value);
                }
                request.Properties.Add(HttpRequestMessageProperty.Name, httpRequestMessage);
            }
            return null;
        }
    }

    internal class HttpHeadersEndpointBehavior : IEndpointBehavior
    {
        private readonly Dictionary<string, string> _httpHeaders;

        public HttpHeadersEndpointBehavior(Dictionary<string, string> httpHeaders)
        {
            this._httpHeaders = httpHeaders;
        }
        public void AddBindingParameters(ServiceEndpoint endpoint, BindingParameterCollection bindingParameters) { }

        public void ApplyClientBehavior(ServiceEndpoint endpoint, ClientRuntime clientRuntime)
        {
            var inspector = new HttpHeaderMessageInspector(this._httpHeaders);

            clientRuntime.ClientMessageInspectors.Add(inspector);
        }

        public void ApplyDispatchBehavior(ServiceEndpoint endpoint, EndpointDispatcher endpointDispatcher) { }
        public void Validate(ServiceEndpoint endpoint) { }
    }

    public class APIHelper
    {
        private const string ProviderCode = "1G";
        private const string ApplicationName = "JSON-XML-Demo";
        public static NLog.Logger logger = NLog.LogManager.GetCurrentClassLogger();

        public static cAjaxResponse ExecuteSearchPlus(string token, string endpoint, string version, string service,
            string AccessGroup, string From, string To, string DepartureDate, string returnDate, string Carrier)
        {
            cAjaxResponse ajaxReqResponse = new cAjaxResponse(); // An object to hold the request and response


            CatalogProductOfferingsQueryRequest req = new CatalogProductOfferingsQueryRequest("CatalogProductOfferingsQueryRequest", new CatalogProductOfferingsRequest("CatalogProductOfferingsRequest"), null);
            CatalogProductOfferingsQueryRequestWrapper root = new CatalogProductOfferingsQueryRequestWrapper();
            root.CatalogProductOfferingsQueryRequest = req;

            CatalogProductOfferingsRequestAir offering = new CatalogProductOfferingsRequestAir();
            req.CatalogProductOfferingsRequest = offering;
            offering.MaxNumberOfUpsellsToReturn = 3;


            PassengerCriteria criteria = new PassengerCriteria("PassengerCriteria");
            criteria.Number = 1;
            criteria.PassengerTypeCode = "ADT";
            offering.PassengerCriteria = new List<PassengerCriteria>();
            offering.PassengerCriteria.Add(criteria);




            FromTo _from = new FromTo();
            FromTo _to = new FromTo();

            _from.Value = From;
            _to.Value = To;

            DateTime _departureDate = DateTime.ParseExact(DepartureDate, "MM/dd/yyyy", System.Globalization.CultureInfo.CurrentCulture);
            SearchCriteriaFlight search = new SearchCriteriaFlight("SearchCriteriaFlight", _departureDate, null, 1, _from, _to);


            List<string> _Carriers = new List<string>();
            _Carriers.Add(Carrier.ToUpper());

            SearchModifiersAir modifier = new SearchModifiersAir("SearchModifiersAir");
            //modifier.Type = "SearchModifiersAir";
            CarrierPreference pref = new CarrierPreference("CarrierPreference", CarrierPreferenceTypeEnum.Permitted, _Carriers);

            pref.PreferenceType = CarrierPreferenceTypeEnum.Permitted;


            modifier.CarrierPreference = new List<CarrierPreference>();
            modifier.CarrierPreference.Add(pref);

            //FlightType type = new FlightType("FlightType", ConnectionTypeEnum.NonStopDirect, true);


            offering.SearchModifiersAir = modifier;
            offering.SearchCriteriaFlight = new List<SearchCriteriaFlight>();
            offering.SearchCriteriaFlight.Add(search);


            if (returnDate != string.Empty) // return flight
            {
                DateTime _returnDate = DateTime.ParseExact(returnDate, "MM/dd/yyyy", System.Globalization.CultureInfo.CurrentCulture);
                SearchCriteriaFlight searchReturn = new SearchCriteriaFlight("SearchCriteriaFlight", _returnDate, null, 2, _to, _from);
                offering.SearchCriteriaFlight.Add(searchReturn);
            }



            DefaultApi client = new DefaultApi(string.Format("{0}/{1}/{2}", endpoint, version, service));

            Guid guid = Guid.NewGuid();
            string traceID = guid.ToString();
            client.Configuration.AddDefaultHeader("Authorization", "Bearer " + token);
            client.Configuration.AddDefaultHeader("XAUTH_TRAVELPORT_ACCESSGROUP", AccessGroup);

            try
            {
                ajaxReqResponse.Request = JsonConvert.SerializeObject(root, Formatting.Indented);
                CatalogProductOfferingsResponseWrapper resp = client.Create(root);

                ajaxReqResponse.offerings = resp.ToJson();
                ajaxReqResponse.Status = 0; //success

            }
            catch (Exception ex)
            {
                logger.Error(ex);
                ajaxReqResponse.offerings = ex.Message;
                ajaxReqResponse.Status = 1; //Fail
            }

            return ajaxReqResponse;
        }


        public static cAjaxResponse ExecuteAirPrice(string BranchId, string xmlUserName, string xmlPassword, string xmlEndpoint, List<FlightSegments> listSegments, string Tier)
        {
            AirPriceReq airPriceReq = SetUpAirPriceReq(BranchId, listSegments, false, Tier);
            string xmlRequest = ObjectToXML(airPriceReq);

            AirPricePortTypeClient client = new AirPricePortTypeClient("AirPricePort", xmlEndpoint);
            client.ClientCredentials.UserName.UserName = xmlUserName;
            client.ClientCredentials.UserName.Password = xmlPassword;
            cAjaxResponse response = new cAjaxResponse();
            List<FlightSegments> listFS = new List<FlightSegments>();
            try
            {
                var httpHeaders = ReturnHttpHeader(xmlUserName, xmlPassword);

                //TODO
                client.Endpoint.EndpointBehaviors.Add(new HttpHeadersEndpointBehavior(httpHeaders));

                AirPriceRsp airPriceRes = client.service(null, airPriceReq);

                response.Status = 0;
                response.Request = xmlRequest;
                response.offerings = ObjectToXML(airPriceRes);
                response.pricingSolutions = ParseAirPriceResponse(airPriceRes, ref listFS);
                response.flightSegments = listFS;


                return response;
            }
            catch (Exception se)
            {
                logger.Error(se, se.Message);
                client.Abort();

                response.Status = 1;
                response.Request = xmlRequest;
                response.offerings = se.Message.ToString();

                return response;
            }
        }

        private static AirPriceReq SetUpAirPriceReq(string BranchId, List<FlightSegments> pricingSegments,
            bool isFareFamilyDisplay, string Tier)
        {
            AirPriceReq priceReq = new AirPriceReq();
            AddPointOfSale(priceReq, ApplicationName);

            AirItinerary itinerary = new AirItinerary();

            List<typeBaseAirSegment> itinerarySegments = new List<typeBaseAirSegment>();


            for (int i = 0; i < pricingSegments.Count; i++)
            {
                typeBaseAirSegment segment = new typeBaseAirSegment();
                segment.Group = pricingSegments[i].Group;
                segment.Origin = pricingSegments[i].Origin;
                segment.DepartureTime = pricingSegments[i].DepDate + "T" + pricingSegments[i].DepTime + ":00"; //get proper date
                segment.Carrier = pricingSegments[i].Carrier;
                segment.Destination = pricingSegments[i].Destination;
                segment.ArrivalTime = pricingSegments[i].ArrivalDate + "T" + pricingSegments[i].ArrivalTime + ":00";
                segment.ProviderCode = "1G";
                segment.FlightNumber = pricingSegments[i].FlightNumber;
                segment.ClassOfService = pricingSegments[i].ClassofService;
                segment.Key = i.ToString();
                itinerarySegments.Add(segment);
            }


            itinerary.AirSegment = itinerarySegments.ToArray();

            priceReq.AirItinerary = itinerary;

            priceReq.SearchPassenger = AddSearchPassenger();

            priceReq.AirPricingModifiers = new AirPricingModifiers()
            {
                PlatingCarrier = priceReq.AirItinerary.AirSegment[0].Carrier
            };

            if (isFareFamilyDisplay)
            {
                priceReq.AirPricingModifiers.BrandModifiers = new BrandModifiers();
                BrandModifiersFareFamilyDisplay ffs = new BrandModifiersFareFamilyDisplay();
                ffs.ModifierType = "FareFamily";
                priceReq.AirPricingModifiers.BrandModifiers.Item = ffs;
                //priceReq.AirPricingModifiers.BrandModifiers.ModifierType = BrandModifiersModifierType.FareFamilyDisplay;
            }



            List<AirPricingCommand> pricingCommands = new List<AirPricingCommand>();

            AirPricingCommand command = new AirPricingCommand()
            {
                //CabinClass = "Economy"//You can use Economy,PremiumEconomy,Business etc.
            };


            command.AirSegmentPricingModifiers = new AirSegmentPricingModifiers[pricingSegments.Count];


            for (int i = 0; i < pricingSegments.Count; i++)
            {
                command.AirSegmentPricingModifiers[i] = new AirSegmentPricingModifiers();
                command.AirSegmentPricingModifiers[i].AirSegmentRef = i.ToString();
                command.AirSegmentPricingModifiers[i].PermittedBookingCodes = new BookingCode[1];
                command.AirSegmentPricingModifiers[i].PermittedBookingCodes[0] = new BookingCode();
                command.AirSegmentPricingModifiers[i].BrandTier = Tier;
                command.AirSegmentPricingModifiers[i].PermittedBookingCodes[0].Code = pricingSegments[i].ClassofService;
            }

            pricingCommands.Add(command);

            priceReq.AirPricingCommand = pricingCommands.ToArray();


            priceReq.TargetBranch = BranchId;


            return priceReq;
        }

        private static void AddPointOfSale(BaseCoreReq req, string appName)
        {
            BillingPointOfSaleInfo billSaleInfo = new BillingPointOfSaleInfo();
            billSaleInfo.OriginApplication = appName;
            req.BillingPointOfSaleInfo = billSaleInfo;
        }

        private static SearchPassenger[] AddSearchPassenger()
        {
            List<SearchPassenger> passengers = new List<SearchPassenger>();

            SearchPassenger passenger = new SearchPassenger();
            passenger.Code = "ADT";
            passenger.BookingTravelerRef = Guid.NewGuid().ToString();

            passengers.Add(passenger);

            /*SearchPassenger passenger1 = new SearchPassenger();
            passenger1.Code = "ADT";
            passenger1.BookingTravelerRef = "8s04Fns2SiizjV5Zn7T6Xw==";

            passengers.Add(passenger1);*/

            return passengers.ToArray();
        }

        private string buildXMLSegments()
        {
            //xmlDocument xmlSegments = new xmlDocument();
            return string.Empty;
        }

        private static string ObjectToXML(object req)
        {
            //Generate XML
            var serxml = new System.Xml.Serialization.XmlSerializer(req.GetType());
            var ms = new MemoryStream();
            serxml.Serialize(ms, req);
            string xml = Encoding.UTF8.GetString(ms.ToArray());
            logger.Trace(xml);
            return xml;
            //
        }

        public static Dictionary<string, string> ReturnHttpHeader(string xmlUsername, string xmlPassword)
        {
            var httpHeaders = new Dictionary<string, string>();

            httpHeaders.Add("Authorization", "Basic " + Convert.ToBase64String(
                Encoding.ASCII.GetBytes(xmlUsername + ":" + xmlPassword)));
            httpHeaders.Add("Accept-Encoding", "gzip");

            return httpHeaders;
        }

        private static List<PricingSolution> ParseAirPriceResponse(AirPriceRsp response, ref List<FlightSegments> airItinerary)
        {
            List<PricingSolution> airPricingSolutions = new List<PricingSolution>();
            PricingSolution PricingSolution;
            FlightSegments fs;


            try
            {
                if (response.AirItinerary.AirSegment.Length > 0)
                {
                    foreach (typeBaseAirSegment segment in response.AirItinerary.AirSegment)
                    {
                        fs = new FlightSegments();
                        fs.Carrier = segment.Carrier;
                        fs.ClassofService = segment.ClassOfService;
                        fs.FlightNumber = segment.FlightNumber;
                        fs.Origin = segment.Origin;
                        fs.DepDate = segment.DepartureTime;
                        fs.Destination = segment.Destination;
                        fs.ArrivalDate = segment.ArrivalTime;
                        fs.Group = segment.Group;

                        airItinerary.Add(fs);
                    }
                }


                if (response.AirPriceResult[0].AirPricingSolution.Length > 0)
                {

                    foreach (AirPricingSolution ps in response.AirPriceResult[0].AirPricingSolution)
                    {

                        PricingSolution = new PricingSolution();
                        PricingSolution.TotalPrice = ps.TotalPrice;
                        PricingSolution.BasePrice = ps.BasePrice;
                        PricingSolution.Taxes = ps.Taxes;
                        PricingSolution.Fees = ps.Fees;
                        PricingSolution.BrandName = ps.AirPricingInfo[0].FareInfo[0].Brand.Name;
                        PricingSolution.BrandTier = ps.AirPricingInfo[0].FareInfo[0].Brand.BrandTier;
                        PricingSolution.optionalService = new OptionalService[ps.AirPricingInfo[0].FareInfo[0].Brand.OptionalServices.OptionalService.Length];

                        for (int l = 0; l < ps.AirPricingInfo[0].FareInfo[0].Brand.OptionalServices.OptionalService.Length; l++)
                        {

                            PricingSolution.optionalService[l] = new OptionalService
                            {
                                Type = ps.AirPricingInfo[0].FareInfo[0].Brand.OptionalServices.OptionalService[l].Type,
                                Tag = ps.AirPricingInfo[0].FareInfo[0].Brand.OptionalServices.OptionalService[l].Tag,
                                Chargeable = ps.AirPricingInfo[0].FareInfo[0].Brand.OptionalServices.OptionalService[l].Chargeable                               
                            };
                        }
                        airPricingSolutions.Add(PricingSolution);
                    }
                }
            }
            catch (Exception se)
            {
                var msg = se.Message;
            }

            return airPricingSolutions;
        }

    }
        

    public class cAjaxResponse
    {
        public int Status { get; set; } // 0 Success ; 1 PCC is not selected ;
        public string Request { get; set; }
        public string offerings { get; set; }
        public List<FlightSegments> flightSegments { get; set; }
        public List<PricingSolution> pricingSolutions { get; set; }
    }
}
