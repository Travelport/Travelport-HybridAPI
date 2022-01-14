class resultDetails {
    Type;
    TotalPrice;
    BrandRef;
    tierLevel;
    flights;
    returnflights;
    Currency;
    Carrier;
    OfferColor;
    Sequence;
    CombinabilityCode;
    OfferSource;
}

class FlightDetails {
    Carrier;
    FlightNumber;
    Origin;
    Destination;
    DepDate;
    DepTime;
    ArrivalDate;
    ArrivalTime;
    ClassofService;
}


class FFOffers {
    OfferId;
    OfferDetails;
}

const logoLink = 'https://goprivate.wspan.com/sharedservices/images/airlineimages/logoAir';

function debug(logline) {
    console.log(logline);
}

$(document).ready(function () {
    $("#loading").hide();
    $("#jsonRequest").hide();
    $('#dtpReturnDate').hide();
   

    var date = new Date();
    date.setDate(date.getDate() - 1);
    $('#dtpDepartureDate').datepicker({
        footer: true,
        modal: true,
        uiLibrary: 'bootstrap4',
        minDate: date,
        change: function (e) {
            if ($('#tripType input:radio:checked').val() == "ReturnTrip") { // if return trip shown reset return datepicker
                $("#dtpReturnDate").datepicker().destroy();
                $('#dtpReturnDate').datepicker({
                    footer: true,
                    modal: true,
                    uiLibrary: 'bootstrap4',
                    minDate: $('#dtpDepartureDate').val()
                });
            }
        }
    });
       
     
})


function unclickRadio() {
    $("input:radio").prop("checked", false);
    $("#SelectedFlights").val('');
}
function clickRadio(inputElement) {
    $("#" + inputElement).prop("checked", true);
    var cardId = inputElement.replace('rbOut', '').replace('rbIn', '');
 
    $("#SelectedFlights").data('selectedflights', $("#selected" + cardId).data(`flights`));
    $("#SelectedFlights").data('selectedReturnflights', $("#selected" + cardId).data(`returnflights`));
   
}
function removeActive() {
    $(".card").removeClass("active-card");
}
function makeActive(element) {
    var cardId = element.replace('rbOut', '').replace('rbIn', '');
    $("#card-" + cardId).addClass("active-card");
}


function bindRadioButtonsEvents() {
    $('input:radio').change(function () {//Clicking input radio
        
        var radioClicked = $(this).attr('id');
        unclickRadio();
        removeActive();
        clickRadio(radioClicked);
        makeActive(radioClicked);
    });

    if ($("#optnOneWay").is(':checked')) {

        $(".card").click(function () {//Clicking the card

            var inputElement = $(this).find('input[type=radio]').attr('id');
            unclickRadio();
            removeActive();
            makeActive(inputElement);
            clickRadio(inputElement);
        });
    }
}

function HideReturnDate() {
    $("#dtpReturnDate").datepicker().destroy();
    $('#dtpReturnDate').val('');
    $('#dtpReturnDate').hide();
}

function ShowReturnDate() {
    $('#dtpReturnDate').datepicker({
        footer: true,
        modal: true,
        uiLibrary: 'bootstrap4',
        minDate: $('#dtpDepartureDate').val()
    });
    $('#dtpReturnDate').show();
}

function loadShopResults() {

    if (ValidateInput()) {

        $("#LFSResults").empty();
        $("#loading").show();
        $("#jsonRequest").empty();
        $("#jsonResponse").empty();
        $("#Visualize").empty();

        $.ajax({
            url: $("#requestForm").data('request-url'),
            dataSrc: '',
            data: {
                fromAiport: $('#txtfrom').val(),
                toAirport: $('#txtTo').val(),
                airlineCode: $('#txtCarrier').val(),
                DepartureDate: $('#dtpDepartureDate').val(),
                ReturnDate: $('#dtpReturnDate').val()
            }
        }).done(function (result) {
            data = JSON.parse(result);
            if (data.Status == 0) {
                DisplayAllOffersV11(data.offerings);
                var jsonReqString = JSON.stringify(data.Request, null, 4);
                var jsonReq = JSON.parse(jsonReqString);

                showJsonRequest(jsonReq);
                showJsonResponse(data.offerings);

                $("#loading").hide();
            }
            else if (data.Status == 1) {
                $("#loading").hide();
                $('#configModal').modal('show')
            }
        }).fail(function (error) {
            alert("todo: error");
            $("#loading").hide();
        });


        // Add event listener for opening and closing details
        $('#ConfigAGrid tbody').on('click', 'td.details-control', function () {
            var tr = $(this).closest('tr');
            var row = tableA.row(tr);

            if (row.child.isShown()) {
                // This row is already open - close it
                row.child.hide();
                tr.removeClass('shown');
            }
            else {
                // Open this row
                d = row.data();
                row.child(format(d)).show();
                tr.addClass('shown');
            }
        });
    }
}

function showJsonRequest(jsonReq) {
    $("#jsonRequest").append(
        "<pre class=\"col-12 snippet language-json \"><code id=\"jsonrequests-code\" class=\"language-json col-12\">"
        + htmlEntities(jsonReq) + "</pre></code> ");
    // Using JQuery
    Prism.highlightElement($('#jsonrequests-code')[0]);

    $("#jsonRequest").show();
}

function showJsonResponse(jsonResp) {
    $("#jsonResponse").append(
        "<pre class=\"col-12 max-vh-50 overflow-auto snippet language-json \"><code id=\"jsonresponse-code\" class=\"language-json col-12\">"
        + htmlEntities(jsonResp) + "</pre></code> ");
    // Using JQuery
    Prism.highlightElement($('#jsonresponse-code')[0]);

    $("#jsonResponse").show();
}

function ValidateInput() {
    $("#txtfrom").removeClass("border-danger");
    $("#txtTo").removeClass("border-danger");
    $("#dtpDepartureDate").removeClass("border-danger");
    $("#txtCarrier").removeClass("border-danger");
    $("#dtpReturnDate").removeClass("border-danger");

    var retValue = true;

    if ($("#txtfrom").val() == "") {
        $("#txtfrom").addClass("border-danger");
        retValue = false;
    }
    if ($("#txtTo").val() == "") {
        $("#txtTo").addClass("border-danger");
        retValue = false;
    }
    if ($("#dtpDepartureDate").val() == "") {
        $("#dtpDepartureDate").addClass("border-danger");
        retValue = false;
    }
    if ($("#txtCarrier").val() == "") {
        $("#txtCarrier").addClass("border-danger");
        retValue = false;
    }
    if ($("#txtCarrier").val().length != 2) {
        $("#txtCarrier").addClass("border-danger");
        retValue = false;
    }

    if ($("#optnReturn").is(":checked")) {
        if ($("#dtpReturnDate").val() == "") {
            $("#dtpReturnDate").addClass("border-danger");
            retValue = false;
        }
    }
    return retValue;
}

function DisplayAllOffersV11(offerings) {

    results = offerings;
    if (results != null && results != "") {
        $("#Visualize").empty();
        jsonData = JSON.parse(results);
       
        var id = 0;

        var OfferList = new Array();

        if (jsonData != null && jsonData.CatalogProductOfferingsResponse.CatalogProductOfferings.CatalogProductOffering != null) {
            jsonData.CatalogProductOfferingsResponse.CatalogProductOfferings.CatalogProductOffering.forEach(function (loffer) {

                if (loffer.sequence == 1) {


                    var offer;

                    loffer.ProductBrandOptions.forEach(function (item) {
                        var color = random_rgba();
                        offer = new FFOffers();

                        offer.OfferId = id;
                        var OfferDetails = new Array();
                        item.ProductBrandOffering.forEach(function (poffer) {
                            //console.log(poffer.Product[0].productRef);
                            var details = getBrandDetails(poffer, jsonData.CatalogProductOfferingsResponse.ReferenceList);

                            if (details.TotalPrice == null) {
                                details.TotalPrice = poffer.Price.TotalPrice;
                                details.Currency = poffer.Price.CurrencyCode.value;
                                details.OfferSource = "NDC";
                            }
                            //find all return flights
                            details.returnflights = new Array();
                            getAllReturnFlights(details.returnflights, poffer.CombinabilityCode, jsonData.CatalogProductOfferingsResponse);
                            details.OfferColor = color;
                            details.Sequence = loffer.sequence;
                            OfferDetails.push(details);
                        })

                        offer.OfferDetails = OfferDetails;
                        OfferList.push(offer);

                        id = id + 1;
                    })
                }
            })
        }

        body = drawCards(OfferList);
       
        $("#Visualize").append(body);
        bindRadioButtonsEvents();
    }
    else {
        $("#Visualize").empty();
    }
}

function drawCards(OfferList) {
    body = "";
    OfferList.forEach(function (offer) {
        body += '<div class = "card-deck m-1 col-12">'
        offer.OfferDetails.forEach(function (OfferDetails) {
            let Currency = OfferDetails.Currency;
            let TotalPrice = OfferDetails.TotalPrice;
            let OfferColor = OfferDetails.OfferColor;
            let tierLevel = OfferDetails.tierLevel;
            let source = OfferDetails.OfferSource;
            var guid = createGuid();
            body += `<div id="card-${guid}" class="card" style="background-color:${OfferColor}"') >`;
            body += `<div class = "card-topper card-img-top"></div><div class="card-body"><div class="card-title">`;
            if ($("#optnOneWay").is(':checked')) {
                body += `<input id="rbOut${guid}" class="pin" type="radio">`;
            }
            body += `<h2> ${Currency} ${TotalPrice} </h2></div>`;
            body += `<h5 class = "card-subtitle mb-2 text-muted"> ${tierLevel}</h5>
                            <h6><ul style="list-style-type:none;padding:0px;margin:0px;"> Source:${source}</h6> `;

            OfferDetails.flights.forEach(function (flight) {
                let Carrier = flight.Carrier;
                let FlightNumber = flight.FlightNumber;
                let Origin = flight.Origin;
                let DepDate = flight.DepDate;
                let DepTime = flight.DepTime;
                let Destination = flight.Destination;
                let ArrivalDate = flight.ArrivalDate;
                let ArrivalTime = flight.ArrivalTime;
                let ClassofService = flight.ClassofService;
                body += `<li style="list-style:none"> <i class="fas fa-plane-departure"></i> 
                                <img src=${logoLink + Carrier}.gif> ${Carrier}${FlightNumber} RBD:${ClassofService}<br \>
                                <ul><li>${Origin} ${DepDate} ${DepTime}  </li> 
                                <li>${Destination} ${ArrivalDate} ${ArrivalTime}</li></ul></li>`;
            });

            if (OfferDetails.returnflights.length == 0) {
                body += `<input id=selected${guid} style=display:none data-flights=${JSON.stringify(OfferDetails.flights)} >`
                //body += `<button type="button" class="btn btn-secondary btn-sm" onclick=ExecuteAjaxAirPrice(` + JSON.stringify(OfferDetails.flights)+`) > Send Airprice Request</button><br\>`;
            }

            body += `<div class="accordion" id="ReturnFlights${guid}">`
            var returnOptionIndex = 0;


            OfferDetails.returnflights.forEach(function (rflight) {

                for (let index = 0; index < rflight.length; index++) {
                    const segment = rflight[index];
                    let Carrier = segment.Carrier;
                    let FlightNumber = segment.FlightNumber;
                    let Origin = segment.Origin;
                    let DepDate = segment.DepDate;
                    let DepTime = segment.DepTime;
                    let Destination = segment.Destination;
                    let ArrivalDate = segment.ArrivalDate;
                    let ArrivalTime = segment.ArrivalTime;
                    let ClassofService = segment.ClassofService;
                    var uid = guid + "-" + returnOptionIndex;
                    var selectedflight = JSON.stringify(OfferDetails.flights) + `,` + JSON.stringify(rflight);

                    body += `<div class="card">
                                    <div class="card-header">
                                      <h5 class="mb-0">
                                        <button class="btn btn-link" type="button"
                                            data-toggle="collapse" data-target="#A${uid}"
                                            aria-expanded="true" aria-controls="A${uid}">
                                         ${rflight[index].Carrier}${rflight[index].FlightNumber}
                                        </button>
                                      </h5>
                                    </div>
                                    <div id=A${uid} class="collapse" data-parent="#ReturnFlights${guid}">
                                        <li style="list-style:none">
                                            <i class="fas fa-plane-arrival"></i>
                                                <input id="rbIn${uid}" name="rbIn${uid}"  class="pin" type="radio" ') >
                                                <img src="${logoLink + Carrier}.gif"> ${Carrier}${FlightNumber} 
                                                        RBD:${ClassofService} <br \>
                                                    <ul><li>${Origin}${DepDate} ${DepTime}   </li>
                                                    <li>${Destination} ${ArrivalDate} ${ArrivalTime}</li></ul>
                                        </li>
                                        <input id=selected${uid} style=display:none data-flights=${JSON.stringify(OfferDetails.flights)} data-returnflights=${JSON.stringify(rflight)} >                                        
                                    </div>
                                   </div>`;
                }

                returnOptionIndex++;
            });

            body += `</div>`;
            body += `</ul></div></div>`;
        });
        body += `</div>`;
    });
    return body;
}

function ExecuteAjaxAirPrice(segmts, returnSegments) {
    
    ShowModal();

    $.ajax({
        url: "./Home/ExecuteAirPrice",
        data: {
            segments: JSON.stringify(segmts),
            returnSegments: JSON.stringify(returnSegments)
        }
    }).done(function (responseData) {
        var res = JSON.parse(responseData);
        $("#loadingXML").hide();
        if (res.Status == 1) //error
        {
           
        }
        else if (res.Status == 0)//success
        {

        }

        $("#xmlRequest").append(
            "<pre class=\"col-12 snippet language-xml \"><code id=\"xmlrequest-code\" class=\"language-xml col-12\">"
            + htmlEntities(res.Request) + "</pre></code > ");

        $("#xmlResponse").append(
            "<pre class=\"col-12 max-vh-50 overflow-auto snippet language-xml \"><code id=\"xmlresponse-code\" class=\"language-xml col-12\">"
            + htmlEntities(res.offerings) + "</pre></code > ");

        // Using JQuery
        Prism.highlightElement($('#xmlrequest-code')[0]);
        Prism.highlightElement($('#xmlresponse-code')[0]);

        $('#AirPriceDetails').modal('handleUpdate');
    });  
}

function ShowModal() {
    $("#loadingXML").show();
    $("#xmlRequest").empty();
    $("#xmlResponse").empty();
    $('#AirPriceDetails').modal('show');   
}

function createGuid() {
    function s4() {
        return Math.floor((1 + Math.random()) * 0x10000).toString(16).substring(1);
    }
    return s4() + s4() + '-' + s4();
}

function getBrandDetails(ProductOffer, Reference) {
    var ProductDetails = new resultDetails();
    ProductDetails.Type = ProductOffer["@type"];
    if (ProductOffer.BestCombinablePrice != null) {
        ProductDetails.TotalPrice = ProductOffer.BestCombinablePrice.TotalPrice;
        ProductDetails.Currency = ProductOffer.BestCombinablePrice.CurrencyCode.value;
        ProductDetails.OfferSource = "GDS";
    }


    ProductDetails.BrandRef = ProductOffer.Brand.BrandRef;
    ProductDetails.tierLevel = getBrandDetailsAsString(ProductOffer.Brand.BrandRef, Reference);
    ProductDetails.flights = getProductsDetails(ProductOffer.Product, Reference);
    ProductDetails.Carrier = getCarrierProductsDetailsAsString(ProductOffer.Product, Reference);

    return ProductDetails;
}

function getProductsDetails(products, reference) {

    var details;
    var refOption = null;
    reference.forEach(function (refOptionLoop) {
        if (refOptionLoop["@type"] == "ReferenceListProduct") {
            refOption = refOptionLoop;
        }
    })


    if (refOption != null) {
        refOption.Product.forEach(function (refProduct) {
            products.forEach(function (SearchProduct) {
                if (refProduct.id == SearchProduct.productRef) {
                    details = getFlightDetails(refProduct, reference);
                }
            })
        })
    }

    return details;
}

function getFlightDetails(refProduct, reference) {
    var flights = new Array();
    var refOption = null;
    flightSegment = refProduct.FlightSegment;

    reference.forEach(function (refOptionLoop) {
        if (refOptionLoop["@type"] == "ReferenceListFlight") {
            refOption = refOptionLoop;
        }
    })


    flightSegment.forEach(function (segment) {
        refOption.Flight.forEach(function (refFlight) {
            if (refFlight.id == segment.Flight.FlightRef) {
                l = segment.sequence;
                var flight = new FlightDetails();
                flight.Carrier = refFlight.carrier;
                flight.FlightNumber = refFlight.number;
                flight.Origin = refFlight.Departure.location;
                flight.DepDate = refFlight.Departure.date.substring(5, refFlight.Departure.date.length);
                flight.DepTime = refFlight.Departure.time.substring(0, refFlight.Departure.time.length - 3);
                flight.Destination = refFlight.Arrival.location;
                flight.ArrivalDate = refFlight.Arrival.date.substring(5, refFlight.Arrival.date.length);
                flight.ArrivalTime = refFlight.Arrival.time.substring(0, refFlight.Arrival.time.length - 3);
                flight.ClassofService = getFlightProductDetails(refProduct, l);
                flights.push(flight);
            }
        })
    })

    return flights;
}

function random_rgba() {
    var o = Math.floor, r = Math.random, s = (75);
    return 'rgba(' + (o((r() * s)) + 170) + ',' + (o((r() * s)) + 170) + ',' + (o((r() * s)) + 170) + ',' + r().toFixed(1) + ')';
}

function getBrandDetailsAsString(brandRef, reference) {
    var BrandDetails = "";
    reference.forEach(function (refOption) {
        if (refOption["@type"] == "ReferenceListBrand") {

            if (refOption.Brand != null)
                refOption.Brand.forEach(function (brand) {
                    if (brand.id == brandRef) {
                        BrandDetails = brand.name + " Tier " + brand.tier;
                    }
                })
        }
    })

    return BrandDetails;
}

function getProductsDetailsAsString(products, reference) {
    var details = "";
    var refOption = null;
    reference.forEach(function (refOptionLoop) {
        if (refOptionLoop["@type"] == "ReferenceListProduct") {
            refOption = refOptionLoop;
        }
    })

    if (refOption != null) {
        refOption.Product.forEach(function (refProduct) {
            products.forEach(function (SearchProduct) {
                if (refProduct.id == SearchProduct.productRef) {
                    details = "Flight Details:<br />" + getFlightDetails(refProduct, reference);
                }
            })
        })
    }

    return details;
}

function getCarrierProductsDetailsAsString(products, reference) {
    var carrier = "";
    var refOption = null;
    reference.forEach(function (refOptionLoop) {
        if (refOptionLoop["@type"] == "ReferenceListProduct") {
            refOption = refOptionLoop;
        }
    })

    if (refOption != null) {
        refOption.Product.forEach(function (refProduct) {
            products.forEach(function (SearchProduct) {
                if (refProduct.id == SearchProduct.productRef) {
                    carrier = getFlightCarrier(refProduct.FlightSegment, reference);
                }
            })
        })
    }

    return carrier;
}

function getAllReturnFlights(returnflights, combinabilitycode, root) {
    listofOffers = root.CatalogProductOfferings.CatalogProductOffering;
    listofOffers.forEach(function (lofferReturn) {
        if (lofferReturn.sequence != 1) {
            lofferReturn.ProductBrandOptions.forEach(function (item) {
                item.ProductBrandOffering.forEach(function (poffer) {
                    if (poffer.CombinabilityCode[0] == combinabilitycode) {

                        var flight = getProductsDetails(poffer.Product, root.ReferenceList);

                        returnflights.push(flight);
                    }
                })
            })
        }
    })

}

function getFlightProductDetails(refProduct, l) {
    var details = "";
    for (i = 0; i < refProduct.PassengerFlight.length; i++) {
        for (j = 0; j < refProduct.PassengerFlight[i].FlightProduct.length; j++) {
            for (k = 0; k < refProduct.PassengerFlight[i].FlightProduct[j].segmentSequence.length; k++)
                if (refProduct.PassengerFlight[i].FlightProduct[j].segmentSequence[k] == l)
                    details += refProduct.PassengerFlight[i].FlightProduct[j].classOfService;
        }
    }

    return details;
}

function getFlightCarrier(flightSegment, reference) {
    var details = "";
    var refOption = null;
    reference.forEach(function (refOptionLoop) {
        if (refOptionLoop["@type"] == "ReferenceListFlight") {
            refOption = refOptionLoop;
        }
    })

    flightSegment.forEach(function (segment) {
        refOption.Flight.forEach(function (refFlight) {
            if (refFlight.id == segment.Flight.FlightRef) {
                details = refFlight.carrier;
            }
        })
    })
    return details;
}

function htmlEntities(str) {
    return String(str).replace(/&/g, '&amp;').replace(/</g, '&lt;').replace(/>/g, '&gt;').replace(/"/g, '&quot;');
}

function loadAirPriceResults() {
    var selectedSegmts = $("#SelectedFlights").data(`selectedflights`);
    var selectedReturnSegmts = $("#SelectedFlights").data('selectedReturnflights');

    if (selectedSegmts != "") {
        ExecuteAjaxAirPrice(selectedSegmts, selectedReturnSegmts);
    }
}
