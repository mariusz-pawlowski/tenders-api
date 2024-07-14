﻿namespace Tenders.Api.Tests.Mock
{
    public static class MockResponse
    {
        public static string TendersApiResponse =
            @"
{
""page_count"": 5917,
""page_number"": 1,
""page_size"": 100,
""total"": 591637,
""data"": [
{
""id"": ""586940"",
""date"": ""2023-05-03"",
""title"": ""Dostawa odczynników i testów. Część 1-5"",
""category"": ""supplies"",
""description"": ""Przedmiotem zamówienia jest: dostawa odczynników i testów w projekcie pt.: „Wdrożenie innowacyjnych elementów technologicznych w procesie wylęgu kaczek w celu ograniczenia zagrożeń mikrobiologicznych i poprawy jakości zdrowotnej i dobrostanu lężonych piskląt” z podziałem na części:\nCzęść nr 1: VA2 grupa 1a odczynniki do badań molekularnych\nCzęść nr 2: VA2 grupa 1b odczynniki do badań molekularnych – startery\nCzęść nr 3: VA2 grupa 2 odczynniki do elektroforezy\nCzęść nr 4: VA2 grupa 3 testy lekoop"",
""sid"": ""award:171348"",
""awarded_value"": ""3690.00"",
""awarded_currency"": ""PLN"",
""awarded_value_eur"": ""805.41"",
""purchaser"": {
""id"": ""27006"",
""sid"": null,
""name"": null
},
""type"": {
""id"": ""procedura-otwarta"",
""name"": ""Procedura otwarta"",
""slug"": ""procedura-otwarta""
},
""awarded"": [
{
""date"": ""2023-04-28"",
""value_for_two"": 3690,
""value_for_two_eur"": 805.41,
""suppliers"": [
{
""name"": ""BioMaxima S.A."",
""id"": 88,
""slug"": ""biomaxima-s-a""
}
],
""value_min"": ""0.00"",
""value_for_three"": 3690,
""offers_count_status"": ""only_one"",
""value_for_one_eur"": 805.41,
""count"": ""1"",
""value_for_one"": 3690,
""value_for_three_eur"": 805.41,
""suppliers_id"": ""88"",
""value_eur"": 805.41,
""value_max"": ""0.00"",
""offers_count"": [
1
],
""suppliers_name"": ""BioMaxima S.A."",
""value"": ""3690.00"",
""value_estimated"": ""4941.39"",
""offers_count_data"": {
""1"": {
""value_eur"": 805.41,
""count"": ""1"",
""value"": ""3690.00""
}
}
}
]
},
{
""id"": ""586948"",
""date"": ""2023-05-03"",
""title"": ""Dostawa licencji IBM wraz z 12 miesięcznym wsparciem technicznym producenta"",
""category"": ""supplies"",
""description"": ""1. Przedmiotem zamówienia jest dostawa licencji wraz z zapewnieniem 12 miesięcznego wsparcia technicznego Producenta dla:\n1.1. IBM Db2 Standard Edition Cartridge for IBM Cloud Pak for Data Virtual Processor Core License + SW Subscription &amp; Support 12 Months “lub równoważnym” – 60 sztuk;\n1.2. IBM Db2 Advanced Edition AU Option for Non-Production Environments Authorized User License + SW Subscription &amp; Support 12 Months “lub równoważnym” – 8 sztuk;\n1.3. IBM WebSphere Hybrid Edition Virtual"",
""sid"": ""award:171361"",
""awarded_value"": ""2817192.00"",
""awarded_currency"": ""PLN"",
""awarded_value_eur"": ""611701.66"",
""purchaser"": {
""id"": ""27317"",
""sid"": null,
""name"": null
},
""type"": {
""id"": ""procedura-otwarta"",
""name"": ""Procedura otwarta"",
""slug"": ""procedura-otwarta""
},
""awarded"": [
{
""date"": ""2023-04-24"",
""value_for_two"": 2817192,
""value_for_two_eur"": 611701.66,
""suppliers"": [
{
""name"": ""Techsource Sp. z o.o. (Lider Konsorcjum)"",
""id"": 28414,
""slug"": ""techsource-sp-z-o-o-lider-konsorcjum""
},
{
""name"": ""Decsoft S.A. (Konsorcjant)"",
""id"": 28415,
""slug"": ""decsoft-s-a-konsorcjant""
}
],
""value_min"": ""0.00"",
""value_for_three"": 2817192,
""value_for_one_eur"": 0,
""count"": ""1"",
""value_for_one"": 0,
""value_for_three_eur"": 611701.66,
""suppliers_id"": ""28414,28415"",
""value_eur"": 611701.66,
""value_max"": ""0.00"",
""offers_count"": [
2
],
""suppliers_name"": ""Techsource Sp. z o.o. (Lider Konsorcjum) Decsoft S.A. (Konsorcjant)"",
""value"": ""2817192.00"",
""value_estimated"": ""3080739.34"",
""offers_count_data"": {
""2"": {
""value_eur"": 611701.66,
""count"": ""1"",
""value"": ""2817192.00""
}
}
}
]
},
{
""id"": ""585088"",
""date"": ""2022-11-23"",
""deadline_date"": ""2022-12-08"",
""deadline_length_days"": ""15"",
""deadline_length_hours"": ""362"",
""title"": ""Dostawa sprzętu medycznego dla potrzeb Uzdrowiska Goczałkowice - Zdrój Sp. z o.o. z siedzibą w Goczałkowicach - Zdroju"",
""category"": ""supplies"",
""description"": ""W zakres zamówienia wchodzi kolumna wolnostojąca do progresywnego treningu oporowego dla rehabilitacji pourazowej – 1 szt."",
""sid"": ""info:166659"",
""awarded_value"": ""125915.52"",
""awarded_currency"": ""PLN"",
""awarded_value_eur"": ""26679.84"",
""purchaser"": {
""id"": ""29445"",
""sid"": null,
""name"": null
},
""type"": {
""id"": ""art-275-pkt-2-ustawy"",
""name"": ""art. 275 pkt 2 ustawy"",
""slug"": ""art-275-pkt-2-ustawy""
},
""indicators"": [
""low_value_awarded"",
""high_value_awarded""
],
""awarded"": [
{
""date"": ""2023-01-26"",
""value_for_two"": 70356,
""value_for_two_eur"": 14907.51,
""suppliers"": [
{
""name"": ""HAS-MED Sp. z o.o."",
""id"": 1325,
""slug"": ""has-med-sp-z-o-o""
}
],
""value_min"": ""116482.80"",
""value_for_three"": 80540.4,
""offers_count_status"": ""contains_only_one"",
""value_for_one_eur"": 14907.51,
""count"": ""5"",
""value_for_one"": 70356,
""value_for_three_eur"": 17065.45,
""suppliers_id"": ""1325"",
""value_eur"": 24681.17,
""value_max"": ""136441.20"",
""offers_count"": [
1,
3,
4
],
""suppliers_name"": ""HAS-MED Sp. z o.o."",
""value"": ""116482.80"",
""value_estimated"": ""119209.26"",
""offers_count_data"": {
""1"": {
""value_eur"": 14907.51,
""count"": ""2"",
""value"": ""70356.00""
},
""3"": {
""value_eur"": 2157.94,
""count"": ""2"",
""value"": ""10184.40""
},
""4"": {
""value_eur"": 7615.72,
""count"": ""1"",
""value"": ""35942.40""
}
}
},
{
""date"": ""2023-01-26"",
""value_for_two"": 503.28,
""value_for_two_eur"": 106.64,
""suppliers"": [
{
""name"": ""ZARYS International Group Sp. z o.o. Sp. K."",
""id"": 63,
""slug"": ""zarys-international-group-sp-z-o-o-sp-k""
}
],
""value_min"": ""503.28"",
""value_for_three"": 503.28,
""offers_count_status"": ""only_one"",
""value_for_one_eur"": 106.64,
""count"": ""1"",
""value_for_one"": 503.28,
""value_for_three_eur"": 106.64,
""suppliers_id"": ""63"",
""value_eur"": 106.64,
""value_max"": ""503.28"",
""offers_count"": [
1
],
""suppliers_name"": ""ZARYS International Group Sp. z o.o. Sp. K."",
""value"": ""503.28"",
""value_estimated"": ""1562.00"",
""offers_count_data"": {
""1"": {
""value_eur"": 106.64,
""count"": ""1"",
""value"": ""503.28""
}
}
},
{
""date"": ""2023-01-26"",
""value_for_two"": 8929.44,
""value_for_two_eur"": 1892.03,
""suppliers"": [
{
""name"": ""F.H.U. Euro-Medical Maciej Świda"",
""id"": 8480,
""slug"": ""f-h-u-euro-medical-maciej-swida""
}
],
""value_min"": ""8929.44"",
""value_for_three"": 8929.44,
""value_for_one_eur"": 0,
""count"": ""1"",
""value_for_one"": 0,
""value_for_three_eur"": 1892.03,
""suppliers_id"": ""8480"",
""value_eur"": 1892.03,
""value_max"": ""9072.00"",
""offers_count"": [
2
],
""suppliers_name"": ""F.H.U. Euro-Medical Maciej Świda"",
""value"": ""8929.44"",
""value_estimated"": ""8635.00"",
""offers_count_data"": {
""2"": {
""value_eur"": 1892.03,
""count"": ""1"",
""value"": ""8929.44""
}
}
}
]
},
{
""id"": ""583899"",
""date"": ""2022-11-16"",
""deadline_date"": ""2022-11-24"",
""deadline_length_days"": ""8"",
""deadline_length_hours"": ""196"",
""title"": ""Zakup wyposażenia do Centrum Opiekuńczo Mieszkalnego w Kętrzynie przy ul. Sikorskiego 46 (3)."",
""category"": ""supplies"",
""description"": ""Dostawa wyposażenia kuchennego i sprzętu AGD.Zamówienie obejmuje m.in.: talerze, kubki, szklanki, patelnie, sztućce, garnki, akcesoria kuchenne, mikrofalówki, termosy stalowe, podgrzewacze, kociołki elektryczne, lodówka, czajniki, itp.Szczegółowy opis zamówienia znajduje się w Załączniku nr 1a dla Części 1."",
""sid"": ""info:162944"",
""awarded_value"": ""118796.66"",
""awarded_currency"": ""PLN"",
""awarded_value_eur"": ""25272.55"",
""purchaser"": {
""id"": ""24952"",
""sid"": null,
""name"": null
},
""type"": {
""id"": ""art-275-pkt-1-ustawy"",
""name"": ""art. 275 pkt 1 ustawy"",
""slug"": ""art-275-pkt-1-ustawy""
},
""awarded"": [
{
""date"": ""2023-01-22"",
""value_for_two"": 0,
""value_for_two_eur"": 0,
""suppliers"": [
{
""name"": ""DRZEWIARZ BIS SP. Z O.O."",
""id"": 17403,
""slug"": ""drzewiarz-bis-sp-z-o-o""
}
],
""value_min"": ""102039.57"",
""value_for_three"": 0,
""value_for_one_eur"": 0,
""count"": ""1"",
""value_for_one"": 0,
""offers_declined"": [
3
],
""value_for_three_eur"": 0,
""suppliers_id"": ""17403"",
""value_eur"": 21664.45,
""value_max"": ""198276.00"",
""offers_count"": [
7
],
""suppliers_name"": ""DRZEWIARZ BIS SP. Z O.O."",
""value"": ""102039.57"",
""value_estimated"": ""105691.06"",
""offers_count_data"": {
""7"": {
""value_eur"": 21664.45,
""count"": ""1"",
""value"": ""102039.57""
}
}
},
{
""date"": ""2022-12-22"",
""value_for_two"": 0,
""value_for_two_eur"": 0,
""suppliers"": [
{
""name"": ""PH ENERGIA S.C."",
""id"": 2540,
""slug"": ""ph-energia-s-c""
}
],
""value_min"": ""16757.09"",
""value_for_three"": 0,
""value_for_one_eur"": 0,
""count"": ""1"",
""value_for_one"": 0,
""offers_declined"": [
2
],
""value_for_three_eur"": 0,
""suppliers_id"": ""2540"",
""value_eur"": 3608.1,
""value_max"": ""34988.58"",
""offers_count"": [
7
],
""suppliers_name"": ""PH ENERGIA S.C."",
""value"": ""16757.09"",
""value_estimated"": ""32520.33"",
""offers_count_data"": {
""7"": {
""value_eur"": 3608.1,
""count"": ""1"",
""value"": ""16757.09""
}
}
}
]
},
{
""id"": ""584049"",
""date"": ""2022-04-21"",
""deadline_date"": ""2022-04-29"",
""deadline_length_days"": ""8"",
""deadline_length_hours"": ""193"",
""title"": ""Dostawa artykułów żywnościowych do stołówki szkolnej od maja do grudnia 2022r ."",
""category"": ""supplies"",
""description"": ""Zakup i dostawa artykułów ogólnospożywczych ( wykaz ilościowy załącznik nr 1 SWZ )"",
""sid"": ""info:163664"",
""awarded_value"": ""398743.79"",
""awarded_currency"": ""PLN"",
""awarded_value_eur"": ""85121.42"",
""purchaser"": {
""id"": ""34495"",
""sid"": null,
""name"": null
},
""type"": {
""id"": ""art-275-pkt-1-ustawy"",
""name"": ""art. 275 pkt 1 ustawy"",
""slug"": ""art-275-pkt-1-ustawy""
},
""awarded"": [
{
""date"": ""2022-12-31"",
""value_for_two"": 13526.8,
""value_for_two_eur"": 2889.85,
""suppliers"": [
{
""name"": ""F.H.U. \""MEGA\"" MAREK GAJ"",
""id"": 28185,
""slug"": ""f-h-u-mega-marek-gaj""
}
],
""value_min"": ""13526.80"",
""value_for_three"": 13526.8,
""offers_count_status"": ""only_one"",
""value_for_one_eur"": 2889.85,
""count"": ""1"",
""value_for_one"": 13526.8,
""value_for_three_eur"": 2889.85,
""suppliers_id"": ""28185"",
""value_eur"": 2889.85,
""value_max"": ""13526.80"",
""offers_count"": [
1
],
""suppliers_name"": ""F.H.U. \""MEGA\"" MAREK GAJ"",
""value"": ""13526.80"",
""value_estimated"": ""13525.80"",
""offers_count_data"": {
""1"": {
""value_eur"": 2889.85,
""count"": ""1"",
""value"": ""13526.80""
}
}
},
{
""date"": ""2022-12-31"",
""value_for_two"": 102462.2,
""value_for_two_eur"": 21889.89,
""suppliers"": [
{
""name"": ""F.H. \""MARKUS\"" MAREK KRUPA"",
""id"": 28186,
""slug"": ""f-h-markus-marek-krupa""
}
],
""value_min"": ""102462.20"",
""value_for_three"": 102462.2,
""offers_count_status"": ""only_one"",
""value_for_one_eur"": 21889.89,
""count"": ""2"",
""value_for_one"": 102462.2,
""value_for_three_eur"": 21889.89,
""suppliers_id"": ""28186"",
""value_eur"": 21889.89,
""value_max"": ""102462.20"",
""offers_count"": [
1
],
""suppliers_name"": ""F.H. \""MARKUS\"" MAREK KRUPA"",
""value"": ""102462.20"",
""value_estimated"": ""102462.20"",
""offers_count_data"": {
""1"": {
""value_eur"": 21889.89,
""count"": ""2"",
""value"": ""102462.20""
}
}
},
{
""date"": ""2022-12-31"",
""value_for_two"": 81342.1,
""value_for_two_eur"": 17377.82,
""suppliers"": [
{
""name"": ""SPÓLDZIELNIA MLECZARSKA W WIEPRZU"",
""id"": 28187,
""slug"": ""spoldzielnia-mleczarska-w-wieprzu""
}
],
""value_min"": ""81342.10"",
""value_for_three"": 81342.1,
""value_for_one_eur"": 0,
""count"": ""1"",
""value_for_one"": 0,
""value_for_three_eur"": 17377.82,
""suppliers_id"": ""28187"",
""value_eur"": 17377.82,
""value_max"": ""91171.00"",
""offers_count"": [
2
],
""suppliers_name"": ""SPÓLDZIELNIA MLECZARSKA W WIEPRZU"",
""value"": ""81342.10"",
""value_estimated"": ""77427.00"",
""offers_count_data"": {
""2"": {
""value_eur"": 17377.82,
""count"": ""1"",
""value"": ""81342.10""
}
}
},
{
""date"": ""2022-12-31"",
""value_for_two"": 44335.6,
""value_for_two_eur"": 9471.8,
""suppliers"": [
{
""name"": ""PIEKARNIA CUKIERNIA MAGDALENKA"",
""id"": 28188,
""slug"": ""piekarnia-cukiernia-magdalenka""
}
],
""value_min"": ""44335.60"",
""value_for_three"": 44335.6,
""offers_count_status"": ""only_one"",
""value_for_one_eur"": 9471.8,
""count"": ""1"",
""value_for_one"": 44335.6,
""value_for_three_eur"": 9471.8,
""suppliers_id"": ""28188"",
""value_eur"": 9471.8,
""value_max"": ""44335.60"",
""offers_count"": [
1
],
""suppliers_name"": ""PIEKARNIA CUKIERNIA MAGDALENKA"",
""value"": ""44335.60"",
""value_estimated"": ""44335.60"",
""offers_count_data"": {
""1"": {
""value_eur"": 9471.8,
""count"": ""1"",
""value"": ""44335.60""
}
}
},
{
""date"": ""2022-05-11"",
""value_for_two"": 32416.99,
""value_for_two_eur"": 6960.17,
""suppliers"": [
{
""name"": ""F.H. \""MARKUS\"" MAREK KRUPA"",
""id"": 28186,
""slug"": ""f-h-markus-marek-krupa""
}
],
""value_min"": ""32416.99"",
""value_for_three"": 32416.99,
""value_for_one_eur"": 0,
""count"": ""1"",
""value_for_one"": 0,
""value_for_three_eur"": 6960.17,
""suppliers_id"": ""28186"",
""value_eur"": 6960.17,
""value_max"": ""33444.00"",
""offers_count"": [
2
],
""suppliers_name"": ""F.H. \""MARKUS\"" MAREK KRUPA"",
""value"": ""32416.99"",
""value_estimated"": ""32416.99"",
""offers_count_data"": {
""2"": {
""value_eur"": 6960.17,
""count"": ""1"",
""value"": ""32416.99""
}
}
},
{
""date"": ""2022-05-09"",
""value_for_two"": 124660.1,
""value_for_two_eur"": 26531.89,
""suppliers"": [
{
""name"": ""F.H.U. \""MEGA\"" MAREK GAJ"",
""id"": 28185,
""slug"": ""f-h-u-mega-marek-gaj""
}
],
""value_min"": ""124660.10"",
""value_for_three"": 124660.1,
""offers_count_status"": ""only_one"",
""value_for_one_eur"": 26531.89,
""count"": ""2"",
""value_for_one"": 124660.1,
""value_for_three_eur"": 26531.89,
""suppliers_id"": ""28185"",
""value_eur"": 26531.89,
""value_max"": ""124660.10"",
""offers_count"": [
1
],
""suppliers_name"": ""F.H.U. \""MEGA\"" MAREK GAJ"",
""value"": ""124660.10"",
""value_estimated"": ""124660.10"",
""offers_count_data"": {
""1"": {
""value_eur"": 26531.89,
""count"": ""2"",
""value"": ""124660.10""
}
}
}
]
},
{
""id"": ""587527"",
""date"": ""2022-11-09"",
""deadline_date"": ""2022-11-17"",
""deadline_length_days"": ""7"",
""deadline_length_hours"": ""186"",
""title"": ""Zimowe utrzymanie dróg w sezonie zimowym 2022/2023 (II postępowanie)"",
""category"": ""services"",
""description"": ""1. Część 1 (zadanie I) - zimowe utrzymanie dróg gminnych : Tropie i Roztoka Brzeziny.2. Przedmiot zamówienia obejmuje usługę zimowego utrzymania dróg (odśnieżanie i usuwania śliskości) w miejscowościach: Tropie i Roztoka Brzeziny o łącznej długości 34,38 km. 3. Szczegółowy zakres wykonania usługi określone został w następujących w załącznikach do SWZ: a. Załącznik Nr 4a - Zasady zimowego utrzymania dróg gminnychb. Załącznik nr 4c – wykaz dróg gminnych przewidzianych do zimowego utrzymaniac. Załą"",
""sid"": ""info:172802"",
""awarded_value"": ""685010.97"",
""awarded_currency"": ""PLN"",
""awarded_value_eur"": ""146186.17"",
""purchaser"": {
""id"": ""1895"",
""sid"": null,
""name"": null
},
""type"": {
""id"": ""art-275-pkt-2-ustawy"",
""name"": ""art. 275 pkt 2 ustawy"",
""slug"": ""art-275-pkt-2-ustawy""
},
""awarded"": [
{
""date"": ""2022-12-21"",
""value_for_two"": 34080.3,
""value_for_two_eur"": 7303.18,
""suppliers"": [
{
""name"": ""Greenpoint Utrzymanie Zieleni Paulina Stawiarska"",
""id"": 28444,
""slug"": ""greenpoint-utrzymanie-zieleni-paulina-stawiarska""
}
],
""value_min"": ""34080.30"",
""value_for_three"": 34080.3,
""value_for_one_eur"": 0,
""count"": ""1"",
""value_for_one"": 0,
""value_for_three_eur"": 7303.18,
""suppliers_id"": ""28444"",
""value_eur"": 7303.18,
""value_max"": ""34290.00"",
""offers_count"": [
2
],
""suppliers_name"": ""Greenpoint Utrzymanie Zieleni Paulina Stawiarska"",
""value"": ""34080.30"",
""value_estimated"": ""42508.33"",
""offers_count_data"": {
""2"": {
""value_eur"": 7303.18,
""count"": ""1"",
""value"": ""34080.30""
}
}
},
{
""date"": ""2022-12-09"",
""value_for_two"": 170951,
""value_for_two_eur"": 36474.22,
""suppliers"": [
{
""name"": ""FIRMA HANDLOWO-USŁUGOWA FEDKO SPÓŁKA JAWNA"",
""id"": 12852,
""slug"": ""firma-handlowo-uslugowa-fedko-spolka-jawna""
}
],
""value_min"": ""170951.00"",
""value_for_three"": 170951,
""offers_count_status"": ""only_one"",
""value_for_one_eur"": 36474.22,
""count"": ""2"",
""value_for_one"": 170951,
""value_for_three_eur"": 36474.22,
""suppliers_id"": ""12852"",
""value_eur"": 36474.22,
""value_max"": ""170951.00"",
""offers_count"": [
1
],
""suppliers_name"": ""FIRMA HANDLOWO-USŁUGOWA FEDKO SPÓŁKA JAWNA"",
""value"": ""170951.00"",
""value_estimated"": ""200910.19"",
""offers_count_data"": {
""1"": {
""value_eur"": 36474.22,
""count"": ""2"",
""value"": ""170951.00""
}
}
},
{
""date"": ""2022-12-09"",
""value_for_two"": 128750,
""value_for_two_eur"": 27470.18,
""suppliers"": [
{
""name"": ""Usługi Sprzętowe-Utrzymanie Dróg-Wywóz Nieczystości Wiesław Wolak"",
""id"": 12862,
""slug"": ""uslugi-sprzetowe-utrzymanie-drog-wywoz-nieczystosci-wieslaw-wolak""
}
],
""value_min"": ""128750.00"",
""value_for_three"": 128750,
""offers_count_status"": ""only_one"",
""value_for_one_eur"": 27470.18,
""count"": ""1"",
""value_for_one"": 128750,
""value_for_three_eur"": 27470.18,
""suppliers_id"": ""12862"",
""value_eur"": 27470.18,
""value_max"": ""128750.00"",
""offers_count"": [
1
],
""suppliers_name"": ""Usługi Sprzętowe-Utrzymanie Dróg-Wywóz Nieczystości Wiesław Wolak"",
""value"": ""128750.00"",
""value_estimated"": ""159505.00"",
""offers_count_data"": {
""1"": {
""value_eur"": 27470.18,
""count"": ""1"",
""value"": ""128750.00""
}
}
},
{
""date"": ""2022-12-09"",
""value_for_two"": 204112,
""value_for_two_eur"": 43549.47,
""suppliers"": [
{
""name"": ""Zakład Usługowo Produkcyjny KAM-BET Krzysztof Rolka"",
""id"": 26779,
""slug"": ""zaklad-uslugowo-produkcyjny-kam-bet-krzysztof-rolka""
}
],
""value_min"": ""204112.00"",
""value_for_three"": 204112,
""offers_count_status"": ""only_one"",
""value_for_one_eur"": 43549.47,
""count"": ""2"",
""value_for_one"": 204112,
""value_for_three_eur"": 43549.47,
""suppliers_id"": ""26779"",
""value_eur"": 43549.47,
""value_max"": ""204112.00"",
""offers_count"": [
1
],
""suppliers_name"": ""Zakład Usługowo Produkcyjny KAM-BET Krzysztof Rolka"",
""value"": ""204112.00"",
""value_estimated"": ""252885.00"",
""offers_count_data"": {
""1"": {
""value_eur"": 43549.47,
""count"": ""2"",
""value"": ""204112.00""
}
}
},
{
""date"": ""2022-12-09"",
""value_for_two"": 94830,
""value_for_two_eur"": 20232.99,
""suppliers"": [
{
""name"": ""Zakład Usługowo-Transportowy \""TURS-KOP\"" Damian Turski"",
""id"": 28443,
""slug"": ""zaklad-uslugowo-transportowy-turs-kop-damian-turski""
}
],
""value_min"": ""94830.00"",
""value_for_three"": 94830,
""offers_count_status"": ""only_one"",
""value_for_one_eur"": 20232.99,
""count"": ""1"",
""value_for_one"": 94830,
""value_for_three_eur"": 20232.99,
""suppliers_id"": ""28443"",
""value_eur"": 20232.99,
""value_max"": ""94830.00"",
""offers_count"": [
1
],
""suppliers_name"": ""Zakład Usługowo-Transportowy \""TURS-KOP\"" Damian Turski"",
""value"": ""94830.00"",
""value_estimated"": ""117508.33"",
""offers_count_data"": {
""1"": {
""value_eur"": 20232.99,
""count"": ""1"",
""value"": ""94830.00""
}
}
},
{
""date"": ""2022-12-09"",
""value_for_two"": 52287.67,
""value_for_two_eur"": 11156.13,
""suppliers"": [
{
""name"": ""Greenpoint Utrzymanie Zieleni Paulina Stawiarska"",
""id"": 28444,
""slug"": ""greenpoint-utrzymanie-zieleni-paulina-stawiarska""
}
],
""value_min"": ""52287.64"",
""value_for_three"": 52287.67,
""value_for_one_eur"": 0,
""count"": ""1"",
""value_for_one"": 0,
""value_for_three_eur"": 11156.13,
""suppliers_id"": ""28444"",
""value_eur"": 11156.13,
""value_max"": ""52610.00"",
""offers_count"": [
2
],
""suppliers_name"": ""Greenpoint Utrzymanie Zieleni Paulina Stawiarska"",
""value"": ""52287.67"",
""value_estimated"": ""65213.33"",
""offers_count_data"": {
""2"": {
""value_eur"": 11156.13,
""count"": ""1"",
""value"": ""52287.67""
}
}
}
]
},
{
""id"": ""585093"",
""date"": ""2022-10-25"",
""deadline_date"": ""2022-11-04"",
""deadline_length_days"": ""9"",
""deadline_length_hours"": ""238"",
""title"": ""Sukcesywna dostawa pasty do powlekania"",
""category"": ""supplies"",
""description"": ""3.1. Przedmiotem zamówienia jest sukcesywna dostawa pasty do powlekania w ilości 20 000 kg. Wodna dyspersja niejonowych wypełniaczy i polimerów o parametrach:3.1.1. pH 7,5 ÷ 8,53.1.2. gęstość 20° C 0,9 ÷ 1,1 g/cm33.1.3. Zamawiający wymaga system zachowania jakości lub świadectwo jakości dostawy.3.2. Wspólny Słownik Zamówień CPV24.50.00.00.-9 Tworzywa sztuczne w formach podstawowych3.3. Zamawiający informuje, że przedmiot zamówienia nie został podzielony na części. Wobec powyższego Zamawiający ni"",
""sid"": ""info:166676"",
""awarded_value"": ""87870.00"",
""awarded_currency"": ""PLN"",
""awarded_value_eur"": ""18739.60"",
""purchaser"": {
""id"": ""33821"",
""sid"": null,
""name"": null
},
""type"": {
""id"": ""art-275-pkt-1-ustawy"",
""name"": ""art. 275 pkt 1 ustawy"",
""slug"": ""art-275-pkt-1-ustawy""
},
""awarded"": [
{
""date"": ""2022-12-15"",
""value_for_two"": 87870,
""value_for_two_eur"": 18739.6,
""suppliers"": [
{
""name"": ""HSH Chemie Sp. z o.o."",
""id"": 28343,
""slug"": ""hsh-chemie-sp-z-o-o""
}
],
""value_min"": ""0.00"",
""value_for_three"": 87870,
""offers_count_status"": ""only_one"",
""value_for_one_eur"": 18739.6,
""count"": ""1"",
""value_for_one"": 87870,
""value_for_three_eur"": 18739.6,
""suppliers_id"": ""28343"",
""value_eur"": 18739.6,
""value_max"": ""0.00"",
""offers_count"": [
1
],
""suppliers_name"": ""HSH Chemie Sp. z o.o."",
""value"": ""87870.00"",
""value_estimated"": null,
""offers_count_data"": {
""1"": {
""value_eur"": 18739.6,
""count"": ""1"",
""value"": ""87870.00""
}
}
}
]
},
{
""id"": ""583014"",
""date"": ""2022-11-16"",
""deadline_date"": ""2022-11-25"",
""deadline_length_days"": ""9"",
""deadline_length_hours"": ""216"",
""title"": ""ŚWIADCZENIE USŁUGI OCHRONY OSÓB, MIENIA I OBIEKTÓW PROKURATURY REGIONALNEJ W GDAŃSKU"",
""category"": ""services"",
""description"": ""1. Przedmiotem zamówienia jest „ŚWIADCZENIE USŁUGI OCHRONY OSÓB, MIENIA I OBIEKTÓW PROKURATURY REGIONALNEJ W GDAŃSKU”.2 Wykonawca zobowiązany będzie realizować przedmiot zamówienia zgodnie z ustawą z dnia 22 sierpnia 1997 r. o ochronie osób i mienia (tekst jednolity Dz.U. z 2021r. poz. 1995 t.j.).3. Szczegółowy opis przedmiotu zamówienia zawiera załącznik nr 7.1 do SWZ pn. OPIS PRZEDMIOTU ZAMÓWIENIA.4. Wykonawca jest zobowiązany zrealizować zamówienie na zasadach i warunkach opisanych we wzorze "",
""sid"": ""info:159844"",
""awarded_value"": ""565123.84"",
""awarded_currency"": ""PLN"",
""awarded_value_eur"": ""120727.16"",
""purchaser"": {
""id"": ""10616"",
""sid"": null,
""name"": null
},
""type"": {
""id"": ""art-275-pkt-1-ustawy"",
""name"": ""art. 275 pkt 1 ustawy"",
""slug"": ""art-275-pkt-1-ustawy""
},
""awarded"": [
{
""date"": ""2022-12-14"",
""value_for_two"": 0,
""value_for_two_eur"": 0,
""suppliers"": [
{
""name"": ""Igielski Ochrona Igielpol Krzysztof Igielski ul. , NIP 8361234019"",
""id"": 27801,
""slug"": ""igielski-ochrona-igielpol-krzysztof-igielski-ul-nip-8361234019""
}
],
""value_min"": ""565123.84"",
""value_for_three"": 0,
""value_for_one_eur"": 0,
""count"": ""1"",
""value_for_one"": 0,
""value_for_three_eur"": 0,
""suppliers_id"": ""27801"",
""value_eur"": 120727.16,
""value_max"": ""890931.04"",
""offers_count"": [
5
],
""suppliers_name"": ""Igielski Ochrona Igielpol Krzysztof Igielski ul. , NIP 8361234019"",
""value"": ""565123.84"",
""value_estimated"": null,
""offers_count_data"": {
""5"": {
""value_eur"": 120727.16,
""count"": ""1"",
""value"": ""565123.84""
}
}
}
]
},
{
""id"": ""589216"",
""date"": ""2022-11-22"",
""deadline_date"": ""2022-11-30"",
""deadline_length_days"": ""7"",
""deadline_length_hours"": ""188"",
""title"": ""Sukcesywne dostawy oleju opałowego lekkiego wraz z transportem w ilości do 120 m3 dla Zespołu Szkół Centrum Kształcenia Rolniczego w Sypniewie"",
""category"": ""supplies"",
""description"": ""Przedmiotem zamówienia są Sukcesywne dostawy oleju opałowego lekkiego wraz z transportem dla Zespołu Szkół Centrum Kształcenia Rolniczego w Sypniewie w ilości do 120 m3.Olej opałowy lekki musi spełniać wymagania Polskiej Normy PN-C-96024 „Przetwory naftowe. Oleje opałowe” w zakresie oleju opałowego lekkiego gatunku L-1 oraz wymagania Rozporządzenia Ministra Energii z dnia 1 grudnia 2016 r. w sprawie wymagań jakościowych dotyczących zawartości siarki dla olejów oraz rodzajów instalacji i warunków"",
""sid"": ""info:177021"",
""awarded_value"": ""750842.68"",
""awarded_currency"": ""PLN"",
""awarded_value_eur"": ""159923.89"",
""purchaser"": {
""id"": ""33555"",
""sid"": null,
""name"": null
},
""type"": {
""id"": ""art-275-pkt-1-ustawy"",
""name"": ""art. 275 pkt 1 ustawy"",
""slug"": ""art-275-pkt-1-ustawy""
},
""awarded"": [
{
""date"": ""2022-12-05"",
""value_for_two"": 750842.68,
""value_for_two_eur"": 159923.89,
""suppliers"": [
{
""name"": ""Spółka Jawna T&J Tyrakowski, Jachnik"",
""id"": 20255,
""slug"": ""spolka-jawna-t-j-tyrakowski-jachnik""
}
],
""value_min"": ""750842.68"",
""value_for_three"": 750842.68,
""offers_count_status"": ""only_one"",
""value_for_one_eur"": 159923.89,
""count"": ""1"",
""value_for_one"": 750842.68,
""value_for_three_eur"": 159923.89,
""suppliers_id"": ""20255"",
""value_eur"": 159923.89,
""value_max"": ""750842.68"",
""offers_count"": [
1
],
""suppliers_name"": ""Spółka Jawna T&J Tyrakowski, Jachnik"",
""value"": ""750842.68"",
""value_estimated"": null,
""offers_count_data"": {
""1"": {
""value_eur"": 159923.89,
""count"": ""1"",
""value"": ""750842.68""
}
}
}
]
},
{
""id"": ""584849"",
""date"": ""2022-09-09"",
""deadline_date"": ""2022-09-26"",
""deadline_length_days"": ""17"",
""deadline_length_hours"": ""412"",
""title"": ""„Remont ulicy Władysława Jagiełły i Stefana Batorego w Kętrzynie w ramach projektu „Zakup taboru niskoemisyjnego wraz z poprawą infrastruktury transportowej miasta Kętrzyn.”"",
""category"": ""constructions"",
""description"": ""1. Przedmiotem zamówienia jest robota budowlana polegająca na jezdni ulicy Władysława Jagiełły i Stefana Batorego w Kętrzynie w oparciu o dokumentację budowlano-wykonawczą, stanowiącą Załącznik nr 5 do SWZ.2. Przedmiot zamówienia obejmuje:a) roboty rozbiórkowe,b) roboty ziemne,c) wymiana krawężników drogowych,d) remont jezdni wraz z częściowym remontem podbudów,e) remont chodników,f) remont zjazdów,g) remont zatok parkingowych,h) odtworzenie oznakowania poziomego w technologii grubowarstwowej,i)"",
""sid"": ""info:165989"",
""awarded_value"": ""5554667.85"",
""awarded_currency"": ""PLN"",
""awarded_value_eur"": ""1183102.84"",
""purchaser"": {
""id"": ""24952"",
""sid"": null,
""name"": null
},
""type"": {
""id"": ""art-275-pkt-1-ustawy"",
""name"": ""art. 275 pkt 1 ustawy"",
""slug"": ""art-275-pkt-1-ustawy""
},
""awarded"": [
{
""date"": ""2022-12-05"",
""value_for_two"": 0,
""value_for_two_eur"": 0,
""suppliers"": [
{
""name"": ""STRABAG Sp. z o.o."",
""id"": 1257,
""slug"": ""strabag-sp-z-o-o""
}
],
""value_min"": ""5554667.85"",
""value_for_three"": 0,
""value_for_one_eur"": 0,
""count"": ""1"",
""value_for_one"": 0,
""value_for_three_eur"": 0,
""suppliers_id"": ""1257"",
""value_eur"": 1183102.84,
""value_max"": ""7661473.20"",
""offers_count"": [
4
],
""suppliers_name"": ""STRABAG Sp. z o.o."",
""value"": ""5554667.85"",
""value_estimated"": null,
""offers_count_data"": {
""4"": {
""value_eur"": 1183102.84,
""count"": ""1"",
""value"": ""5554667.85""
}
}
}
]
},
{
""id"": ""588785"",
""date"": ""2022-10-04"",
""deadline_date"": ""2022-10-19"",
""deadline_length_days"": ""15"",
""deadline_length_hours"": ""364"",
""title"": ""Przebudowa dróg powiatowych w miejscowościach popegeerowskich na terenie Gminy Miejsce Piastowe i Gminy Dukla"",
""category"": ""constructions"",
""description"": ""1. Przedmiotem zamówienia jest przebudowa dróg powiatowych w miejscowościach popegeerowskich na terenie Gminy Miejsce Piastowe i Gminy Dukla2. W ramach remontu przewiduje się m.in. :Przebudowa dróg powiatowych w Gminie M. Piastowe: • nr 1976R Krosno – Rogi -Iwonicz polegająca na budowie chodnika z kostki brukowej w m. Głowienka w km 4+140 do 4+564,• nr 1975R Miejsce Piastowe – Wrocanka Górna w miejscowości Miejsce Piastowe polegająca nawykonaniu poszerzenia odcinka drogi wraz ze wzmocnieniem naw"",
""sid"": ""info:175911"",
""awarded_value"": ""1957321.28"",
""awarded_currency"": ""PLN"",
""awarded_value_eur"": ""416159.14"",
""purchaser"": {
""id"": ""23228"",
""sid"": null,
""name"": null
},
""type"": {
""id"": ""art-275-pkt-2-ustawy"",
""name"": ""art. 275 pkt 2 ustawy"",
""slug"": ""art-275-pkt-2-ustawy""
},
""awarded"": [
{
""date"": ""2022-11-23"",
""value_for_two"": 0,
""value_for_two_eur"": 0,
""suppliers"": [
{
""name"": ""DROGBUD GOLCOWA PRO SPÓŁKA Z OGRANICZONĄ ODPOWIEDZIALNOŚCIĄ"",
""id"": 16892,
""slug"": ""drogbud-golcowa-pro-spolka-z-ograniczona-odpowiedzialnoscia""
}
],
""value_min"": ""1957321.28"",
""value_for_three"": 0,
""value_for_one_eur"": 0,
""count"": ""1"",
""value_for_one"": 0,
""value_for_three_eur"": 0,
""suppliers_id"": ""16892"",
""value_eur"": 416159.14,
""value_max"": ""2978990.90"",
""offers_count"": [
5
],
""suppliers_name"": ""DROGBUD GOLCOWA PRO SPÓŁKA Z OGRANICZONĄ ODPOWIEDZIALNOŚCIĄ"",
""value"": ""1957321.28"",
""value_estimated"": null,
""offers_count_data"": {
""5"": {
""value_eur"": 416159.14,
""count"": ""1"",
""value"": ""1957321.28""
}
}
}
]
},
{
""id"": ""589444"",
""date"": ""2022-10-14"",
""deadline_date"": ""2022-10-24"",
""deadline_length_days"": ""9"",
""deadline_length_hours"": ""235"",
""title"": ""Dostawa i montaż urządzeń zabawowych na place zabaw w Sopocie"",
""category"": ""supplies"",
""description"": ""Część I - Dostawa i montaż urządzeń zabawowych na place zabaw przy ul. 23 Marca w Sopocie"",
""sid"": ""info:177620"",
""awarded_value"": ""236589.57"",
""awarded_currency"": ""PLN"",
""awarded_value_eur"": ""50246.35"",
""purchaser"": {
""id"": ""23262"",
""sid"": null,
""name"": null
},
""type"": {
""id"": ""art-275-pkt-2-ustawy"",
""name"": ""art. 275 pkt 2 ustawy"",
""slug"": ""art-275-pkt-2-ustawy""
},
""awarded"": [
{
""date"": ""2022-11-21"",
""value_for_two"": 64292.4,
""value_for_two_eur"": 13657.44,
""suppliers"": [
{
""name"": ""Simba Group Sp. z o. o."",
""id"": 27185,
""slug"": ""simba-group-sp-z-o-o""
}
],
""value_min"": ""64292.40"",
""value_for_three"": 64292.4,
""offers_count_status"": ""only_one"",
""value_for_one_eur"": 13657.44,
""count"": ""1"",
""value_for_one"": 64292.4,
""value_for_three_eur"": 13657.44,
""suppliers_id"": ""27185"",
""value_eur"": 13657.44,
""value_max"": ""64292.40"",
""offers_count"": [
1
],
""suppliers_name"": ""Simba Group Sp. z o. o."",
""value"": ""64292.40"",
""value_estimated"": ""64292.40"",
""offers_count_data"": {
""1"": {
""value_eur"": 13657.44,
""count"": ""1"",
""value"": ""64292.40""
}
}
},
{
""date"": ""2022-11-03"",
""value_for_two"": 172297.17,
""value_for_two_eur"": 36588.91,
""suppliers"": [
{
""name"": ""lars laj polska sp. z o.o."",
""id"": 28530,
""slug"": ""lars-laj-polska-sp-z-o-o""
}
],
""value_min"": ""172297.17"",
""value_for_three"": 172297.17,
""offers_count_status"": ""only_one"",
""value_for_one_eur"": 36588.91,
""count"": ""1"",
""value_for_one"": 172297.17,
""value_for_three_eur"": 36588.91,
""suppliers_id"": ""28530"",
""value_eur"": 36588.91,
""value_max"": ""172297.17"",
""offers_count"": [
1
],
""suppliers_name"": ""lars laj polska sp. z o.o."",
""value"": ""172297.17"",
""value_estimated"": ""234466.29"",
""offers_count_data"": {
""1"": {
""value_eur"": 36588.91,
""count"": ""1"",
""value"": ""172297.17""
}
}
}
]
},
{
""id"": ""584499"",
""date"": ""2022-07-19"",
""deadline_date"": ""2022-08-23"",
""deadline_length_days"": ""34"",
""deadline_length_hours"": ""839"",
""title"": ""Budowa krytej pływalni w Skarszewach"",
""category"": ""constructions"",
""description"": ""Budowa krytej pływalni w Skarszewach, obejmujące zaprojektowanie wszystkich elementów przedsięwzięcia – projekt wykonawczy oraz wykonanie robót budowlanych w zakresie budowy kompleksowego obiektu basenowego wraz z kompletnych zapleczem technicznym, socjalnym oraz pełną infrastrukturą instalacyjną i elementami niezbędnymi do prawidłowego funkcjonowania, budową miejskiej sieci ciepłowniczej od ul. Kamierowskiej (wykonanie projektu budowlanego wraz z uzyskaniem pozwolenia na budowę) dla zasilenia b"",
""sid"": ""info:165104"",
""awarded_value"": ""27499000.00"",
""awarded_currency"": ""PLN"",
""awarded_value_eur"": ""5846745.90"",
""purchaser"": {
""id"": ""34542"",
""sid"": null,
""name"": null
},
""type"": {
""id"": ""art-275-pkt-1-ustawy"",
""name"": ""art. 275 pkt 1 ustawy"",
""slug"": ""art-275-pkt-1-ustawy""
},
""awarded"": [
{
""date"": ""2022-11-18"",
""value_for_two"": 0,
""value_for_two_eur"": 0,
""suppliers"": [
{
""name"": ""B&W Usługi Ogólnobudowlane Bożena Dzidkowska"",
""id"": 643,
""slug"": ""b-w-uslugi-ogolnobudowlane-bozena-dzidkowska""
}
],
""value_min"": ""26700000.00"",
""value_for_three"": 0,
""value_for_one_eur"": 0,
""count"": ""1"",
""value_for_one"": 0,
""offers_declined"": [
2
],
""value_for_three_eur"": 0,
""suppliers_id"": ""643"",
""value_eur"": 5846745.9,
""value_max"": ""30465220.22"",
""offers_count"": [
4
],
""suppliers_name"": ""B&W Usługi Ogólnobudowlane Bożena Dzidkowska"",
""value"": ""27499000.00"",
""value_estimated"": null,
""offers_count_data"": {
""4"": {
""value_eur"": 5846745.9,
""count"": ""1"",
""value"": ""27499000.00""
}
}
}
]
},
{
""id"": ""582009"",
""date"": ""2022-11-03"",
""deadline_date"": ""2022-11-10"",
""deadline_length_days"": ""7"",
""deadline_length_hours"": ""168"",
""title"": ""DOSTAWA MONITORÓW INTERAKTYWNYCH W RAMACH PROJEKTU PODNIESIENIE KOMPETENCJI CYFROWYCH WŚRÓD UCZNIÓW I NAUCZYCIELI WOJEWÓDZTWA PODLASKIEGO"",
""category"": ""supplies"",
""description"": ""Przedmiotem zamówienia jest dostawa 2 monitorów interaktywnych do Szkoły Podstawowej nr 2 im. R. Traugutta w Czarnej Białostockiej. Szczegółowyopis przedmiotu zamówieniazawiera załącznik nr 1 do SWZ."",
""sid"": ""info:157292"",
""awarded_value"": ""15500.00"",
""awarded_currency"": ""PLN"",
""awarded_value_eur"": ""3293.32"",
""purchaser"": {
""id"": ""34042"",
""sid"": null,
""name"": null
},
""type"": {
""id"": ""art-275-pkt-1-ustawy"",
""name"": ""art. 275 pkt 1 ustawy"",
""slug"": ""art-275-pkt-1-ustawy""
},
""awarded"": [
{
""date"": ""2022-11-16"",
""value_for_two"": 0,
""value_for_two_eur"": 0,
""suppliers"": [
{
""name"": ""Dreamtec Sp. z o.o."",
""id"": 18620,
""slug"": ""dreamtec-sp-z-o-o""
}
],
""value_min"": ""15500.00"",
""value_for_three"": 0,
""value_for_one_eur"": 0,
""count"": ""1"",
""value_for_one"": 0,
""offers_declined"": [
1
],
""value_for_three_eur"": 0,
""suppliers_id"": ""18620"",
""value_eur"": 3293.32,
""value_max"": ""22080.00"",
""offers_count"": [
7
],
""suppliers_name"": ""Dreamtec Sp. z o.o."",
""value"": ""15500.00"",
""value_estimated"": null,
""offers_count_data"": {
""7"": {
""value_eur"": 3293.32,
""count"": ""1"",
""value"": ""15500.00""
}
}
}
]
},
{
""id"": ""589142"",
""date"": ""2022-10-10"",
""deadline_date"": ""2022-10-18"",
""deadline_length_days"": ""8"",
""deadline_length_hours"": ""200"",
""title"": ""Dostawa infrastruktury hiperkonwergentnej"",
""category"": ""supplies"",
""description"": ""1. Przedmiotem zamówienia jest dostawa, montaż, uruchomienie oraz konfiguracja serwerów (SDW) na warunkach określonych w SWZ – infrastruktura hiperkonwergentna (HCI). Szczegółowy opis przedmiotu zamówienia zawarto w Załączniku nr 1 do SWZ.2. Kod klasyfikacji Wspólnego Słownika Zamówień (CPV): 48820000-2 – Serwery48518000-2 – Pakiety oprogramowania emulującego48620000-0 – Systemy operacyjneIII. Zamawiający dopuszcza składanie ofert równoważnych.IV. Zamawiający nie dopuszcza składania ofert części"",
""sid"": ""info:176808"",
""awarded_value"": ""595001.43"",
""awarded_currency"": ""PLN"",
""awarded_value_eur"": ""126871.39"",
""purchaser"": {
""id"": ""33094"",
""sid"": null,
""name"": null
},
""type"": {
""id"": ""art-275-pkt-1-ustawy"",
""name"": ""art. 275 pkt 1 ustawy"",
""slug"": ""art-275-pkt-1-ustawy""
},
""awarded"": [
{
""date"": ""2022-11-14"",
""value_for_two"": 0,
""value_for_two_eur"": 0,
""suppliers"": [
{
""name"": ""Xcomp Spółka z ograniczoną odpowiedzialnością Sp.k."",
""id"": 25919,
""slug"": ""xcomp-spolka-z-ograniczona-odpowiedzialnoscia-sp-k""
}
],
""value_min"": ""595001.43"",
""value_for_three"": 595001.43,
""value_for_one_eur"": 0,
""count"": ""1"",
""value_for_one"": 0,
""offers_declined"": [
1
],
""value_for_three_eur"": 126871.39,
""suppliers_id"": ""25919"",
""value_eur"": 126871.39,
""value_max"": ""599625.00"",
""offers_count"": [
3
],
""suppliers_name"": ""Xcomp Spółka z ograniczoną odpowiedzialnością Sp.k."",
""value"": ""595001.43"",
""value_estimated"": null,
""offers_count_data"": {
""3"": {
""value_eur"": 126871.39,
""count"": ""1"",
""value"": ""595001.43""
}
}
}
]
},
{
""id"": ""589161"",
""date"": ""2022-09-02"",
""deadline_date"": ""2022-09-13"",
""deadline_length_days"": ""10"",
""deadline_length_hours"": ""261"",
""title"": ""Sukcesywne dostawy produktów żywnościowych do Stołówki Uniwersytetu Warszawskiego"",
""category"": ""supplies"",
""description"": ""1. Przedmiotem zamówienia są sukcesywne dostawy produktów żywnościowych do Stołówki Uniwersytetu Warszawskiego, ul. Krakowskie Przedmieście 26/28 w Warszawie, zwane dalej produktami.2. Szczegółowy opis przedmiotu zamówienia stanowi załącznik nr 1 do Specyfikacji warunków zamówienia (zwanej dalej Specyfikacją lub SWZ)."",
""sid"": ""info:176857"",
""awarded_value"": ""235874.40"",
""awarded_currency"": ""PLN"",
""awarded_value_eur"": ""49310.88"",
""purchaser"": {
""id"": ""188"",
""sid"": null,
""name"": null
},
""type"": {
""id"": ""art-275-pkt-1-ustawy"",
""name"": ""art. 275 pkt 1 ustawy"",
""slug"": ""art-275-pkt-1-ustawy""
},
""awarded"": [
{
""date"": ""2022-11-07"",
""value_for_two"": 54298,
""value_for_two_eur"": 11586.05,
""suppliers"": [
{
""name"": ""Gobarto S.A."",
""id"": 7039,
""slug"": ""gobarto-s-a""
}
],
""value_min"": ""54298.00"",
""value_for_three"": 54298,
""value_for_one_eur"": 0,
""count"": ""2"",
""value_for_one"": 0,
""value_for_three_eur"": 11586.05,
""suppliers_id"": ""7039"",
""value_eur"": 11586.05,
""value_max"": ""87531.80"",
""offers_count"": [
2
],
""suppliers_name"": ""Gobarto S.A."",
""value"": ""54298.00"",
""value_estimated"": ""59097.15"",
""offers_count_data"": {
""2"": {
""value_eur"": 11586.05,
""count"": ""2"",
""value"": ""54298.00""
}
}
},
{
""date"": ""2022-10-28"",
""value_for_two"": 31591,
""value_for_two_eur"": 6682.39,
""suppliers"": [
{
""name"": ""Firma Handlowa Dagr-Bis Spółka Jawna"",
""id"": 28502,
""slug"": ""firma-handlowa-dagr-bis-spolka-jawna""
}
],
""value_min"": ""31591.00"",
""value_for_three"": 31591,
""value_for_one_eur"": 0,
""count"": ""1"",
""value_for_one"": 0,
""value_for_three_eur"": 6682.39,
""suppliers_id"": ""28502"",
""value_eur"": 6682.39,
""value_max"": ""36501.20"",
""offers_count"": [
2
],
""suppliers_name"": ""Firma Handlowa Dagr-Bis Spółka Jawna"",
""value"": ""31591.00"",
""value_estimated"": ""37907.00"",
""offers_count_data"": {
""2"": {
""value_eur"": 6682.39,
""count"": ""1"",
""value"": ""31591.00""
}
}
},
{
""date"": ""2022-10-17"",
""value_for_two"": 41999.99,
""value_for_two_eur"": 8724.01,
""suppliers"": [
{
""name"": ""Hurtownia BB Bożena Bąk"",
""id"": 7047,
""slug"": ""hurtownia-bb-bozena-bak""
}
],
""value_min"": ""41999.99"",
""value_for_three"": 41999.99,
""value_for_one_eur"": 0,
""count"": ""1"",
""value_for_one"": 0,
""value_for_three_eur"": 8724.01,
""suppliers_id"": ""7047"",
""value_eur"": 8724.01,
""value_max"": ""56903.95"",
""offers_count"": [
2
],
""suppliers_name"": ""Hurtownia BB Bożena Bąk"",
""value"": ""41999.99"",
""value_estimated"": ""40925.89"",
""offers_count_data"": {
""2"": {
""value_eur"": 8724.01,
""count"": ""1"",
""value"": ""41999.99""
}
}
},
{
""date"": ""2022-10-12"",
""value_for_two"": 27486.9,
""value_for_two_eur"": 5667.99,
""suppliers"": [
{
""name"": ""Swiat Mrożonek s.c."",
""id"": 26426,
""slug"": ""swiat-mrozonek-s-c""
},
{
""name"": ""Swiat Mrożonek s.c. Iwona Subocz"",
""id"": 28503,
""slug"": ""swiat-mrozonek-s-c-iwona-subocz""
}
],
""value_min"": ""27486.90"",
""value_for_three"": 27486.9,
""offers_count_status"": ""only_one"",
""value_for_one_eur"": 5667.99,
""count"": ""1"",
""value_for_one"": 27486.9,
""value_for_three_eur"": 5667.99,
""suppliers_id"": ""26426,28503"",
""value_eur"": 5667.99,
""value_max"": ""27486.90"",
""offers_count"": [
1
],
""suppliers_name"": ""Swiat Mrożonek s.c. Swiat Mrożonek s.c. Iwona Subocz"",
""value"": ""27486.90"",
""value_estimated"": ""32299.05"",
""offers_count_data"": {
""1"": {
""value_eur"": 5667.99,
""count"": ""1"",
""value"": ""27486.90""
}
}
},
{
""date"": ""2022-10-06"",
""value_for_two"": 11430,
""value_for_two_eur"": 2356.46,
""suppliers"": [
{
""name"": ""Mariusz Jaworski Brawo"",
""id"": 28505,
""slug"": ""mariusz-jaworski-brawo""
}
],
""value_min"": ""11430.00"",
""value_for_three"": 11430,
""value_for_one_eur"": 0,
""count"": ""1"",
""value_for_one"": 0,
""value_for_three_eur"": 2356.46,
""suppliers_id"": ""28505"",
""value_eur"": 2356.46,
""value_max"": ""16200.00"",
""offers_count"": [
2
],
""suppliers_name"": ""Mariusz Jaworski Brawo"",
""value"": ""11430.00"",
""value_estimated"": ""9450.00"",
""offers_count_data"": {
""2"": {
""value_eur"": 2356.46,
""count"": ""1"",
""value"": ""11430.00""
}
}
},
{
""date"": ""2022-10-03"",
""value_for_two"": 60747.11,
""value_for_two_eur"": 12571.84,
""suppliers"": [
{
""name"": ""Gospodarstwo Rolne Grzgorz Ostrowski"",
""id"": 28504,
""slug"": ""gospodarstwo-rolne-grzgorz-ostrowski""
}
],
""value_min"": ""60747.11"",
""value_for_three"": 60747.11,
""offers_count_status"": ""only_one"",
""value_for_one_eur"": 12571.84,
""count"": ""1"",
""value_for_one"": 60747.11,
""value_for_three_eur"": 12571.84,
""suppliers_id"": ""28504"",
""value_eur"": 12571.84,
""value_max"": ""60747.11"",
""offers_count"": [
1
],
""suppliers_name"": ""Gospodarstwo Rolne Grzgorz Ostrowski"",
""value"": ""60747.11"",
""value_estimated"": ""62033.55"",
""offers_count_data"": {
""1"": {
""value_eur"": 12571.84,
""count"": ""1"",
""value"": ""60747.11""
}
}
},
{
""date"": ""2022-10-03"",
""value_for_two"": 8321.4,
""value_for_two_eur"": 1722.14,
""suppliers"": [
{
""name"": ""Mariusz Jaworski Brawo"",
""id"": 28505,
""slug"": ""mariusz-jaworski-brawo""
}
],
""value_min"": ""8321.40"",
""value_for_three"": 8321.4,
""offers_count_status"": ""only_one"",
""value_for_one_eur"": 1722.14,
""count"": ""1"",
""value_for_one"": 8321.4,
""value_for_three_eur"": 1722.14,
""suppliers_id"": ""28505"",
""value_eur"": 1722.14,
""value_max"": ""8321.40"",
""offers_count"": [
1
],
""suppliers_name"": ""Mariusz Jaworski Brawo"",
""value"": ""8321.40"",
""value_estimated"": ""6407.10"",
""offers_count_data"": {
""1"": {
""value_eur"": 1722.14,
""count"": ""1"",
""value"": ""8321.40""
}
}
}
]
},
{
""id"": ""588501"",
""date"": ""2022-05-31"",
""deadline_date"": ""2022-06-17"",
""deadline_length_days"": ""16"",
""deadline_length_hours"": ""405"",
""title"": ""Rozbudowa drogi powiatowej Nr 2533W Chudek – Gleba – Kierzek – Zawady od km 9+770,00 do km 10+100,00"",
""category"": ""constructions"",
""description"": ""1. Przedmiotem zamówienia jest: Rozbudowa drogi powiatowej Nr 2533W Chudek – Gleba – Kierzek – Zawady od km 9+770,00 do km 10+100,00Zamówienie obejmuje:A. ROBOTY PRZYGOTOWAWCZE 1) Roboty pomiarowe przy linowych robotach ziemnych, (drogi) w terenie równinnym nadzór geodezyjny nad wykonawstwem i opracowanie operatu geodezyjnego powykonawczego.2) Mechaniczne ścinanie drzew z karczowaniem pni, średnice drzew 16-25cm z wywozem dłużyc na plac OD-M w Kadzidle.3) Mechaniczne ścinanie drzew z karczowanie"",
""sid"": ""info:175253"",
""awarded_value"": ""872061.71"",
""awarded_currency"": ""PLN"",
""awarded_value_eur"": ""184465.72"",
""purchaser"": {
""id"": ""23815"",
""sid"": null,
""name"": null
},
""type"": {
""id"": ""art-275-pkt-1-ustawy"",
""name"": ""art. 275 pkt 1 ustawy"",
""slug"": ""art-275-pkt-1-ustawy""
},
""awarded"": [
{
""date"": ""2022-10-28"",
""value_for_two"": 872061.71,
""value_for_two_eur"": 184465.72,
""suppliers"": [
{
""name"": ""Przedsiębiorstwo Robót Drogowo-Mostowych \""Ostrada\"" Sp. z o.o."",
""id"": 3626,
""slug"": ""przedsiebiorstwo-robot-drogowo-mostowych-ostrada-sp-z-o-o""
}
],
""value_min"": ""872061.71"",
""value_for_three"": 872061.71,
""value_for_one_eur"": 0,
""count"": ""1"",
""value_for_one"": 0,
""value_for_three_eur"": 184465.72,
""suppliers_id"": ""3626"",
""value_eur"": 184465.72,
""value_max"": ""959400.00"",
""offers_count"": [
2
],
""suppliers_name"": ""Przedsiębiorstwo Robót Drogowo-Mostowych \""Ostrada\"" Sp. z o.o."",
""value"": ""872061.71"",
""value_estimated"": null,
""offers_count_data"": {
""2"": {
""value_eur"": 184465.72,
""count"": ""1"",
""value"": ""872061.71""
}
}
}
]
},
{
""id"": ""584026"",
""date"": ""2022-09-22"",
""deadline_date"": ""2022-10-07"",
""deadline_length_days"": ""14"",
""deadline_length_hours"": ""358"",
""title"": ""REMONTY DRÓG LEŚNYCH NA TERENIE NADLEŚNICTWA DALESZYCE"",
""category"": ""constructions"",
""description"": ""1. Przedmiotem zamówienia jest wykonanie remontu drogi leśnej nr 220/144 w leśnictwie Sieraków, Nadleśnictwo Daleszyce. Szczegółowy opis przedmiotu zamówienia, wraz z wymaganiami, sposobem realizacji, technologii, wykonania i odbioru robót zawiera dokumentacja projektowa pn. „Remont drogi leśnej nr 220/144 w leśnictwie Sieraków, Nadleśnictwo Daleszyce” stanowiąca załącznik nr 9.I do SWZ.2.Szczegółowe warunki realizacji zamówienia zostały opisane w projektowanych postanowieniach umowy – załącznik"",
""sid"": ""info:163494"",
""awarded_value"": ""103320.00"",
""awarded_currency"": ""PLN"",
""awarded_value_eur"": ""21729.62"",
""purchaser"": {
""id"": ""24415"",
""sid"": null,
""name"": null
},
""type"": {
""id"": ""art-275-pkt-1-ustawy"",
""name"": ""art. 275 pkt 1 ustawy"",
""slug"": ""art-275-pkt-1-ustawy""
},
""awarded"": [
{
""date"": ""2022-10-26"",
""value_for_two"": 174057.3,
""value_for_two_eur"": 36606.65,
""suppliers"": [],
""value_min"": ""103320.00"",
""value_for_three"": 174057.3,
""offers_count_status"": ""only_one"",
""value_for_one_eur"": 36606.65,
""count"": ""1"",
""value_for_one"": 174057.3,
""value_for_three_eur"": 36606.65,
""suppliers_id"": ""26953"",
""value_eur"": 21729.62,
""value_max"": ""103320.00"",
""offers_count"": [
1
],
""suppliers_name"": """",
""value"": ""103320.00"",
""value_estimated"": ""146370.00"",
""offers_count_data"": {
""1"": {
""value_eur"": 36606.65,
""count"": ""2"",
""value"": ""174057.30""
}
}
}
]
},
{
""id"": ""588179"",
""date"": ""2022-09-28"",
""deadline_date"": ""2022-10-07"",
""deadline_length_days"": ""8"",
""deadline_length_hours"": ""211"",
""title"": ""Zimowym utrzymaniu dróg gminnych i wewnętrznych oraz parkingów na terenie gminy Kołaczyce w sezonie zimowym 2022/2023."",
""category"": ""services"",
""description"": ""1. Zamówienie obejmuje wykonanie usługi polegającej na zimowym utrzymaniu dróg gminnych i wewnętrznych oraz parkingów na terenie gminy Kołaczyce w sezonie zimowym 2022/2023.2. Szczegółowy opis przedmiotu zamówienia zawarty jest w załączniku nr 4 do SWZ.3. Zakres usługi na drogach będących w zarządzie zamawiającego obejmuje:1) Odśnieżanie dróg gminnych ciągnikiem rolniczym z odpowiednim osprzętem przystosowanym do odśnieżania bądź samochodem przystosowanym do odśnieżania - na drogach gminnych nad"",
""sid"": ""info:174417"",
""awarded_value"": ""6461.84"",
""awarded_currency"": ""PLN"",
""awarded_value_eur"": ""1348.80"",
""purchaser"": {
""id"": ""24793"",
""sid"": null,
""name"": null
},
""type"": {
""id"": ""art-275-pkt-1-ustawy"",
""name"": ""art. 275 pkt 1 ustawy"",
""slug"": ""art-275-pkt-1-ustawy""
},
""awarded"": [
{
""date"": ""2022-10-24"",
""value_for_two"": 6461.84,
""value_for_two_eur"": 1348.8,
""suppliers"": [
{
""name"": ""Zakład Go spodarki Komunalnej w Kołaczycach Sp. z o.o."",
""id"": 28476,
""slug"": ""zaklad-go-spodarki-komunalnej-w-kolaczycach-sp-z-o-o""
}
],
""value_min"": ""6461.84"",
""value_for_three"": 6461.84,
""offers_count_status"": ""only_one"",
""value_for_one_eur"": 1348.8,
""count"": ""1"",
""value_for_one"": 6461.84,
""value_for_three_eur"": 1348.8,
""suppliers_id"": ""28476"",
""value_eur"": 1348.8,
""value_max"": ""6461.84"",
""offers_count"": [
1
],
""suppliers_name"": ""Zakład Go spodarki Komunalnej w Kołaczycach Sp. z o.o."",
""value"": ""6461.84"",
""value_estimated"": null,
""offers_count_data"": {
""1"": {
""value_eur"": 1348.8,
""count"": ""1"",
""value"": ""6461.84""
}
}
}
]
},
{
""id"": ""589632"",
""date"": ""2022-08-30"",
""deadline_date"": ""2022-09-14"",
""deadline_length_days"": ""14"",
""deadline_length_hours"": ""356"",
""title"": ""Zaprojektowanie i wykonanie robót budowlanych w ramach zadania pn.: „Dostawa i montaż instalacji fotowoltaicznej o mocy do 50 kWp” w WZOZ z siedzibą w Częstochowie.”"",
""category"": ""constructions"",
""description"": ""1. Przedmiotem zamówienia jest: Zaprojektowanie i wykonanie robót budowlanych w ramach zadania pn.: „Dostawa i montaż instalacji fotowoltaicznej o mocy do 50 kWp” w Wojewódzkim Zakładzie Opieki Zdrowotnej nad Matką, Dzieckiem i Młodzieżą z siedzibą w Częstochowie.” Stan istniejący budynku:Budynek mający cztery kondygnacje naziemne oraz piwnicę użytkową. Budynek funkcjonuje jako obiekt użyteczności publicznej z przeznaczeniem na gabinety lekarskie, zdrowia psychicznego, pracownie, rehabilitację, "",
""sid"": ""info:178103"",
""awarded_value"": ""236775.00"",
""awarded_currency"": ""PLN"",
""awarded_value_eur"": ""49287.05"",
""purchaser"": {
""id"": ""33912"",
""sid"": null,
""name"": null
},
""type"": {
""id"": ""art-275-pkt-1-ustawy"",
""name"": ""art. 275 pkt 1 ustawy"",
""slug"": ""art-275-pkt-1-ustawy""
},
""awarded"": [
{
""date"": ""2022-10-18"",
""value_for_two"": 0,
""value_for_two_eur"": 0,
""suppliers"": [
{
""name"": ""Passive Instal Sp. z o.o."",
""id"": 28541,
""slug"": ""passive-instal-sp-z-o-o""
}
],
""value_min"": ""22900.00"",
""value_for_three"": 0,
""value_for_one_eur"": 0,
""count"": ""1"",
""value_for_one"": 0,
""offers_declined"": [
4
],
""value_for_three_eur"": 0,
""suppliers_id"": ""28541"",
""value_eur"": 49287.05,
""value_max"": ""270600.00"",
""offers_count"": [
7
],
""suppliers_name"": ""Passive Instal Sp. z o.o."",
""value"": ""236775.00"",
""value_estimated"": null,
""offers_count_data"": {
""7"": {
""value_eur"": 49287.05,
""count"": ""1"",
""value"": ""236775.00""
}
}
}
]
},
{
""id"": ""581291"",
""date"": ""2022-08-24"",
""deadline_date"": ""2022-09-16"",
""deadline_length_days"": ""22"",
""deadline_length_hours"": ""551"",
""title"": ""Budowa budynku mieszkalnego wielorodzinnego przy ul. Polnej 16 w Ustce (budynek B-4)"",
""category"": ""constructions"",
""description"": ""1. Przedmiotem zamówienia jest budowa budynku mieszkalnego wielorodzinnego przy ul. Polnej 16 w Ustce (budynek B-4).2. Budynek objęty przedmiotem zamówienia to budynek wielorodzinny, trzyklatkowy, o funkcji mieszkalnej, planowany w ramach osiedla UTBS w Ustce przy ul. Polnej na działce nr 2302/8 na terenie oznaczonym w Miejscowym Planie Zagospodarowanie przestrzennego „Ustka Rozwojowa A” symbolem 1.MW z przeznaczeniem pod zabudowę mieszkaniową wielorodzinną.3. Szczegółowy opis przedmiotu zamówie"",
""sid"": ""info:155504"",
""awarded_value"": ""8950686.28"",
""awarded_currency"": ""PLN"",
""awarded_value_eur"": ""1838300.74"",
""purchaser"": {
""id"": ""25134"",
""sid"": null,
""name"": null
},
""type"": {
""id"": ""art-275-pkt-1-ustawy"",
""name"": ""art. 275 pkt 1 ustawy"",
""slug"": ""art-275-pkt-1-ustawy""
},
""awarded"": [
{
""date"": ""2022-10-11"",
""value_for_two"": 0,
""value_for_two_eur"": 0,
""suppliers"": [
{
""name"": ""EUROPLAST Izabela Rogozińska"",
""id"": 24285,
""slug"": ""europlast-izabela-rogozinska""
}
],
""value_min"": ""8950686.28"",
""value_for_three"": 0,
""value_for_one_eur"": 0,
""count"": ""1"",
""value_for_one"": 0,
""offers_declined"": [
2
],
""value_for_three_eur"": 0,
""suppliers_id"": ""24285"",
""value_eur"": 1838300.74,
""value_max"": ""13991706.06"",
""offers_count"": [
7
],
""suppliers_name"": ""EUROPLAST Izabela Rogozińska"",
""value"": ""8950686.28"",
""value_estimated"": null,
""offers_count_data"": {
""7"": {
""value_eur"": 1838300.74,
""count"": ""1"",
""value"": ""8950686.28""
}
}
}
]
},
{
""id"": ""581699"",
""date"": ""2022-08-12"",
""deadline_date"": ""2022-08-22"",
""deadline_length_days"": ""10"",
""deadline_length_hours"": ""240"",
""title"": ""Dostawa sprzętu dydaktycznego dla Szkoły Podstawowej nr 182 w Łodzi w ramach realizacji projektu „Laboratoria przyszłości”"",
""category"": ""supplies"",
""description"": ""Dostawa sprzętu dydaktycznego dla Szkoły Podstawowej nr 182 w Łodzi w ramach realizacji projektu „Laboratoria przyszłości”"",
""sid"": ""info:156462"",
""awarded_value"": ""62576.00"",
""awarded_currency"": ""PLN"",
""awarded_value_eur"": ""13144.01"",
""purchaser"": {
""id"": ""34152"",
""sid"": null,
""name"": null
},
""type"": {
""id"": ""art-275-pkt-1-ustawy"",
""name"": ""art. 275 pkt 1 ustawy"",
""slug"": ""art-275-pkt-1-ustawy""
},
""indicators"": [
""low_value_awarded"",
""high_value_awarded""
],
""awarded"": [
{
""date"": ""2022-09-26"",
""value_for_two"": 29826,
""value_for_two_eur"": 6264.91,
""suppliers"": [
{
""name"": ""New Life Property Sp. z o.o."",
""id"": 26156,
""slug"": ""new-life-property-sp-z-o-o""
}
],
""value_min"": ""62576.00"",
""value_for_three"": 29826,
""value_for_one_eur"": 0,
""count"": ""2"",
""value_for_one"": 0,
""offers_declined"": [
1
],
""value_for_three_eur"": 6264.91,
""suppliers_id"": ""26156"",
""value_eur"": 13144.01,
""value_max"": ""77108.60"",
""offers_count"": [
2,
4
],
""suppliers_name"": ""New Life Property Sp. z o.o."",
""value"": ""62576.00"",
""value_estimated"": ""48780.00"",
""offers_count_data"": {
""2"": {
""value_eur"": 6264.91,
""count"": ""1"",
""value"": ""29826.00""
},
""4"": {
""value_eur"": 6879.1,
""count"": ""1"",
""value"": ""32750.00""
}
}
}
]
},
{
""id"": ""580850"",
""date"": ""2022-08-22"",
""deadline_date"": ""2022-08-30"",
""deadline_length_days"": ""7"",
""deadline_length_hours"": ""190"",
""title"": ""Dostawa materiałów biurowych i papieru ksero."",
""category"": ""supplies"",
""description"": ""1. Przedmiotem niniejszego zamówienia jest sukcesywna dostawa materiałów biurowych i papieru ksero, zgodnie z zapisami zawartymi w formularzu asortymentowo-cenowym, stanowiącym załącznik nr 2 do SWZPakiet 1 – materiały biurowe"",
""sid"": ""info:154340"",
""awarded_value"": ""448671.46"",
""awarded_currency"": ""PLN"",
""awarded_value_eur"": ""95533.15"",
""purchaser"": {
""id"": ""23041"",
""sid"": null,
""name"": null
},
""type"": {
""id"": ""art-275-pkt-1-ustawy"",
""name"": ""art. 275 pkt 1 ustawy"",
""slug"": ""art-275-pkt-1-ustawy""
},
""awarded"": [
{
""date"": ""2022-09-12"",
""value_for_two"": 164757.94,
""value_for_two_eur"": 35081.01,
""suppliers"": [
{
""name"": ""PAPIRUS sp. j. M. Górecki, A. Nowicki, J. Karyś"",
""id"": 2937,
""slug"": ""papirus-sp-j-m-gorecki-a-nowicki-j-karys""
}
],
""value_min"": ""448671.46"",
""value_for_three"": 448671.46,
""value_for_one_eur"": 0,
""count"": ""2"",
""value_for_one"": 0,
""offers_declined"": [
1
],
""value_for_three_eur"": 95533.15,
""suppliers_id"": ""2937"",
""value_eur"": 95533.15,
""value_max"": ""490141.50"",
""offers_count"": [
2,
3
],
""suppliers_name"": ""PAPIRUS sp. j. M. Górecki, A. Nowicki, J. Karyś"",
""value"": ""448671.46"",
""value_estimated"": ""653940.00"",
""offers_count_data"": {
""2"": {
""value_eur"": 35081.01,
""count"": ""1"",
""value"": ""164757.94""
},
""3"": {
""value_eur"": 60452.15,
""count"": ""1"",
""value"": ""283913.52""
}
}
}
]
},
{
""id"": ""582013"",
""date"": ""2022-07-20"",
""deadline_date"": ""2022-07-28"",
""deadline_length_days"": ""7"",
""deadline_length_hours"": ""184"",
""title"": ""Zawarcie umów ramowych na świadczenie usług transportowych"",
""category"": ""services"",
""description"": ""Przedmiotem zamówienia jest zawarcie umów ramowych z Wykonawcami, którzy świadczyć będą na rzeczZamawiającego obsługę transportową wizyt studyjnych w okresie 12 miesięcy od daty zawarcia umów ramowych, wterminach uzależnionych od potrzeb Zamawiającego."",
""sid"": ""info:157305"",
""awarded_value"": ""347900.00"",
""awarded_currency"": ""PLN"",
""awarded_value_eur"": ""73777.97"",
""purchaser"": {
""id"": ""23835"",
""sid"": null,
""name"": null
},
""type"": {
""id"": ""art-275-pkt-1-ustawy"",
""name"": ""art. 275 pkt 1 ustawy"",
""slug"": ""art-275-pkt-1-ustawy""
},
""awarded"": [
{
""date"": ""2022-09-08"",
""value_for_two"": 347900,
""value_for_two_eur"": 73777.97,
""suppliers"": [
{
""name"": ""ElbaTravel Daniel Drzazga"",
""id"": 27510,
""slug"": ""elbatravel-daniel-drzazga""
}
],
""value_min"": ""347900.00"",
""value_for_three"": 347900,
""value_for_one_eur"": 0,
""count"": ""1"",
""value_for_one"": 0,
""value_for_three_eur"": 73777.97,
""suppliers_id"": ""27510"",
""value_eur"": 73777.97,
""value_max"": ""365900.00"",
""offers_count"": [
2
],
""suppliers_name"": ""ElbaTravel Daniel Drzazga"",
""value"": ""347900.00"",
""value_estimated"": null,
""offers_count_data"": {
""2"": {
""value_eur"": 73777.97,
""count"": ""1"",
""value"": ""347900.00""
}
}
}
]
},
{
""id"": ""581718"",
""date"": ""2022-07-14"",
""deadline_date"": ""2022-07-22"",
""deadline_length_days"": ""7"",
""deadline_length_hours"": ""183"",
""title"": ""Dostawa sprzętu komputerowego dla dzieci z rodzin popegeerowskich w ramach projektu Cyfrowa Gmina - „Wsparcie dzieci z rodzin pegeerowskich w rozwoju cyfrowym – Granty PPGR”"",
""category"": ""supplies"",
""description"": ""1. Przedmiotem zamówienia jest dostawa sprzętu komputerowego:Komputer stacjonarny - 40 sztuk,Komputer przenośny - 134 sztuk,Tablet - 11 sztuk,w ramach realizacji projektu „Cyfrowa Gmina” – granty PPGR finansowanego w ramach Programu Operacyjnego Polska Cyfrowa na lata 2014-2020 Osi Priorytetowej V Rozwój cyfrowy JST oraz wzmocnienie cyfrowej odporności na zagrożenia REACT-EU działania 5.1 Rozwój cyfrowy JST oraz wzmocnienie cyfrowej odporności na zagrożenia dotycząca realizacji projektu grantowe"",
""sid"": ""info:156506"",
""awarded_value"": ""447100.00"",
""awarded_currency"": ""PLN"",
""awarded_value_eur"": ""95040.71"",
""purchaser"": {
""id"": ""23405"",
""sid"": null,
""name"": null
},
""type"": {
""id"": ""art-275-pkt-1-ustawy"",
""name"": ""art. 275 pkt 1 ustawy"",
""slug"": ""art-275-pkt-1-ustawy""
},
""indicators"": [
""declined""
],
""awarded"": [
{
""date"": ""2022-08-16"",
""value_for_two"": 447100,
""value_for_two_eur"": 95040.71,
""suppliers"": [
{
""name"": ""Dreamtec Sp. z o. o."",
""id"": 18620,
""slug"": ""dreamtec-sp-z-o-o""
}
],
""value_min"": ""292299.66"",
""value_for_three"": 447100,
""value_for_one_eur"": 0,
""count"": ""1"",
""value_for_one"": 0,
""offers_declined"": [
1
],
""value_for_three_eur"": 95040.71,
""suppliers_id"": ""18620"",
""value_eur"": 95040.71,
""value_max"": ""447100.00"",
""offers_count"": [
2
],
""suppliers_name"": ""Dreamtec Sp. z o. o."",
""value"": ""447100.00"",
""value_estimated"": null,
""offers_count_data"": {
""2"": {
""value_eur"": 95040.71,
""count"": ""1"",
""value"": ""447100.00""
}
}
}
]
},
{
""id"": ""579782"",
""date"": ""2022-06-28"",
""deadline_date"": ""2022-07-06"",
""deadline_length_days"": ""7"",
""deadline_length_hours"": ""189"",
""title"": ""Opracowanie dokumentacji projektowej przebudowy budynku biblioteki na potrzeby filii NCK w Nowosielcu"",
""category"": ""services"",
""description"": ""1. Przedmiotem postępowania i zamówienia jest: Opracowanie dokumentacji projektowej przebudowy budynku biblioteki na potrzeby filii NCK w Nowosielcu Dokumentacja projektowa będzie obejmować wykonanie:1) Aktualizację mapy do celów projektowych;2) Projektu zagospodarowania terenu;3) Projekt architektoniczno-budowlany; 4) Projektu technicznego, 5) Projektu instalacji sanitarnych: wod - kan, co, wentylacji mechanicznej;6) Projekt instalacji elektrycznej, teletechnicznej - internet; 7) Informacji BIO"",
""sid"": ""info:151611"",
""awarded_value"": ""22755.00"",
""awarded_currency"": ""PLN"",
""awarded_value_eur"": ""4832.75"",
""purchaser"": {
""id"": ""23080"",
""sid"": null,
""name"": null
},
""type"": {
""id"": ""art-275-pkt-1-ustawy"",
""name"": ""art. 275 pkt 1 ustawy"",
""slug"": ""art-275-pkt-1-ustawy""
},
""awarded"": [
{
""date"": ""2022-08-09"",
""value_for_two"": 0,
""value_for_two_eur"": 0,
""suppliers"": [
{
""name"": ""SAN-PROJ Usługi Projektowe Kalamarz Janusz"",
""id"": 26794,
""slug"": ""san-proj-uslugi-projektowe-kalamarz-janusz""
}
],
""value_min"": ""22755.00"",
""value_for_three"": 0,
""value_for_one_eur"": 0,
""count"": ""1"",
""value_for_one"": 0,
""value_for_three_eur"": 0,
""suppliers_id"": ""26794"",
""value_eur"": 4832.75,
""value_max"": ""86100.00"",
""offers_count"": [
5
],
""suppliers_name"": ""SAN-PROJ Usługi Projektowe Kalamarz Janusz"",
""value"": ""22755.00"",
""value_estimated"": null,
""offers_count_data"": {
""5"": {
""value_eur"": 4832.75,
""count"": ""1"",
""value"": ""22755.00""
}
}
}
]
},
{
""id"": ""583692"",
""date"": ""2022-06-10"",
""deadline_date"": ""2022-06-27"",
""deadline_length_days"": ""16"",
""deadline_length_hours"": ""407"",
""title"": ""ZAGOSPODAROWANIE ZABYTKOWEGO DWORKU WRAZZ OTOCZENIEM W MIEJSCOWOŚCI STRASZĘCIN"",
""category"": ""constructions"",
""description"": ""Przebudowa wewnętrznej instalacji wody, kanalizacji sanitarnej i centralnego ogrzewaniaZadanie obejmuje min. przebudowę wewnętrznej instalacji wody zimnej i ciepłej, kanalizacji sanitarnej oraz centralnego ogrzewania w istniejącym budynku zabytkowego dworku w Straszęcinie zlokalizowanego na działce o nr ewid. 684/9 w miejscowości Straszęcin na piętrze oraz poddaszu budynku."",
""sid"": ""info:162176"",
""awarded_value"": ""167665.91"",
""awarded_currency"": ""PLN"",
""awarded_value_eur"": ""35357.64"",
""purchaser"": {
""id"": ""31015"",
""sid"": null,
""name"": null
},
""type"": {
""id"": ""art-275-pkt-1-ustawy"",
""name"": ""art. 275 pkt 1 ustawy"",
""slug"": ""art-275-pkt-1-ustawy""
},
""indicators"": [
""low_value_awarded""
],
""awarded"": [
{
""date"": ""2022-07-26"",
""value_for_two"": 167665.91,
""value_for_two_eur"": 35357.64,
""suppliers"": [
{
""name"": ""ADRES Adam Bieszczad"",
""id"": 28042,
""slug"": ""adres-adam-bieszczad""
}
],
""value_min"": ""167665.91"",
""value_for_three"": 167665.91,
""offers_count_status"": ""only_one"",
""value_for_one_eur"": 35357.64,
""count"": ""1"",
""value_for_one"": 167665.91,
""value_for_three_eur"": 35357.64,
""suppliers_id"": ""28042"",
""value_eur"": 35357.64,
""value_max"": ""167665.91"",
""offers_count"": [
1
],
""suppliers_name"": ""ADRES Adam Bieszczad"",
""value"": ""167665.91"",
""value_estimated"": ""118893.55"",
""offers_count_data"": {
""1"": {
""value_eur"": 35357.64,
""count"": ""1"",
""value"": ""167665.91""
}
}
}
]
},
{
""id"": ""591468"",
""date"": ""2022-07-01"",
""deadline_date"": ""2022-07-11"",
""deadline_length_days"": ""10"",
""deadline_length_hours"": ""241"",
""title"": ""„Zakup i dostawa urządzeń informatycznych z oprogramowaniem oraz usługą szkoleniową w ramach zapewnienia cyberbezpieczeństwa systemów informatycznych Urzędu Miejskiego w Olszynie\"""",
""category"": ""services"",
""description"": ""4.2.1. część 1 zamówienia – „Zakup Serwera głównego i serwera zapasowego wraz z oprogramowaniem do wirtualizacji, kontrolerem domeny oraz backupu”obejmująca:1) zakup, dostawa dwóch serwerów głównego i zapasowego wraz z oprogramowaniem do zarządzania komputerami przy pomocy kontrolera domeny z obsługą wirtualizacji oraz archiwizacji środowisk wirtualnych i danych. Dostawca serwerów i oprogramowania będzie odpowiedzialny również za ich instalację, konfigurację, wdrożenie i szkolenie. Szczegółowy o"",
""sid"": ""info:182902"",
""awarded_value"": ""105288.00"",
""awarded_currency"": ""PLN"",
""awarded_value_eur"": ""22032.56"",
""purchaser"": {
""id"": ""33709"",
""sid"": null,
""name"": null
},
""type"": {
""id"": ""art-275-pkt-1-ustawy"",
""name"": ""art. 275 pkt 1 ustawy"",
""slug"": ""art-275-pkt-1-ustawy""
},
""indicators"": [
""low_value_awarded"",
""high_value_awarded""
],
""awarded"": [
{
""date"": ""2022-07-20"",
""value_for_two"": 89913,
""value_for_two_eur"": 18802.38,
""suppliers"": [
{
""name"": ""PlikCenter Michał Galac"",
""id"": 28630,
""slug"": ""plikcenter-michal-galac""
}
],
""value_min"": ""15375.00"",
""value_for_three"": 89913,
""offers_count_status"": ""only_one"",
""value_for_one_eur"": 18802.38,
""count"": ""3"",
""value_for_one"": 89913,
""value_for_three_eur"": 18802.38,
""suppliers_id"": ""28630"",
""value_eur"": 18802.38,
""value_max"": ""89913.00"",
""offers_count"": [
1
],
""suppliers_name"": ""PlikCenter Michał Galac"",
""value"": ""89913.00"",
""value_estimated"": ""78105.69"",
""offers_count_data"": {
""1"": {
""value_eur"": 18802.38,
""count"": ""3"",
""value"": ""89913.00""
}
}
},
{
""date"": ""2022-07-19"",
""value_for_two"": 15375,
""value_for_two_eur"": 3230.18,
""suppliers"": [
{
""name"": ""TRICELL Piotr Kochański"",
""id"": 24071,
""slug"": ""tricell-piotr-kochanski""
}
],
""value_min"": ""15375.00"",
""value_for_three"": 15375,
""offers_count_status"": ""only_one"",
""value_for_one_eur"": 3230.18,
""count"": ""1"",
""value_for_one"": 15375,
""value_for_three_eur"": 3230.18,
""suppliers_id"": ""24071"",
""value_eur"": 3230.18,
""value_max"": ""15375.00"",
""offers_count"": [
1
],
""suppliers_name"": ""TRICELL Piotr Kochański"",
""value"": ""15375.00"",
""value_estimated"": ""9941.36"",
""offers_count_data"": {
""1"": {
""value_eur"": 3230.18,
""count"": ""1"",
""value"": ""15375.00""
}
}
}
]
},
{
""id"": ""578226"",
""date"": ""2022-06-13"",
""deadline_date"": ""2022-06-23"",
""deadline_length_days"": ""10"",
""deadline_length_hours"": ""240"",
""title"": ""dostawa komponentów do rozbudowy podsystemu pamięci masowej"",
""category"": ""supplies"",
""description"": ""Przedmiotem zamówienia jest dostawa komponentów do rozbudowy podsystemu pamięci masowej. Szczegółowy opis przedmiotu zamówienia i sposobu jego wykonania zawarty jest w projektowanych postanowieniach umowy stanowiących Załącznik nr 4 do SWZ."",
""sid"": ""info:147901"",
""awarded_value"": ""1058977.11"",
""awarded_currency"": ""PLN"",
""awarded_value_eur"": ""222483.53"",
""purchaser"": {
""id"": ""14019"",
""sid"": null,
""name"": null
},
""type"": {
""id"": ""art-275-pkt-1-ustawy"",
""name"": ""art. 275 pkt 1 ustawy"",
""slug"": ""art-275-pkt-1-ustawy""
},
""awarded"": [
{
""date"": ""2022-07-19"",
""value_for_two"": 1058977.11,
""value_for_two_eur"": 222483.53,
""suppliers"": [
{
""name"": ""Clockwise Sp. z o. o."",
""id"": 26387,
""slug"": ""clockwise-sp-z-o-o""
}
],
""value_min"": ""1058977.11"",
""value_for_three"": 1058977.11,
""value_for_one_eur"": 0,
""count"": ""1"",
""value_for_one"": 0,
""value_for_three_eur"": 222483.53,
""suppliers_id"": ""26387"",
""value_eur"": 222483.53,
""value_max"": ""1107000.00"",
""offers_count"": [
2
],
""suppliers_name"": ""Clockwise Sp. z o. o."",
""value"": ""1058977.11"",
""value_estimated"": null,
""offers_count_data"": {
""2"": {
""value_eur"": 222483.53,
""count"": ""1"",
""value"": ""1058977.11""
}
}
}
]
},
{
""id"": ""579716"",
""date"": ""2022-05-04"",
""deadline_date"": ""2022-05-19"",
""deadline_length_days"": ""14"",
""deadline_length_hours"": ""357"",
""title"": ""Przebudowa dróg gminnych w podziale na części"",
""category"": ""constructions"",
""description"": ""Część nr 1. Przebudowa drogi gminnej nr 226061G – BietowoUłożenie nawierzchni z płyt wielootworowych podwójnie zbrojonych z korytowaniem oraz zagęszczeniem pisakiem i kruszywem na długości 110 m."",
""sid"": ""info:151440"",
""awarded_value"": ""361145.99"",
""awarded_currency"": ""PLN"",
""awarded_value_eur"": ""76855.93"",
""purchaser"": {
""id"": ""30103"",
""sid"": null,
""name"": null
},
""type"": {
""id"": ""art-275-pkt-2-ustawy"",
""name"": ""art. 275 pkt 2 ustawy"",
""slug"": ""art-275-pkt-2-ustawy""
},
""awarded"": [
{
""date"": ""2022-06-27"",
""value_for_two"": 168000,
""value_for_two_eur"": 35752.29,
""suppliers"": [
{
""name"": ""GAJLAND Ryszard Landowski"",
""id"": 26781,
""slug"": ""gajland-ryszard-landowski""
}
],
""value_min"": ""168000.00"",
""value_for_three"": 168000,
""value_for_one_eur"": 0,
""count"": ""3"",
""value_for_one"": 0,
""value_for_three_eur"": 35752.29,
""suppliers_id"": ""26781"",
""value_eur"": 35752.29,
""value_max"": ""171024.12"",
""offers_count"": [
2
],
""suppliers_name"": ""GAJLAND Ryszard Landowski"",
""value"": ""168000.00"",
""value_estimated"": ""170466.00"",
""offers_count_data"": {
""2"": {
""value_eur"": 35752.29,
""count"": ""3"",
""value"": ""168000.00""
}
}
},
{
""date"": ""2022-06-27"",
""value_for_two"": 193145.99,
""value_for_two_eur"": 41103.64,
""suppliers"": [
{
""name"": ""Zakład Usługowy \""RATTUSS\"" Sebastian Frischmut"",
""id"": 26782,
""slug"": ""zaklad-uslugowy-rattuss-sebastian-frischmut""
}
],
""value_min"": ""193145.99"",
""value_for_three"": 193145.99,
""value_for_one_eur"": 0,
""count"": ""3"",
""value_for_one"": 0,
""value_for_three_eur"": 41103.64,
""suppliers_id"": ""26782"",
""value_eur"": 41103.64,
""value_max"": ""198735.00"",
""offers_count"": [
2
],
""suppliers_name"": ""Zakład Usługowy \""RATTUSS\"" Sebastian Frischmut"",
""value"": ""193145.99"",
""value_estimated"": ""193145.99"",
""offers_count_data"": {
""2"": {
""value_eur"": 41103.64,
""count"": ""3"",
""value"": ""193145.99""
}
}
}
]
},
{
""id"": ""577218"",
""date"": ""2022-06-03"",
""deadline_date"": ""2022-06-13"",
""deadline_length_days"": ""9"",
""deadline_length_hours"": ""237"",
""title"": ""Dostawa sprzętu II dla realizowanego projektu „eCareMed - eZdrowie w Szpitalu Specjalistycznym Nr 2 w Bytomiu”"",
""category"": ""supplies"",
""description"": ""1. Przedmiotem zamówienia w niniejszym przetargu jest Dostawa sprzętu dla realizowanego projektu „eCareMed - eZdrowie w Szpitalu Specjalistycznym Nr 2 w Bytomiu” w ramach Europejskiego Funduszu Rozwoju Regionalnego. Projekt będzie realizowany w ramach Osi Priorytetowej II Cyfrowe Śląskie, Działanie 2.1 Wsparcie rozwoju cyfrowych usług publicznych Regionalnego Programu Operacyjnego Województwa Śląskiego 2014-2020. Przedmiot zamówienia został podzielony na 1 pakiet. Przez określenie Część należy r"",
""sid"": ""info:145454"",
""awarded_value"": ""53474.25"",
""awarded_currency"": ""PLN"",
""awarded_value_eur"": ""11515.94"",
""purchaser"": {
""id"": ""24136"",
""sid"": null,
""name"": null
},
""type"": {
""id"": ""art-275-pkt-1-ustawy"",
""name"": ""art. 275 pkt 1 ustawy"",
""slug"": ""art-275-pkt-1-ustawy""
},
""awarded"": [
{
""date"": ""2022-06-21"",
""value_for_two"": 53474.25,
""value_for_two_eur"": 11515.94,
""suppliers"": [
{
""name"": ""INET S.C. Artur Czachor, Tomasz Laube"",
""id"": 2758,
""slug"": ""inet-s-c-artur-czachor-tomasz-laube""
}
],
""value_min"": ""53474.25"",
""value_for_three"": 53474.25,
""value_for_one_eur"": 0,
""count"": ""1"",
""value_for_one"": 0,
""value_for_three_eur"": 11515.94,
""suppliers_id"": ""2758"",
""value_eur"": 11515.94,
""value_max"": ""127674.00"",
""offers_count"": [
2
],
""suppliers_name"": ""INET S.C. Artur Czachor, Tomasz Laube"",
""value"": ""53474.25"",
""value_estimated"": null,
""offers_count_data"": {
""2"": {
""value_eur"": 11515.94,
""count"": ""1"",
""value"": ""53474.25""
}
}
}
]
},
{
""id"": ""577039"",
""date"": ""2022-03-10"",
""deadline_date"": ""2022-03-25"",
""deadline_length_days"": ""14"",
""deadline_length_hours"": ""350"",
""title"": ""Budowa Centrum Przesiadkowego w Świerklańcu przy ulicy Parkowej"",
""category"": ""constructions"",
""description"": ""Przedmiotem zamówienia jest budowa Centrum Przesiadkowego w Świerklańcu przy ulicyParkowej. Projekt zakłada budowę centrum przesiadkowego składającego się z głównego peronu autobusowego z wiatą dla pasażerów, dodatkowego peronu z wiatami dla rowerów orazparkingów dla samochodów osobowych."",
""sid"": ""info:145036"",
""awarded_value"": ""5774850.00"",
""awarded_currency"": ""PLN"",
""awarded_value_eur"": ""1243963.12"",
""purchaser"": {
""id"": ""30582"",
""sid"": null,
""name"": null
},
""type"": {
""id"": ""art-275-pkt-1-ustawy"",
""name"": ""art. 275 pkt 1 ustawy"",
""slug"": ""art-275-pkt-1-ustawy""
},
""awarded"": [
{
""date"": ""2022-05-19"",
""value_for_two"": 5774850,
""value_for_two_eur"": 1243963.12,
""suppliers"": [
{
""name"": ""Przedsiębiorstwo Instalacyjno-Montażowe KZ Sp. z o.o."",
""id"": 26099,
""slug"": ""przedsiebiorstwo-instalacyjno-montazowe-kz-sp-z-o-o""
},
{
""name"": ""Konstrukcje Stalowe K-Z Sp. z o.o."",
""id"": 26100,
""slug"": ""konstrukcje-stalowe-k-z-sp-z-o-o""
}
],
""value_min"": ""5774850.00"",
""value_for_three"": 5774850,
""value_for_one_eur"": 0,
""count"": ""1"",
""value_for_one"": 0,
""value_for_three_eur"": 1243963.12,
""suppliers_id"": ""26099,26100"",
""value_eur"": 1243963.12,
""value_max"": ""6283402.59"",
""offers_count"": [
2
],
""suppliers_name"": ""Przedsiębiorstwo Instalacyjno-Montażowe KZ Sp. z o.o. Konstrukcje Stalowe K-Z Sp. z o.o."",
""value"": ""5774850.00"",
""value_estimated"": null,
""offers_count_data"": {
""2"": {
""value_eur"": 1243963.12,
""count"": ""1"",
""value"": ""5774850.00""
}
}
}
]
},
{
""id"": ""583773"",
""date"": ""2022-03-28"",
""deadline_date"": ""2022-04-07"",
""deadline_length_days"": ""9"",
""deadline_length_hours"": ""235"",
""title"": ""Kulturalna wielo – hybrydowa konwersja Gminnego Ośrodka Kultury w Wielowsi z podziałem na zadania częściowe."",
""category"": ""supplies"",
""description"": ""Zadanie nr 1 – Dostawa sprzętu komputerowego zgodnie z załącznikiem nr 7A do SWZ."",
""sid"": ""info:162514"",
""awarded_value"": ""184844.60"",
""awarded_currency"": ""PLN"",
""awarded_value_eur"": ""39454.55"",
""purchaser"": {
""id"": ""19985"",
""sid"": null,
""name"": null
},
""type"": {
""id"": ""art-275-pkt-1-ustawy"",
""name"": ""art. 275 pkt 1 ustawy"",
""slug"": ""art-275-pkt-1-ustawy""
},
""indicators"": [
""declined"",
""low_value_awarded""
],
""awarded"": [
{
""date"": ""2022-05-02"",
""value_for_two"": 48600,
""value_for_two_eur"": 10373.53,
""suppliers"": [
{
""name"": ""VISION Zbigniew Ducki"",
""id"": 26008,
""slug"": ""vision-zbigniew-ducki""
}
],
""value_min"": ""48600.00"",
""value_for_three"": 48600,
""value_for_one_eur"": 0,
""count"": ""1"",
""value_for_one"": 0,
""offers_declined"": [
1
],
""value_for_three_eur"": 10373.53,
""suppliers_id"": ""26008"",
""value_eur"": 10373.53,
""value_max"": ""48600.00"",
""offers_count"": [
2
],
""suppliers_name"": ""VISION Zbigniew Ducki"",
""value"": ""48600.00"",
""value_estimated"": ""49200.00"",
""offers_count_data"": {
""2"": {
""value_eur"": 10373.53,
""count"": ""1"",
""value"": ""48600.00""
}
}
},
{
""date"": ""2022-05-02"",
""value_for_two"": 0,
""value_for_two_eur"": 0,
""suppliers"": [
{
""name"": ""Agencja Muzyczna Accord"",
""id"": 28093,
""slug"": ""agencja-muzyczna-accord""
}
],
""value_min"": ""91044.60"",
""value_for_three"": 91044.6,
""value_for_one_eur"": 0,
""count"": ""2"",
""value_for_one"": 0,
""offers_declined"": [
1
],
""value_for_three_eur"": 19433.21,
""suppliers_id"": ""28093"",
""value_eur"": 19433.21,
""value_max"": ""120500.00"",
""offers_count"": [
3
],
""suppliers_name"": ""Agencja Muzyczna Accord"",
""value"": ""91044.60"",
""value_estimated"": ""92865.00"",
""offers_count_data"": {
""3"": {
""value_eur"": 19433.21,
""count"": ""2"",
""value"": ""91044.60""
}
}
},
{
""date"": ""2022-05-02"",
""value_for_two"": 45200,
""value_for_two_eur"": 9647.81,
""suppliers"": [
{
""name"": ""VISION Zbigniew Ducko"",
""id"": 28094,
""slug"": ""vision-zbigniew-ducko""
}
],
""value_min"": ""45200.00"",
""value_for_three"": 45200,
""value_for_one_eur"": 0,
""count"": ""1"",
""value_for_one"": 0,
""offers_declined"": [
1
],
""value_for_three_eur"": 9647.81,
""suppliers_id"": ""28094"",
""value_eur"": 9647.81,
""value_max"": ""45200.00"",
""offers_count"": [
2
],
""suppliers_name"": ""VISION Zbigniew Ducko"",
""value"": ""45200.00"",
""value_estimated"": ""46740.00"",
""offers_count_data"": {
""2"": {
""value_eur"": 9647.81,
""count"": ""1"",
""value"": ""45200.00""
}
}
}
]
},
{
""id"": ""580892"",
""date"": ""2022-03-30"",
""deadline_date"": ""2022-04-08"",
""deadline_length_days"": ""8"",
""deadline_length_hours"": ""213"",
""title"": ""Dostawa mięsa do Dziennego Domu Pomocy Społecznej Wrzos w Tychach"",
""category"": ""supplies"",
""description"": ""Część 1 - Dostawa mięsa wieprzowego i wołowego1. Szacunkowa ilość zamówienia została przedstawiona w formularzu asortymentowo - cenowym stanowiącym załącznik 1a do SWZ.2. Dostawa produktów zwierzęcych obejmuje dostarczenie ich przez Wykonawcę własnym transportem do siedziby Zamawiającego oraz wniesienie towaru do pomieszczeń magazynowych. Wykonawca ponosi koszty transportu oraz odpowiada za braki i wady powstałe w czasie transportu.3. Produkty zwierzęce muszą być pełnowartościowe w pierwszym gat"",
""sid"": ""info:154484"",
""awarded_value"": ""59082.00"",
""awarded_currency"": ""PLN"",
""awarded_value_eur"": ""12750.45"",
""purchaser"": {
""id"": ""34073"",
""sid"": null,
""name"": null
},
""type"": {
""id"": ""art-275-pkt-1-ustawy"",
""name"": ""art. 275 pkt 1 ustawy"",
""slug"": ""art-275-pkt-1-ustawy""
},
""awarded"": [
{
""date"": ""2022-04-22"",
""value_for_two"": 0,
""value_for_two_eur"": 0,
""suppliers"": [
{
""name"": ""Grupa Drobiarska Dakpol Marek Bejm Spółka Komandytowa"",
""id"": 26343,
""slug"": ""grupa-drobiarska-dakpol-marek-bejm-spolka-komandytowa""
}
],
""value_min"": ""24200.00"",
""value_for_three"": 0,
""value_for_one_eur"": 0,
""count"": ""1"",
""value_for_one"": 0,
""value_for_three_eur"": 0,
""suppliers_id"": ""26343"",
""value_eur"": 5222.72,
""value_max"": ""36750.00"",
""offers_count"": [
5
],
""suppliers_name"": ""Grupa Drobiarska Dakpol Marek Bejm Spółka Komandytowa"",
""value"": ""24200.00"",
""value_estimated"": ""26619.00"",
""offers_count_data"": {
""5"": {
""value_eur"": 5222.72,
""count"": ""1"",
""value"": ""24200.00""
}
}
},
{
""date"": ""2022-04-20"",
""value_for_two"": 0,
""value_for_two_eur"": 0,
""suppliers"": [
{
""name"": ""Sprzedaż Art.Rolno-Spoż i Mięsnych Smak Tradycji Jarosław Kemona"",
""id"": 27144,
""slug"": ""sprzedaz-art-rolno-spoz-i-miesnych-smak-tradycji-jaroslaw-kemona""
}
],
""value_min"": ""34882.00"",
""value_for_three"": 0,
""value_for_one_eur"": 0,
""count"": ""1"",
""value_for_one"": 0,
""value_for_three_eur"": 0,
""suppliers_id"": ""27144"",
""value_eur"": 7527.73,
""value_max"": ""52204.00"",
""offers_count"": [
5
],
""suppliers_name"": ""Sprzedaż Art.Rolno-Spoż i Mięsnych Smak Tradycji Jarosław Kemona"",
""value"": ""34882.00"",
""value_estimated"": ""41029.26"",
""offers_count_data"": {
""5"": {
""value_eur"": 7527.73,
""count"": ""1"",
""value"": ""34882.00""
}
}
}
]
},
{
""id"": ""575864"",
""date"": ""2022-03-02"",
""deadline_date"": ""2022-03-17"",
""deadline_length_days"": ""14"",
""deadline_length_hours"": ""354"",
""title"": ""Przebudowa ul. Wiejskiej i Wiosennej w Niewodnikach"",
""category"": ""constructions"",
""description"": ""1. Przedmiotem zamówienia jest „Przebudowa ul. Wiejskiej i Wiosennej w Niewodnikach”, zgodnie z dokumentacją projektową i specyfikacją techniczną wykonania i odbioru robót budowlanych. Dokumenty te stanowią załączniki do niniejszej specyfikacji.2. Zadanie inwestycyjne obejmuje m.in.: 1) Roboty pomiarowe i ziemne, 2) Roboty ziemne, korytowanie, 3) Roboty odwadniające i nawierzchniowe 4) Ogólne roboty budowlane związane z budową rurociągów5) Organizację, zagospodarowanie i likwidację placu budowy,"",
""sid"": ""info:142420"",
""awarded_value"": ""1350742.80"",
""awarded_currency"": ""PLN"",
""awarded_value_eur"": ""290776.23"",
""purchaser"": {
""id"": ""24110"",
""sid"": null,
""name"": null
},
""type"": {
""id"": ""art-275-pkt-1-ustawy"",
""name"": ""art. 275 pkt 1 ustawy"",
""slug"": ""art-275-pkt-1-ustawy""
},
""awarded"": [
{
""date"": ""2022-04-13"",
""value_for_two"": 0,
""value_for_two_eur"": 0,
""suppliers"": [
{
""name"": ""VIANKO Sp. z o.o."",
""id"": 14325,
""slug"": ""vianko-sp-z-o-o""
}
],
""value_min"": ""1350742.80"",
""value_for_three"": 0,
""value_for_one_eur"": 0,
""count"": ""1"",
""value_for_one"": 0,
""value_for_three_eur"": 0,
""suppliers_id"": ""14325"",
""value_eur"": 290776.23,
""value_max"": ""2410800.00"",
""offers_count"": [
5
],
""suppliers_name"": ""VIANKO Sp. z o.o."",
""value"": ""1350742.80"",
""value_estimated"": null,
""offers_count_data"": {
""5"": {
""value_eur"": 290776.23,
""count"": ""1"",
""value"": ""1350742.80""
}
}
}
]
},
{
""id"": ""587352"",
""date"": ""2022-02-08"",
""deadline_date"": ""2022-02-21"",
""deadline_length_days"": ""13"",
""deadline_length_hours"": ""312"",
""title"": ""Zakup i dostawa leków dla potrzeb Apteki szpitalnej"",
""category"": ""supplies"",
""description"": ""ZADANIE nr 1 – leki psychotropowe i inne • Oferowany przedmiot zamówienia musi spełniać wymagania Zamawiającego określone w Formularzu cenowym – załącznik nr 2 do SWZ"",
""sid"": ""info:172374"",
""awarded_value"": ""682041.61"",
""awarded_currency"": ""PLN"",
""awarded_value_eur"": ""138900.19"",
""purchaser"": {
""id"": ""23726"",
""sid"": null,
""name"": null
},
""type"": {
""id"": ""art-275-pkt-1-ustawy"",
""name"": ""art. 275 pkt 1 ustawy"",
""slug"": ""art-275-pkt-1-ustawy""
},
""indicators"": [
""low_value_awarded"",
""declined""
],
""awarded"": [
{
""date"": ""2022-03-08"",
""value_for_two"": 682041.61,
""value_for_two_eur"": 138900.19,
""suppliers"": [],
""value_min"": ""682041.61"",
""value_for_three"": 682041.61,
""value_for_one_eur"": 0,
""count"": ""1"",
""value_for_one"": 0,
""value_for_three_eur"": 138900.19,
""suppliers_id"": ""10"",
""value_eur"": 138900.19,
""value_max"": ""762357.49"",
""offers_count"": [
2
],
""suppliers_name"": """",
""value"": ""682041.61"",
""value_estimated"": ""572336.16"",
""offers_count_data"": {
""2"": {
""value_eur"": 138900.19,
""count"": ""1"",
""value"": ""682041.61""
}
}
}
]
},
{
""id"": ""576986"",
""date"": ""2022-01-12"",
""deadline_date"": ""2022-01-28"",
""deadline_length_days"": ""15"",
""deadline_length_hours"": ""381"",
""title"": ""Remont nawierzchni dróg powiatowych nr 2709G i 2707G z podziałem na dwie części:"",
""category"": ""constructions"",
""description"": ""Remont nawierzchni drogi powiatowej nr 2709G na odcinku Bobowo – WysokaOpis przedmiotu zamówienia - zał. nr 1 do SWZ część 1"",
""sid"": ""info:144917"",
""awarded_value"": ""2176668.95"",
""awarded_currency"": ""PLN"",
""awarded_value_eur"": ""483381.88"",
""purchaser"": {
""id"": ""23062"",
""sid"": null,
""name"": null
},
""type"": {
""id"": ""art-275-pkt-1-ustawy"",
""name"": ""art. 275 pkt 1 ustawy"",
""slug"": ""art-275-pkt-1-ustawy""
},
""awarded"": [
{
""date"": ""2022-02-17"",
""value_for_two"": 0,
""value_for_two_eur"": 0,
""suppliers"": [
{
""name"": ""Drogomex Sp. z o.o."",
""id"": 17733,
""slug"": ""drogomex-sp-z-o-o""
}
],
""value_min"": ""1445403.20"",
""value_for_three"": 0,
""value_for_one_eur"": 0,
""count"": ""1"",
""value_for_one"": 0,
""value_for_three_eur"": 0,
""suppliers_id"": ""17733"",
""value_eur"": 320737.42,
""value_max"": ""2276234.31"",
""offers_count"": [
4
],
""suppliers_name"": ""Drogomex Sp. z o.o."",
""value"": ""1445403.20"",
""value_estimated"": ""1370600.00"",
""offers_count_data"": {
""4"": {
""value_eur"": 320737.42,
""count"": ""1"",
""value"": ""1445403.20""
}
}
},
{
""date"": ""2022-02-16"",
""value_for_two"": 0,
""value_for_two_eur"": 0,
""suppliers"": [
{
""name"": ""PRZEDSIĘBIORSTWO BUDOWY DRÓG S.A"",
""id"": 21812,
""slug"": ""przedsiebiorstwo-budowy-drog-s-a""
}
],
""value_min"": ""731265.75"",
""value_for_three"": 731265.75,
""value_for_one_eur"": 0,
""count"": ""1"",
""value_for_one"": 0,
""offers_declined"": [
1
],
""value_for_three_eur"": 162644.46,
""suppliers_id"": ""21812"",
""value_eur"": 162644.46,
""value_max"": ""1201095.00"",
""offers_count"": [
3
],
""suppliers_name"": ""PRZEDSIĘBIORSTWO BUDOWY DRÓG S.A"",
""value"": ""731265.75"",
""value_estimated"": ""835450.00"",
""offers_count_data"": {
""3"": {
""value_eur"": 162644.46,
""count"": ""1"",
""value"": ""731265.75""
}
}
}
]
},
{
""id"": ""582288"",
""date"": ""2021-12-03"",
""deadline_date"": ""2021-12-14"",
""deadline_length_days"": ""10"",
""deadline_length_hours"": ""262"",
""title"": ""Dostawę artykułów żywnościowych do jednostek obsługiwanych przez Zespół do obsługi Placówek Opiekuńczo-Wychowawczych Nr 3 w Warszawie na rok 2022"",
""category"": ""supplies"",
""description"": ""Dostawa mięsa i wędlin - Placówka Opiekuńczo-Wychowawcza „Czwórka”"",
""sid"": ""info:158023"",
""awarded_value"": ""5780.05"",
""awarded_currency"": ""PLN"",
""awarded_value_eur"": ""1277.95"",
""purchaser"": {
""id"": ""13509"",
""sid"": null,
""name"": null
},
""type"": {
""id"": ""art-275-pkt-1-ustawy"",
""name"": ""art. 275 pkt 1 ustawy"",
""slug"": ""art-275-pkt-1-ustawy""
},
""indicators"": [
""declined"",
""high_value_awarded""
],
""awarded"": [
{
""date"": ""2022-01-19"",
""value_for_two"": 5780.05,
""value_for_two_eur"": 1277.95,
""suppliers"": [],
""value_min"": ""5780.05"",
""value_for_three"": 5780.05,
""value_for_one_eur"": 0,
""count"": ""1"",
""value_for_one"": 0,
""offers_declined"": [
1
],
""value_for_three_eur"": 1277.95,
""suppliers_id"": ""27597"",
""value_eur"": 1277.95,
""value_max"": ""5780.05"",
""offers_count"": [
2
],
""suppliers_name"": """",
""value"": ""5780.05"",
""value_estimated"": ""5319.72"",
""offers_count_data"": {
""2"": {
""value_eur"": 1277.95,
""count"": ""1"",
""value"": ""5780.05""
}
}
}
]
},
{
""id"": ""571816"",
""date"": ""2021-12-06"",
""deadline_date"": ""2021-12-14"",
""deadline_length_days"": ""7"",
""deadline_length_hours"": ""186"",
""title"": ""Organizacja i przeprowadzenie kursu podstawowego spawania metodą MIG oraz TIG w podziale na 3 części"",
""category"": ""services"",
""description"": ""Zorganizowanie i przeprowadzenie kursu spawania metodą MIG dla drugiej grupy 6 osobowej„Kurs podstawowego spawania metodą MIG 131” – spawanie elektrodą metalową w osłonie gazów obojętnych (pierwsza grupa)Przedmiotem zamówienia jest organizacja i przeprowadzenie zgodnie z wytycznymi Instytutu Spawalnictwa w Gliwicach „Kursu podstawowego spawania metodą MIG” – spawanie elektrodą metalową w osłonie gazów obojętnych dla uczniów/uczennic biorących udział w projekcie „Poprawa edukacji zawodowej w PCE "",
""sid"": ""info:134447"",
""awarded_value"": ""15000.00"",
""awarded_currency"": ""PLN"",
""awarded_value_eur"": ""3301.20"",
""purchaser"": {
""id"": ""23086"",
""sid"": null,
""name"": null
},
""type"": {
""id"": ""art-275-pkt-1-ustawy"",
""name"": ""art. 275 pkt 1 ustawy"",
""slug"": ""art-275-pkt-1-ustawy""
},
""indicators"": [
""declined""
],
""awarded"": [
{
""date"": ""2022-01-11"",
""value_for_two"": 30000,
""value_for_two_eur"": 6602.4,
""suppliers"": [],
""value_min"": ""15000.00"",
""value_for_three"": 30000,
""value_for_one_eur"": 0,
""count"": ""1"",
""value_for_one"": 0,
""offers_declined"": [
1
],
""value_for_three_eur"": 6602.4,
""suppliers_id"": ""25044"",
""value_eur"": 3301.2,
""value_max"": ""15000.00"",
""offers_count"": [
2
],
""suppliers_name"": """",
""value"": ""15000.00"",
""value_estimated"": ""15000.00"",
""offers_count_data"": {
""2"": {
""value_eur"": 6602.4,
""count"": ""2"",
""value"": ""30000.00""
}
}
}
]
},
{
""id"": ""584014"",
""date"": ""2021-12-13"",
""deadline_date"": ""2021-12-21"",
""deadline_length_days"": ""7"",
""deadline_length_hours"": ""188"",
""title"": ""Dostawa mięsa i wędlin, mrożonek i ryb, nabiału i produktów mleczarskich, warzyw i owoców, pieczywa, wyrobów piekarskich i ciastkarskich, różnych artykułów spożywczych i jaj."",
""category"": ""supplies"",
""description"": ""Mięso i wędliny"",
""sid"": ""info:163429"",
""awarded_value"": ""186355.85"",
""awarded_currency"": ""PLN"",
""awarded_value_eur"": ""40604.83"",
""purchaser"": {
""id"": ""34487"",
""sid"": null,
""name"": null
},
""type"": {
""id"": ""art-275-pkt-1-ustawy"",
""name"": ""art. 275 pkt 1 ustawy"",
""slug"": ""art-275-pkt-1-ustawy""
},
""indicators"": [
""declined""
],
""awarded"": [
{
""date"": ""2022-01-03"",
""value_for_two"": 11644.49,
""value_for_two_eur"": 2537.2,
""suppliers"": [
{
""name"": ""Piekarnia Tomasz Sięda"",
""id"": 27624,
""slug"": ""piekarnia-tomasz-sieda""
}
],
""value_min"": ""11644.49"",
""value_for_three"": 11644.49,
""value_for_one_eur"": 0,
""count"": ""1"",
""value_for_one"": 0,
""offers_declined"": [
1
],
""value_for_three_eur"": 2537.2,
""suppliers_id"": ""27624"",
""value_eur"": 2537.2,
""value_max"": ""11644.49"",
""offers_count"": [
2
],
""suppliers_name"": ""Piekarnia Tomasz Sięda"",
""value"": ""11644.49"",
""value_estimated"": ""11616.84"",
""offers_count_data"": {
""2"": {
""value_eur"": 2537.2,
""count"": ""1"",
""value"": ""11644.49""
}
}
},
{
""date"": ""2022-01-03"",
""value_for_two"": 71953.63,
""value_for_two_eur"": 15677.88,
""suppliers"": [
{
""name"": ""Mona-Kontra Sp.zo.o."",
""id"": 27770,
""slug"": ""mona-kontra-sp-zo-o""
}
],
""value_min"": ""92175.83"",
""value_for_three"": 92175.83,
""offers_count_status"": ""contains_only_one"",
""value_for_one_eur"": 8551.54,
""count"": ""3"",
""value_for_one"": 39247.28,
""value_for_three_eur"": 20084.07,
""suppliers_id"": ""27770"",
""value_eur"": 20084.07,
""value_max"": ""103131.01"",
""offers_count"": [
1,
2,
3
],
""suppliers_name"": ""Mona-Kontra Sp.zo.o."",
""value"": ""92175.83"",
""value_estimated"": ""108328.38"",
""offers_count_data"": {
""1"": {
""value_eur"": 8551.54,
""count"": ""1"",
""value"": ""39247.28""
},
""2"": {
""value_eur"": 7126.34,
""count"": ""1"",
""value"": ""32706.35""
},
""3"": {
""value_eur"": 4406.19,
""count"": ""1"",
""value"": ""20222.20""
}
}
},
{
""date"": ""2022-01-03"",
""value_for_two"": 30828.13,
""value_for_two_eur"": 6717.1,
""suppliers"": [
{
""name"": ""FPH Piotr Nowakowski"",
""id"": 28168,
""slug"": ""fph-piotr-nowakowski""
}
],
""value_min"": ""30828.13"",
""value_for_three"": 30828.13,
""value_for_one_eur"": 0,
""count"": ""1"",
""value_for_one"": 0,
""value_for_three_eur"": 6717.1,
""suppliers_id"": ""28168"",
""value_eur"": 6717.1,
""value_max"": ""32614.55"",
""offers_count"": [
2
],
""suppliers_name"": ""FPH Piotr Nowakowski"",
""value"": ""30828.13"",
""value_estimated"": ""38950.76"",
""offers_count_data"": {
""2"": {
""value_eur"": 6717.1,
""count"": ""1"",
""value"": ""30828.13""
}
}
},
{
""date"": ""2022-01-03"",
""value_for_two"": 46907.4,
""value_for_two_eur"": 10220.59,
""suppliers"": [
{
""name"": ""Przedsiębiorstwo Handlowo-Usługowe GEMIX"",
""id"": 28169,
""slug"": ""przedsiebiorstwo-handlowo-uslugowe-gemix""
}
],
""value_min"": ""46907.40"",
""value_for_three"": 46907.4,
""value_for_one_eur"": 0,
""count"": ""1"",
""value_for_one"": 0,
""value_for_three_eur"": 10220.59,
""suppliers_id"": ""28169"",
""value_eur"": 10220.59,
""value_max"": ""47060.50"",
""offers_count"": [
2
],
""suppliers_name"": ""Przedsiębiorstwo Handlowo-Usługowe GEMIX"",
""value"": ""46907.40"",
""value_estimated"": ""68478.56"",
""offers_count_data"": {
""2"": {
""value_eur"": 10220.59,
""count"": ""1"",
""value"": ""46907.40""
}
}
},
{
""date"": ""2022-01-03"",
""value_for_two"": 0,
""value_for_two_eur"": 0,
""suppliers"": [
{
""name"": ""PPHU Biliński Waldemar Biliński"",
""id"": 7041,
""slug"": ""pphu-bilinski-waldemar-bilinski""
}
],
""value_min"": ""4800.00"",
""value_for_three"": 0,
""value_for_one_eur"": 0,
""count"": ""1"",
""value_for_one"": 0,
""offers_declined"": [
2
],
""value_for_three_eur"": 0,
""suppliers_id"": ""7041"",
""value_eur"": 1045.87,
""value_max"": ""7440.00"",
""offers_count"": [
4
],
""suppliers_name"": ""PPHU Biliński Waldemar Biliński"",
""value"": ""4800.00"",
""value_estimated"": ""4023.20"",
""offers_count_data"": {
""4"": {
""value_eur"": 1045.87,
""count"": ""1"",
""value"": ""4800.00""
}
}
}
]
},
{
""id"": ""578280"",
""date"": ""2021-11-26"",
""deadline_date"": ""2021-12-08"",
""deadline_length_days"": ""11"",
""deadline_length_hours"": ""287"",
""title"": ""Dowożenie wraz z zapewnieniem opieki uczniów"",
""category"": ""services"",
""description"": ""Dowożenie wraz z zapewnieniem opieki uczniów niepełnosprawnych Szkoły Podstawowej nr 6 im. H. Cegielskiego z Oddziałami Integracyjnymi na osiedlu Rusa 56 w Poznaniu do szkoły oraz odwożenie wraz z zapewnieniem opieki uczniów po skończonych zajęciach szkolnych do domu – część nr 1"",
""sid"": ""info:148041"",
""awarded_value"": ""168190.73"",
""awarded_currency"": ""PLN"",
""awarded_value_eur"": ""36587.85"",
""purchaser"": {
""id"": ""33787"",
""sid"": null,
""name"": null
},
""type"": {
""id"": ""art-275-pkt-1-ustawy"",
""name"": ""art. 275 pkt 1 ustawy"",
""slug"": ""art-275-pkt-1-ustawy""
},
""awarded"": [
{
""date"": ""2021-12-31"",
""value_for_two"": 70502.4,
""value_for_two_eur"": 15336.94,
""suppliers"": [
{
""name"": ""KORMAX – HOL Dariusz Korytowski"",
""id"": 26399,
""slug"": ""kormax-hol-dariusz-korytowski""
}
],
""value_min"": ""70502.40"",
""value_for_three"": 70502.4,
""value_for_one_eur"": 0,
""count"": ""1"",
""value_for_one"": 0,
""value_for_three_eur"": 15336.94,
""suppliers_id"": ""26399"",
""value_eur"": 15336.94,
""value_max"": ""127170.00"",
""offers_count"": [
2
],
""suppliers_name"": ""KORMAX – HOL Dariusz Korytowski"",
""value"": ""70502.40"",
""value_estimated"": ""59088.49"",
""offers_count_data"": {
""2"": {
""value_eur"": 15336.94,
""count"": ""1"",
""value"": ""70502.40""
}
}
},
{
""date"": ""2021-12-31"",
""value_for_two"": 97688.33,
""value_for_two_eur"": 21250.91,
""suppliers"": [
{
""name"": ""LUKA – TRANS s.c. Ewa i Zbigniew Korus"",
""id"": 9322,
""slug"": ""luka-trans-s-c-ewa-i-zbigniew-korus""
}
],
""value_min"": ""97688.33"",
""value_for_three"": 97688.33,
""value_for_one_eur"": 0,
""count"": ""1"",
""value_for_one"": 0,
""value_for_three_eur"": 21250.91,
""suppliers_id"": ""9322"",
""value_eur"": 21250.91,
""value_max"": ""183124.80"",
""offers_count"": [
2
],
""suppliers_name"": ""LUKA – TRANS s.c. Ewa i Zbigniew Korus"",
""value"": ""97688.33"",
""value_estimated"": ""85087.43"",
""offers_count_data"": {
""2"": {
""value_eur"": 21250.91,
""count"": ""1"",
""value"": ""97688.33""
}
}
}
]
},
{
""id"": ""578003"",
""date"": ""2021-11-23"",
""deadline_date"": ""2021-12-02"",
""deadline_length_days"": ""8"",
""deadline_length_hours"": ""215"",
""title"": ""Dostawa żywności na potrzeby Domu Pomocy Społecznej „Zacisze” z podziałem na 9 części"",
""category"": ""supplies"",
""description"": ""Boczek wędzony parzony 70 kgFlaki wołowe – krojone 150 kgGolonka wieprzowa 80 kgNogi wieprzowe 80 kgŁopatka wieprzowa b/k 200 kgWołowe z kością – szponder 100 kgGulaszowe wołowe ekstra 100 kgGoleń wołowa b/k 70 kgKarczek wieprzowy b/k 150 kgŻeberka wieprzowe mięsne paski 100 kgSłonina 15 kgOzory wieprzowe 60 kgSchab wieprzowy b/k 100 kgWołowina b/k zrazowa 30 kg"",
""sid"": ""info:147337"",
""awarded_value"": ""42156.03"",
""awarded_currency"": ""PLN"",
""awarded_value_eur"": ""17945.11"",
""purchaser"": {
""id"": ""33745"",
""sid"": null,
""name"": null
},
""type"": {
""id"": ""art-275-pkt-1-ustawy"",
""name"": ""art. 275 pkt 1 ustawy"",
""slug"": ""art-275-pkt-1-ustawy""
},
""awarded"": [
{
""date"": ""2021-12-31"",
""value_for_two"": 0,
""value_for_two_eur"": 0,
""suppliers"": [],
""value_min"": ""20494.53"",
""value_for_three"": 20494.53,
""value_for_one_eur"": 0,
""count"": ""1"",
""value_for_one"": 0,
""value_for_three_eur"": 4458.34,
""suppliers_id"": ""22598"",
""value_eur"": 4458.34,
""value_max"": ""22151.33"",
""offers_count"": [
3
],
""suppliers_name"": """",
""value"": ""20494.53"",
""value_estimated"": ""19523.81"",
""offers_count_data"": {
""3"": {
""value_eur"": 4458.34,
""count"": ""1"",
""value"": ""20494.53""
}
}
},
{
""date"": ""2021-12-30"",
""value_for_two"": 0,
""value_for_two_eur"": 0,
""suppliers"": [],
""value_min"": ""40359.90"",
""value_for_three"": 40359.9,
""value_for_one_eur"": 0,
""count"": ""1"",
""value_for_one"": 0,
""value_for_three_eur"": 8781.53,
""suppliers_id"": ""23092"",
""value_eur"": 8781.53,
""value_max"": ""51320.85"",
""offers_count"": [
3
],
""suppliers_name"": """",
""value"": ""40359.90"",
""value_estimated"": ""44095.24"",
""offers_count_data"": {
""3"": {
""value_eur"": 8781.53,
""count"": ""1"",
""value"": ""40359.90""
}
}
},
{
""date"": ""2021-12-29"",
""value_for_two"": 21661.5,
""value_for_two_eur"": 4705.24,
""suppliers"": [],
""value_min"": ""21661.50"",
""value_for_three"": 21661.5,
""value_for_one_eur"": 0,
""count"": ""1"",
""value_for_one"": 0,
""value_for_three_eur"": 4705.24,
""suppliers_id"": ""26343"",
""value_eur"": 4705.24,
""value_max"": ""23222.85"",
""offers_count"": [
2
],
""suppliers_name"": """",
""value"": ""21661.50"",
""value_estimated"": ""17838.10"",
""offers_count_data"": {
""2"": {
""value_eur"": 4705.24,
""count"": ""1"",
""value"": ""21661.50""
}
}
}
]
},
{
""id"": ""510041"",
""date"": ""2021-03-04"",
""deadline_date"": ""2021-03-16"",
""deadline_length_days"": ""11"",
""deadline_length_hours"": ""287"",
""title"": ""Dostawa sprzętu jednorazowego użytku - 1"",
""category"": ""supplies"",
""description"": ""strzykawki, igły"",
""sid"": ""info:32661"",
""awarded_value"": ""200204.56"",
""awarded_currency"": ""PLN"",
""awarded_value_eur"": ""43980.36"",
""purchaser"": {
""id"": ""2571"",
""sid"": null,
""name"": null
},
""type"": {
""id"": ""art-275-pkt-1-ustawy"",
""name"": ""art. 275 pkt 1 ustawy"",
""slug"": ""art-275-pkt-1-ustawy""
},
""awarded"": [
{
""date"": ""2021-12-31"",
""value_for_two"": 92105.13,
""value_for_two_eur"": 20436.47,
""suppliers"": [
{
""name"": ""AESCUKAP CHIFA SP. Z O.O."",
""id"": 16639,
""slug"": ""aescukap-chifa-sp-z-o-o""
}
],
""value_min"": ""92105.13"",
""value_for_three"": 92105.13,
""offers_count_status"": ""only_one"",
""value_for_one_eur"": 20436.47,
""count"": ""1"",
""value_for_one"": 92105.13,
""value_for_three_eur"": 20436.47,
""suppliers_id"": ""16639"",
""value_eur"": 20436.47,
""value_max"": ""92105.13"",
""offers_count"": [
1
],
""suppliers_name"": ""AESCUKAP CHIFA SP. Z O.O."",
""value"": ""92105.13"",
""value_estimated"": ""85746.85"",
""offers_count_data"": {
""1"": {
""value_eur"": 20436.47,
""count"": ""1"",
""value"": ""92105.13""
}
}
},
{
""date"": ""2021-04-06"",
""value_for_two"": 77114.7,
""value_for_two_eur"": 16795.47,
""suppliers"": [
{
""name"": ""BIALMED Sp. z o.o."",
""id"": 12,
""slug"": ""bialmed-sp-z-o-o""
}
],
""value_min"": ""79068.68"",
""value_for_three"": 79590.15,
""offers_count_status"": ""contains_only_one"",
""value_for_one_eur"": 13097.64,
""count"": ""8"",
""value_for_one"": 60136.52,
""value_for_three_eur"": 17334.61,
""suppliers_id"": ""12"",
""value_eur"": 17366.89,
""value_max"": ""82495.99"",
""offers_count"": [
1,
2,
3,
4
],
""suppliers_name"": ""BIALMED Sp. z o.o."",
""value"": ""79738.35"",
""value_estimated"": ""72056.11"",
""offers_count_data"": {
""1"": {
""value_eur"": 13097.64,
""count"": ""2"",
""value"": ""60136.52""
},
""2"": {
""value_eur"": 3697.82,
""count"": ""3"",
""value"": ""16978.18""
},
""3"": {
""value_eur"": 539.15,
""count"": ""2"",
""value"": ""2475.45""
},
""4"": {
""value_eur"": 32.28,
""count"": ""1"",
""value"": ""148.20""
}
}
},
{
""date"": ""2021-04-06"",
""value_for_two"": 0,
""value_for_two_eur"": 0,
""suppliers"": [
{
""name"": ""MEDOX SP. Z .O.O"",
""id"": 16640,
""slug"": ""medox-sp-z-o-o""
}
],
""value_min"": ""2659.07"",
""value_for_three"": 0,
""value_for_one_eur"": 0,
""count"": ""1"",
""value_for_one"": 0,
""value_for_three_eur"": 0,
""suppliers_id"": ""16640"",
""value_eur"": 648.48,
""value_max"": ""3193.13"",
""offers_count"": [
4
],
""suppliers_name"": ""MEDOX SP. Z .O.O"",
""value"": ""2977.45"",
""value_estimated"": ""2240.28"",
""offers_count_data"": {
""4"": {
""value_eur"": 648.48,
""count"": ""1"",
""value"": ""2977.45""
}
}
},
{
""date"": ""2021-04-06"",
""value_for_two"": 0,
""value_for_two_eur"": 0,
""suppliers"": [
{
""name"": ""SORIMEX SP. Z O.O. SP.K"",
""id"": 448,
""slug"": ""sorimex-sp-z-o-o-sp-k""
}
],
""value_min"": ""8551.60"",
""value_for_three"": 8551.6,
""value_for_one_eur"": 0,
""count"": ""1"",
""value_for_one"": 0,
""value_for_three_eur"": 1862.53,
""suppliers_id"": ""448"",
""value_eur"": 1862.53,
""value_max"": ""10665.13"",
""offers_count"": [
3
],
""suppliers_name"": ""SORIMEX SP. Z O.O. SP.K"",
""value"": ""8551.60"",
""value_estimated"": ""6853.22"",
""offers_count_data"": {
""3"": {
""value_eur"": 1862.53,
""count"": ""1"",
""value"": ""8551.60""
}
}
},
{
""date"": ""2021-04-06"",
""value_for_two"": 16832.03,
""value_for_two_eur"": 3665.99,
""suppliers"": [
{
""name"": ""ZARYS International Group Sp. z o.o. Sp. K"",
""id"": 63,
""slug"": ""zarys-international-group-sp-z-o-o-sp-k""
}
],
""value_min"": ""16832.03"",
""value_for_three"": 16832.03,
""offers_count_status"": ""contains_only_one"",
""value_for_one_eur"": 1303.06,
""count"": ""4"",
""value_for_one"": 5982.89,
""value_for_three_eur"": 3665.99,
""suppliers_id"": ""63"",
""value_eur"": 3665.99,
""value_max"": ""26707.81"",
""offers_count"": [
1,
2
],
""suppliers_name"": ""ZARYS International Group Sp. z o.o. Sp. K"",
""value"": ""16832.03"",
""value_estimated"": ""15404.13"",
""offers_count_data"": {
""1"": {
""value_eur"": 1303.06,
""count"": ""3"",
""value"": ""5982.89""
},
""2"": {
""value_eur"": 2362.93,
""count"": ""1"",
""value"": ""10849.14""
}
}
}
]
},
{
""id"": ""509263"",
""date"": ""2021-03-08"",
""deadline_date"": ""2021-03-16"",
""deadline_length_days"": ""7"",
""deadline_length_hours"": ""189"",
""title"": ""ZP1/03/2021 R. Sukcesywna dostawa artykułów żywnościowych dla Zespołu Placówek Oświatowych w Janowie Podlaskim w 2021."",
""category"": ""supplies"",
""description"": ""Część NR 1 ARTYKUŁY SPOZYWCZE – przyprawy zapach świeży po otwarciu produktów, bez oznak spleśnienia, grudek, produkty gotowane sypkie, bez sklejania się twarde sprężyste, produkty z puszek bez pleśni , mętnej konsystencjiMAKARONY Sporządzony z najwyższej jakości mąki, zawiera pszenice durum, po ugotowaniu nie skleja się, jest twardy i sprężysty, zachowuje naturalny .zapach i kolor"",
""sid"": ""info:30908"",
""awarded_value"": ""158231.01"",
""awarded_currency"": ""PLN"",
""awarded_value_eur"": ""34442.48"",
""purchaser"": {
""id"": ""25200"",
""sid"": null,
""name"": null
},
""type"": {
""id"": ""art-275-pkt-1-ustawy"",
""name"": ""art. 275 pkt 1 ustawy"",
""slug"": ""art-275-pkt-1-ustawy""
},
""indicators"": [
""low_value_awarded""
],
""awarded"": [
{
""date"": ""2021-12-31"",
""value_for_two"": 41616.7,
""value_for_two_eur"": 9234,
""suppliers"": [
{
""name"": ""IBIS Zozula Zareba Spółka Jawna"",
""id"": 16837,
""slug"": ""ibis-zozula-zareba-spolka-jawna""
}
],
""value_min"": ""41616.70"",
""value_for_three"": 41616.7,
""offers_count_status"": ""only_one"",
""value_for_one_eur"": 9234,
""count"": ""1"",
""value_for_one"": 41616.7,
""value_for_three_eur"": 9234,
""suppliers_id"": ""16837"",
""value_eur"": 9234,
""value_max"": ""41616.70"",
""offers_count"": [
1
],
""suppliers_name"": ""IBIS Zozula Zareba Spółka Jawna"",
""value"": ""41616.70"",
""value_estimated"": ""37286.68"",
""offers_count_data"": {
""1"": {
""value_eur"": 9234,
""count"": ""1"",
""value"": ""41616.70""
}
}
},
{
""date"": ""2021-04-01"",
""value_for_two"": 29232.56,
""value_for_two_eur"": 6342.63,
""suppliers"": [
{
""name"": ""Ren Sp zo. o."",
""id"": 16839,
""slug"": ""ren-sp-zo-o""
}
],
""value_min"": ""29232.56"",
""value_for_three"": 29232.56,
""value_for_one_eur"": 0,
""count"": ""1"",
""value_for_one"": 0,
""value_for_three_eur"": 6342.63,
""suppliers_id"": ""16839"",
""value_eur"": 6342.63,
""value_max"": ""30051.30"",
""offers_count"": [
2
],
""suppliers_name"": ""Ren Sp zo. o."",
""value"": ""29232.56"",
""value_estimated"": ""27058.98"",
""offers_count_data"": {
""2"": {
""value_eur"": 6342.63,
""count"": ""1"",
""value"": ""29232.56""
}
}
},
{
""date"": ""2021-04-01"",
""value_for_two"": 32979.7,
""value_for_two_eur"": 7155.66,
""suppliers"": [
{
""name"": ""Hurt i Detal Artykuły spożywczo Rolne - Anna Siekierko"",
""id"": 425,
""slug"": ""hurt-i-detal-artykuly-spozywczo-rolne-anna-siekierko""
}
],
""value_min"": ""32979.70"",
""value_for_three"": 32979.7,
""value_for_one_eur"": 0,
""count"": ""1"",
""value_for_one"": 0,
""value_for_three_eur"": 7155.66,
""suppliers_id"": ""425"",
""value_eur"": 7155.66,
""value_max"": ""44108.21"",
""offers_count"": [
2
],
""suppliers_name"": ""Hurt i Detal Artykuły spożywczo Rolne - Anna Siekierko"",
""value"": ""32979.70"",
""value_estimated"": ""32202.96"",
""offers_count_data"": {
""2"": {
""value_eur"": 7155.66,
""count"": ""1"",
""value"": ""32979.70""
}
}
},
{
""date"": ""2021-03-29"",
""value_for_two"": 45579.8,
""value_for_two_eur"": 9811.18,
""suppliers"": [
{
""name"": ""IBIS Zozula Zareba Spółka Jawna"",
""id"": 16837,
""slug"": ""ibis-zozula-zareba-spolka-jawna""
}
],
""value_min"": ""45579.80"",
""value_for_three"": 45579.8,
""offers_count_status"": ""only_one"",
""value_for_one_eur"": 9811.18,
""count"": ""1"",
""value_for_one"": 45579.8,
""value_for_three_eur"": 9811.18,
""suppliers_id"": ""16837"",
""value_eur"": 9811.18,
""value_max"": ""45579.80"",
""offers_count"": [
1
],
""suppliers_name"": ""IBIS Zozula Zareba Spółka Jawna"",
""value"": ""45579.80"",
""value_estimated"": ""33468.38"",
""offers_count_data"": {
""1"": {
""value_eur"": 9811.18,
""count"": ""1"",
""value"": ""45579.80""
}
}
},
{
""date"": ""2021-03-29"",
""value_for_two"": 8822.25,
""value_for_two_eur"": 1899.01,
""suppliers"": [
{
""name"": ""IBIS Zozula Zareba Spółka Jawna 21-500 Biała Podlaska"",
""id"": 16838,
""slug"": ""ibis-zozula-zareba-spolka-jawna-21-500-biala-podlaska""
}
],
""value_min"": ""8822.25"",
""value_for_three"": 8822.25,
""offers_count_status"": ""only_one"",
""value_for_one_eur"": 1899.01,
""count"": ""1"",
""value_for_one"": 8822.25,
""value_for_three_eur"": 1899.01,
""suppliers_id"": ""16838"",
""value_eur"": 1899.01,
""value_max"": ""8822.25"",
""offers_count"": [
1
],
""suppliers_name"": ""IBIS Zozula Zareba Spółka Jawna 21-500 Biała Podlaska"",
""value"": ""8822.25"",
""value_estimated"": ""7218.11"",
""offers_count_data"": {
""1"": {
""value_eur"": 1899.01,
""count"": ""1"",
""value"": ""8822.25""
}
}
}
]
},
{
""id"": ""504812"",
""date"": ""2021-03-23"",
""deadline_date"": ""2021-03-31"",
""deadline_length_days"": ""8"",
""deadline_length_hours"": ""193"",
""title"": ""Dostawa (sprzedaż wraz z transportem) kruszyw kamiennych."",
""category"": ""supplies"",
""description"": ""Dostawa (sprzedaż wraz z transportem) grysu mineralnego dolomitowego do robót drogowych. Szczegółowy opis przedmiotu zamówienia znajduje się w SWZ."",
""sid"": ""info:42877"",
""awarded_value"": ""101658.27"",
""awarded_currency"": ""PLN"",
""awarded_value_eur"": ""22344.17"",
""purchaser"": {
""id"": ""786"",
""sid"": null,
""name"": null
},
""type"": {
""id"": ""art-275-pkt-2-ustawy"",
""name"": ""art. 275 pkt 2 ustawy"",
""slug"": ""art-275-pkt-2-ustawy""
},
""indicators"": [
""declined"",
""low_value_awarded""
],
""awarded"": [
{
""date"": ""2021-12-31"",
""value_for_two"": 0,
""value_for_two_eur"": 0,
""suppliers"": [
{
""name"": ""P.T.U.H. MARTRANS Łonak Mariusz"",
""id"": 19969,
""slug"": ""p-t-u-h-martrans-lonak-mariusz""
}
],
""value_min"": ""14125.32"",
""value_for_three"": 0,
""value_for_one_eur"": 0,
""count"": ""1"",
""value_for_one"": 0,
""offers_declined"": [
3
],
""value_for_three_eur"": 0,
""suppliers_id"": ""19969"",
""value_eur"": 3134.15,
""value_max"": ""14125.32"",
""offers_count"": [
4
],
""suppliers_name"": ""P.T.U.H. MARTRANS Łonak Mariusz"",
""value"": ""14125.32"",
""value_estimated"": ""12180.00"",
""offers_count_data"": {
""4"": {
""value_eur"": 3134.15,
""count"": ""1"",
""value"": ""14125.32""
}
}
},
{
""date"": ""2021-04-22"",
""value_for_two"": 0,
""value_for_two_eur"": 0,
""suppliers"": [
{
""name"": ""P.T.U.H. MARTRANS Łonak Mariusz"",
""id"": 19969,
""slug"": ""p-t-u-h-martrans-lonak-mariusz""
}
],
""value_min"": ""77200.95"",
""value_for_three"": 0,
""value_for_one_eur"": 0,
""count"": ""1"",
""value_for_one"": 0,
""offers_declined"": [
3
],
""value_for_three_eur"": 0,
""suppliers_id"": ""19969"",
""value_eur"": 16942.29,
""value_max"": ""79283.34"",
""offers_count"": [
5
],
""suppliers_name"": ""P.T.U.H. MARTRANS Łonak Mariusz"",
""value"": ""77200.95"",
""value_estimated"": ""66540.00"",
""offers_count_data"": {
""5"": {
""value_eur"": 16942.29,
""count"": ""1"",
""value"": ""77200.95""
}
}
},
{
""date"": ""2021-04-21"",
""value_for_two"": 0,
""value_for_two_eur"": 0,
""suppliers"": [
{
""name"": ""P.W. PROMAG Sp. z o.o."",
""id"": 19968,
""slug"": ""p-w-promag-sp-z-o-o""
}
],
""value_min"": ""10332.00"",
""value_for_three"": 0,
""value_for_one_eur"": 0,
""count"": ""1"",
""value_for_one"": 0,
""offers_declined"": [
3
],
""value_for_three_eur"": 0,
""suppliers_id"": ""19968"",
""value_eur"": 2267.73,
""value_max"": ""10332.00"",
""offers_count"": [
4
],
""suppliers_name"": ""P.W. PROMAG Sp. z o.o."",
""value"": ""10332.00"",
""value_estimated"": ""8400.00"",
""offers_count_data"": {
""4"": {
""value_eur"": 2267.73,
""count"": ""1"",
""value"": ""10332.00""
}
}
}
]
},
{
""id"": ""579387"",
""date"": ""2021-11-29"",
""deadline_date"": ""2021-12-10"",
""deadline_length_days"": ""10"",
""deadline_length_hours"": ""260"",
""title"": ""Zakup biletów miesięcznych dla uczniów w gminie Dębe Wielkie w okresie od dnia 03.01.2022 r. do 30.06.2022 r."",
""category"": ""services"",
""description"": ""1. Przedmiotem zamówienia jest dostawa i sprzedaż biletów miesięcznych szkolnych dla uczniów szkół podstawowych, prowadzonych przez Gminę Dębe Wielkie na podstawie art. 5a. Ustawy z dnia 20 czerwca 1992 r. o uprawnieniach do ulgowych przejazdów środkami publicznego transportu zbiorowego (tj. Dz. U. z 2018 r., poz. 295 ze zm.). Zakup biletów obejmuje linie lub ich odcinki w granicach administracyjnych Gminy Dębe Wielkie. Szczegółowy opis przedmiotu zamówienia zawiera załącznik nr 5 do SWZ."",
""sid"": ""info:150664"",
""awarded_value"": ""80245.20"",
""awarded_currency"": ""PLN"",
""awarded_value_eur"": ""17459.79"",
""purchaser"": {
""id"": ""24362"",
""sid"": null,
""name"": null
},
""type"": {
""id"": ""art-275-pkt-1-ustawy"",
""name"": ""art. 275 pkt 1 ustawy"",
""slug"": ""art-275-pkt-1-ustawy""
},
""awarded"": [
{
""date"": ""2021-12-30"",
""value_for_two"": 0,
""value_for_two_eur"": 0,
""suppliers"": [
{
""name"": ""Usługi Transportowe Przewóz Osób Bogdan Raniszewski"",
""id"": 12167,
""slug"": ""uslugi-transportowe-przewoz-osob-bogdan-raniszewski""
}
],
""value_min"": ""80245.20"",
""value_for_three"": 0,
""value_for_one_eur"": 0,
""count"": ""1"",
""value_for_one"": 0,
""value_for_three_eur"": 0,
""suppliers_id"": ""12167"",
""value_eur"": 17459.79,
""value_max"": ""149586.00"",
""offers_count"": [
4
],
""suppliers_name"": ""Usługi Transportowe Przewóz Osób Bogdan Raniszewski"",
""value"": ""80245.20"",
""value_estimated"": null,
""offers_count_data"": {
""4"": {
""value_eur"": 17459.79,
""count"": ""1"",
""value"": ""80245.20""
}
}
}
]
},
{
""id"": ""575823"",
""date"": ""2021-11-29"",
""deadline_date"": ""2021-12-07"",
""deadline_length_days"": ""7"",
""deadline_length_hours"": ""188"",
""title"": ""Dostawa używanych lub nowych urządzeń wielofunkcyjnych"",
""category"": ""supplies"",
""description"": ""Przedmiotem postępowania i zamówienia jest dostawa używanych lub nowych 10 urządzeń wielofunkcyjnych (w tym 5 czarno – białych i 5 kolorowych). Szczegółowy opis i zakres przedmiotu zamówienia określa Załącznik nr 1A do SWZ „Szczegółowy opis przedmiotu zamówienia”. Dostawa asortymentu obejmuje także niezbędne oprogramowanie, sterowniki i wyposażenie (w tym okablowanie), jak również dostarczenie asortymentu do siedziby Zamawiającego, wyładunek i wniesienie do wskazanych przez Zamawiającego pomiesz"",
""sid"": ""info:142340"",
""awarded_value"": ""24538.50"",
""awarded_currency"": ""PLN"",
""awarded_value_eur"": ""5297.60"",
""purchaser"": {
""id"": ""24797"",
""sid"": null,
""name"": null
},
""type"": {
""id"": ""art-275-pkt-1-ustawy"",
""name"": ""art. 275 pkt 1 ustawy"",
""slug"": ""art-275-pkt-1-ustawy""
},
""indicators"": [
""declined""
],
""awarded"": [
{
""date"": ""2021-12-22"",
""value_for_two"": 24538.5,
""value_for_two_eur"": 5297.6,
""suppliers"": [
{
""name"": ""MARDRUK Marcin Kubaty"",
""id"": 25844,
""slug"": ""mardruk-marcin-kubaty""
}
],
""value_min"": ""24292.40"",
""value_for_three"": 24538.5,
""value_for_one_eur"": 0,
""count"": ""1"",
""value_for_one"": 0,
""offers_declined"": [
1
],
""value_for_three_eur"": 5297.6,
""suppliers_id"": ""25844"",
""value_eur"": 5297.6,
""value_max"": ""24538.50"",
""offers_count"": [
2
],
""suppliers_name"": ""MARDRUK Marcin Kubaty"",
""value"": ""24538.50"",
""value_estimated"": null,
""offers_count_data"": {
""2"": {
""value_eur"": 5297.6,
""count"": ""1"",
""value"": ""24538.50""
}
}
}
]
},
{
""id"": ""569847"",
""date"": ""2021-11-09"",
""deadline_date"": ""2021-12-03"",
""deadline_length_days"": ""23"",
""deadline_length_hours"": ""573"",
""title"": ""BUDOWA ZESPOŁU BOISK SPORTOWYCH PRZY ZESPOLE SZKÓŁ LEŚNYCH W BIŁGORAJU - ETAP III"",
""category"": ""constructions"",
""description"": ""1. Przedmiotem zamówienia jest budowa zespołu boisk sportowych przy Zespole Szkół Leśnych w Biłgoraju - Etap III (na działce nr ewid. 5/5 w Biłgoraju).2. Zakres robót objęty niniejszym zamówieniem polega m. in. na:1) Wykonaniu schodów terenowych, nawierzchnia z kostki brukowej,2) Wykonaniu chodników z kostki brukowej,3) Humusowaniu terenu z obsianiem trawy,4) Wykonaniu podbudów z kruszywa łamanego pod rozbieg do skoczni w dal, bieżni prostej 60 metrowej oraz boiska do piłki nożnej,5) Wykonaniu o"",
""sid"": ""info:129661"",
""awarded_value"": ""756787.61"",
""awarded_currency"": ""PLN"",
""awarded_value_eur"": ""163382.47"",
""purchaser"": {
""id"": ""32223"",
""sid"": null,
""name"": null
},
""type"": {
""id"": ""art-275-pkt-1-ustawy"",
""name"": ""art. 275 pkt 1 ustawy"",
""slug"": ""art-275-pkt-1-ustawy""
},
""awarded"": [
{
""date"": ""2021-12-22"",
""value_for_two"": 0,
""value_for_two_eur"": 0,
""suppliers"": [
{
""name"": ""Solid-Stet Sp. z o. o. Sp. K."",
""id"": 22901,
""slug"": ""solid-stet-sp-z-o-o-sp-k""
}
],
""value_min"": ""756787.61"",
""value_for_three"": 0,
""value_for_one_eur"": 0,
""count"": ""1"",
""value_for_one"": 0,
""offers_declined"": [
3
],
""value_for_three_eur"": 0,
""suppliers_id"": ""22901"",
""value_eur"": 163382.47,
""value_max"": ""982770.00"",
""offers_count"": [
13
],
""suppliers_name"": ""Solid-Stet Sp. z o. o. Sp. K."",
""value"": ""756787.61"",
""value_estimated"": null,
""offers_count_data"": {
""13"": {
""value_eur"": 163382.47,
""count"": ""1"",
""value"": ""756787.61""
}
}
}
]
},
{
""id"": ""570845"",
""date"": ""2021-11-04"",
""deadline_date"": ""2021-11-19"",
""deadline_length_days"": ""14"",
""deadline_length_hours"": ""354"",
""title"": ""Rozbiórka obiektów budowlanych wchodzących w skład Zasobu Własności Rolnej Skarbu Państwa, położonych w miejscowościach: Buszkowiczki, Skołoszów, Głobikowa na terenie woj. podkarpackiego"",
""category"": ""constructions"",
""description"": ""Budynek chlewni 1/6/1/B położonego na działce 164/1 (budynek murowany , kryty eternitem wraz z wybiegiem dla zwierząt oraz szambem), obręb Buszkowiczki, gmina Żurawica, powiat przemyski, województwo podkarpackie"",
""sid"": ""info:132125"",
""awarded_value"": ""91512.00"",
""awarded_currency"": ""PLN"",
""awarded_value_eur"": ""19840.86"",
""purchaser"": {
""id"": ""799"",
""sid"": null,
""name"": null
},
""type"": {
""id"": ""art-275-pkt-1-ustawy"",
""name"": ""art. 275 pkt 1 ustawy"",
""slug"": ""art-275-pkt-1-ustawy""
},
""indicators"": [
""low_value_awarded""
],
""awarded"": [
{
""date"": ""2021-12-10"",
""value_for_two"": 0,
""value_for_two_eur"": 0,
""suppliers"": [
{
""name"": ""Elektro-Tim"",
""id"": 24664,
""slug"": ""elektro-tim""
}
],
""value_min"": ""91512.00"",
""value_for_three"": 0,
""value_for_one_eur"": 0,
""count"": ""3"",
""value_for_one"": 0,
""offers_declined"": [
1
],
""value_for_three_eur"": 0,
""suppliers_id"": ""24664"",
""value_eur"": 19840.86,
""value_max"": ""725700.00"",
""offers_count"": [
5
],
""suppliers_name"": ""Elektro-Tim"",
""value"": ""91512.00"",
""value_estimated"": ""193614.89"",
""offers_count_data"": {
""5"": {
""value_eur"": 19840.86,
""count"": ""3"",
""value"": ""91512.00""
}
}
}
]
},
{
""id"": ""571838"",
""date"": ""2021-10-04"",
""deadline_date"": ""2021-10-15"",
""deadline_length_days"": ""11"",
""deadline_length_hours"": ""269"",
""title"": ""Zakup i dostawa aparatury badawczej oraz drobnego sprzętu laboratoryjnego dla Międzynarodowego Centrum Badań Innowacyjnych Biomateriałów (ICRI-BioM) Międzynarodowa Agenda Badawcza w Łodzi"",
""category"": ""supplies"",
""description"": ""Załącznik nr 1 do SWZ - Część nr 1 – Cyrkulator z chłodzeniem"",
""sid"": ""info:134503"",
""awarded_value"": ""69273.97"",
""awarded_currency"": ""PLN"",
""awarded_value_eur"": ""14967.48"",
""purchaser"": {
""id"": ""3545"",
""sid"": null,
""name"": null
},
""type"": {
""id"": ""art-275-pkt-1-ustawy"",
""name"": ""art. 275 pkt 1 ustawy"",
""slug"": ""art-275-pkt-1-ustawy""
},
""indicators"": [
""low_value_awarded"",
""high_value_awarded""
],
""awarded"": [
{
""date"": ""2021-12-01"",
""value_for_two"": 0,
""value_for_two_eur"": 0,
""suppliers"": [],
""value_min"": ""10042.70"",
""value_for_three"": 0,
""value_for_one_eur"": 0,
""count"": ""1"",
""value_for_one"": 0,
""value_for_three_eur"": 0,
""suppliers_id"": ""11809"",
""value_eur"": 2169.85,
""value_max"": ""13457.43"",
""offers_count"": [
4
],
""suppliers_name"": """",
""value"": ""10042.70"",
""value_estimated"": ""6722.00"",
""offers_count_data"": {
""4"": {
""value_eur"": 2169.85,
""count"": ""1"",
""value"": ""10042.70""
}
}
},
{
""date"": ""2021-12-01"",
""value_for_two"": 2521.5,
""value_for_two_eur"": 544.8,
""suppliers"": [],
""value_min"": ""2521.50"",
""value_for_three"": 2521.5,
""offers_count_status"": ""only_one"",
""value_for_one_eur"": 544.8,
""count"": ""1"",
""value_for_one"": 2521.5,
""value_for_three_eur"": 544.8,
""suppliers_id"": ""7194"",
""value_eur"": 544.8,
""value_max"": ""2521.50"",
""offers_count"": [
1
],
""suppliers_name"": """",
""value"": ""2521.50"",
""value_estimated"": ""2510.00"",
""offers_count_data"": {
""1"": {
""value_eur"": 544.8,
""count"": ""1"",
""value"": ""2521.50""
}
}
},
{
""date"": ""2021-12-01"",
""value_for_two"": 56709.770000000004,
""value_for_two_eur"": 12252.83,
""suppliers"": [],
""value_min"": ""48744.90"",
""value_for_three"": 56709.770000000004,
""offers_count_status"": ""contains_only_one"",
""value_for_one_eur"": 1078.97,
""count"": ""4"",
""value_for_one"": 4993.8,
""value_for_three_eur"": 12252.83,
""suppliers_id"": ""850"",
""value_eur"": 12252.83,
""value_max"": ""56879.51"",
""offers_count"": [
1,
2
],
""suppliers_name"": """",
""value"": ""56709.77"",
""value_estimated"": ""65978.92"",
""offers_count_data"": {
""1"": {
""value_eur"": 1078.97,
""count"": ""1"",
""value"": ""4993.80""
},
""2"": {
""value_eur"": 11173.86,
""count"": ""3"",
""value"": ""51715.97""
}
}
}
]
},
{
""id"": ""582233"",
""date"": ""2021-09-29"",
""deadline_date"": ""2021-10-18"",
""deadline_length_days"": ""19"",
""deadline_length_hours"": ""456"",
""title"": ""Modernizacja pomieszczeń biurowych w budynku administracyjno - leczniczym Szpitala Mazowieckiego w Garwolinie Sp. z o.o."",
""category"": ""constructions"",
""description"": ""Przedmiotem zamówienia jest Modernizacja pomieszczeń biurowych w budynku administracyjno-leczniczym Szpitala Mazowieckiego w Garwolinie Sp. z o.o. Realizacja przedmiotu zamówieniaobejmuje wykonanie robót budowlano-montażowych polegających na modernizacji I piętra budynku administracyjno-leczniczego, a także wykonanie systemu klimatyzacji na każdej kondygnacji.Modernizacja w budynku administracyjno-leczniczym ma na celu zaadaptowanie I piętra na pomieszczenia biurowe i zaplecze socjalne oraz mont"",
""sid"": ""info:157886"",
""awarded_value"": ""898000.00"",
""awarded_currency"": ""PLN"",
""awarded_value_eur"": ""191872.14"",
""purchaser"": {
""id"": ""29449"",
""sid"": null,
""name"": null
},
""type"": {
""id"": ""art-275-pkt-1-ustawy"",
""name"": ""art. 275 pkt 1 ustawy"",
""slug"": ""art-275-pkt-1-ustawy""
},
""awarded"": [
{
""date"": ""2021-11-24"",
""value_for_two"": 0,
""value_for_two_eur"": 0,
""suppliers"": [
{
""name"": ""Przedsiębiorstwo Usługowo Handlowe LUX Janina i Bogusław Lejman Spółka Jawna"",
""id"": 27582,
""slug"": ""przedsiebiorstwo-uslugowo-handlowe-lux-janina-i-boguslaw-lejman-spolka-jawna""
}
],
""value_min"": ""898000.00"",
""value_for_three"": 0,
""value_for_one_eur"": 0,
""count"": ""1"",
""value_for_one"": 0,
""offers_declined"": [
1
],
""value_for_three_eur"": 0,
""suppliers_id"": ""27582"",
""value_eur"": 191872.14,
""value_max"": ""1214347.87"",
""offers_count"": [
7
],
""suppliers_name"": ""Przedsiębiorstwo Usługowo Handlowe LUX Janina i Bogusław Lejman Spółka Jawna"",
""value"": ""898000.00"",
""value_estimated"": null,
""offers_count_data"": {
""7"": {
""value_eur"": 191872.14,
""count"": ""1"",
""value"": ""898000.00""
}
}
}
]
},
{
""id"": ""569397"",
""date"": ""2021-11-08"",
""deadline_date"": ""2021-11-23"",
""deadline_length_days"": ""15"",
""deadline_length_hours"": ""360"",
""title"": ""Wykonanie nowego pokrycia dachowego z pracami towarzyszącymi dla Podstacji Sądeckiego Pogotowia Ratunkowego w Krynicy Zdroju."",
""category"": ""constructions"",
""description"": ""1. Przedmiotem zamówienia jest wykonanie nowego pokrycia dachowego z pracami towarzyszącymi dla Podstacji Sądeckiego Pogotowia Ratunkowego w Krynicy Zdroju.2. Zakres zamówienia obejmuje m.in.:1) Demontaż rynny dachowej z PCV na budynku Pogotowia ok. 19.00mb.;2) Demontaż istniejącej rury spustowej na istniejącym budynku Pogotowia ok. 4.00mb.;3) Rozebranie obróbki blacharskiej na istniejącym ogniomurze dachu garażowego od strony ul. Kraszewskiego;4) Rozebranie fragmentu pokrycia dachowego z papy z"",
""sid"": ""info:128606"",
""awarded_value"": ""36619.82"",
""awarded_currency"": ""PLN"",
""awarded_value_eur"": ""7824.41"",
""purchaser"": {
""id"": ""24487"",
""sid"": null,
""name"": null
},
""type"": {
""id"": ""art-275-pkt-1-ustawy"",
""name"": ""art. 275 pkt 1 ustawy"",
""slug"": ""art-275-pkt-1-ustawy""
},
""awarded"": [
{
""date"": ""2021-11-24"",
""value_for_two"": 36619.82,
""value_for_two_eur"": 7824.41,
""suppliers"": [
{
""name"": ""Wojciech Kruczek, prowadzący działalność gospodarczą pod firmą: FHU KRUCZEK Wojciech Kruczek"",
""id"": 24179,
""slug"": ""wojciech-kruczek-prowadzacy-dzialalnosc-gospodarcza-pod-firma-fhu-kruczek-wojciech-kruczek""
}
],
""value_min"": ""36619.82"",
""value_for_three"": 36619.82,
""offers_count_status"": ""only_one"",
""value_for_one_eur"": 7824.41,
""count"": ""1"",
""value_for_one"": 36619.82,
""value_for_three_eur"": 7824.41,
""suppliers_id"": ""24179"",
""value_eur"": 7824.41,
""value_max"": ""36619.82"",
""offers_count"": [
1
],
""suppliers_name"": ""Wojciech Kruczek, prowadzący działalność gospodarczą pod firmą: FHU KRUCZEK Wojciech Kruczek"",
""value"": ""36619.82"",
""value_estimated"": null,
""offers_count_data"": {
""1"": {
""value_eur"": 7824.41,
""count"": ""1"",
""value"": ""36619.82""
}
}
}
]
},
{
""id"": ""574102"",
""date"": ""2021-10-12"",
""deadline_date"": ""2021-10-27"",
""deadline_length_days"": ""15"",
""deadline_length_hours"": ""360"",
""title"": ""Modernizacja sieci LAN urzędów skarbowych województwa lubelskiego."",
""category"": ""constructions"",
""description"": ""Przedmiotem zamówienia jest wykonanie modernizacji sieci LAN w obiekcie Urzędu Skarbowego w Białej Podlaskiej. Szczegółowy opis przedmiotu zamówienia w zakresie części nr 1 zawarty jest w załączniku nr 1.1 do projektu umowy."",
""sid"": ""info:138918"",
""awarded_value"": ""3051700.00"",
""awarded_currency"": ""PLN"",
""awarded_value_eur"": ""657233.47"",
""purchaser"": {
""id"": ""25282"",
""sid"": null,
""name"": null
},
""type"": {
""id"": ""art-275-pkt-2-ustawy"",
""name"": ""art. 275 pkt 2 ustawy"",
""slug"": ""art-275-pkt-2-ustawy""
},
""awarded"": [
{
""date"": ""2021-11-16"",
""value_for_two"": 0,
""value_for_two_eur"": 0,
""suppliers"": [
{
""name"": ""ELPIE Sp. z o.o."",
""id"": 21605,
""slug"": ""elpie-sp-z-o-o""
}
],
""value_min"": ""2381700.00"",
""value_for_three"": 502000,
""value_for_one_eur"": 0,
""count"": ""5"",
""value_for_one"": 0,
""offers_declined"": [
1
],
""value_for_three_eur"": 107852.62,
""suppliers_id"": ""21605"",
""value_eur"": 511698.36,
""value_max"": ""4298481.00"",
""offers_count"": [
3,
4
],
""suppliers_name"": ""ELPIE Sp. z o.o."",
""value"": ""2381700.00"",
""value_estimated"": ""2648271.98"",
""offers_count_data"": {
""3"": {
""value_eur"": 107852.62,
""count"": ""2"",
""value"": ""502000.00""
},
""4"": {
""value_eur"": 403845.74,
""count"": ""3"",
""value"": ""1879700.00""
}
}
},
{
""date"": ""2021-11-05"",
""value_for_two"": 670000,
""value_for_two_eur"": 145535.11,
""suppliers"": [
{
""name"": ""ELPIE Sp. z o.o."",
""id"": 21605,
""slug"": ""elpie-sp-z-o-o""
}
],
""value_min"": ""670000.00"",
""value_for_three"": 670000,
""offers_count_status"": ""only_one"",
""value_for_one_eur"": 145535.11,
""count"": ""1"",
""value_for_one"": 670000,
""value_for_three_eur"": 145535.11,
""suppliers_id"": ""21605"",
""value_eur"": 145535.11,
""value_max"": ""670000.00"",
""offers_count"": [
1
],
""suppliers_name"": ""ELPIE Sp. z o.o."",
""value"": ""670000.00"",
""value_estimated"": ""692695.48"",
""offers_count_data"": {
""1"": {
""value_eur"": 145535.11,
""count"": ""1"",
""value"": ""670000.00""
}
}
}
]
},
{
""id"": ""570050"",
""date"": ""2021-10-18"",
""deadline_date"": ""2021-11-02"",
""deadline_length_days"": ""15"",
""deadline_length_hours"": ""362"",
""title"": ""Modernizacja sali kinowej Miejsko-Gminnego Ośrodka Kultury w Więcborku – wykonanie widowni"",
""category"": ""constructions"",
""description"": ""Przedmiotem zamówienia jest wykonanie widowni Miejsko-Gminnego Ośrodka Kultury w Więcborku. Zakres robót obejmuje:- roboty rozbiórkowe (rozebranie podłóg białych na wpust, rozebranie legarów),- wykonanie kanałów teletechnicznych,- wykonanie płyty fundamentowej wraz ze zbrojeniem,- wykonanie izolacji,- ułożenie posadzki z wykładzin z tworzyw sztucznych zwarstwą izolacyjną."",
""sid"": ""info:130117"",
""awarded_value"": ""295000.10"",
""awarded_currency"": ""PLN"",
""awarded_value_eur"": ""63613.25"",
""purchaser"": {
""id"": ""32523"",
""sid"": null,
""name"": null
},
""type"": {
""id"": ""art-275-pkt-1-ustawy"",
""name"": ""art. 275 pkt 1 ustawy"",
""slug"": ""art-275-pkt-1-ustawy""
},
""awarded"": [
{
""date"": ""2021-11-15"",
""value_for_two"": 295000.1,
""value_for_two_eur"": 63613.25,
""suppliers"": [
{
""name"": ""Zakład Usług Murarskich Jarosław Kołodziejski"",
""id"": 24345,
""slug"": ""zaklad-uslug-murarskich-jaroslaw-kolodziejski""
}
],
""value_min"": ""295000.10"",
""value_for_three"": 295000.1,
""offers_count_status"": ""only_one"",
""value_for_one_eur"": 63613.25,
""count"": ""1"",
""value_for_one"": 295000.1,
""value_for_three_eur"": 63613.25,
""suppliers_id"": ""24345"",
""value_eur"": 63613.25,
""value_max"": ""295000.10"",
""offers_count"": [
1
],
""suppliers_name"": ""Zakład Usług Murarskich Jarosław Kołodziejski"",
""value"": ""295000.10"",
""value_estimated"": null,
""offers_count_data"": {
""1"": {
""value_eur"": 63613.25,
""count"": ""1"",
""value"": ""295000.10""
}
}
}
]
},
{
""id"": ""569118"",
""date"": ""2021-10-05"",
""deadline_date"": ""2021-10-15"",
""deadline_length_days"": ""10"",
""deadline_length_hours"": ""242"",
""title"": ""Kursy dla uczniów"",
""category"": ""services"",
""description"": ""Kurs prawa jazdy kat. B"",
""sid"": ""info:128022"",
""awarded_value"": ""64663.00"",
""awarded_currency"": ""PLN"",
""awarded_value_eur"": ""14036.73"",
""purchaser"": {
""id"": ""23565"",
""sid"": null,
""name"": null
},
""type"": {
""id"": ""art-275-pkt-1-ustawy"",
""name"": ""art. 275 pkt 1 ustawy"",
""slug"": ""art-275-pkt-1-ustawy""
},
""indicators"": [
""low_value_awarded""
],
""awarded"": [
{
""date"": ""2021-11-04"",
""value_for_two"": 18200,
""value_for_two_eur"": 3950.77,
""suppliers"": [
{
""name"": ""Warmińsko-Mazurski Zakład Doskonalenia Zawodowego w Olsztynie Centrum Edukacji"",
""id"": 17940,
""slug"": ""warminsko-mazurski-zaklad-doskonalenia-zawodowego-w-olsztynie-centrum-edukacji""
}
],
""value_min"": ""30918.00"",
""value_for_three"": 22350,
""value_for_one_eur"": 0,
""count"": ""6"",
""value_for_one"": 0,
""value_for_three_eur"": 4851.63,
""suppliers_id"": ""17940"",
""value_eur"": 6646.41,
""value_max"": ""52198.00"",
""offers_count"": [
2,
3,
4,
5
],
""suppliers_name"": ""Warmińsko-Mazurski Zakład Doskonalenia Zawodowego w Olsztynie Centrum Edukacji"",
""value"": ""30618.00"",
""value_estimated"": ""54862.00"",
""offers_count_data"": {
""2"": {
""value_eur"": 3950.77,
""count"": ""1"",
""value"": ""18200.00""
},
""3"": {
""value_eur"": 900.86,
""count"": ""1"",
""value"": ""4150.00""
},
""4"": {
""value_eur"": 631.25,
""count"": ""2"",
""value"": ""2908.00""
},
""5"": {
""value_eur"": 1163.52,
""count"": ""2"",
""value"": ""5360.00""
}
}
},
{
""date"": ""2021-11-04"",
""value_for_two"": 10455,
""value_for_two_eur"": 2269.52,
""suppliers"": [
{
""name"": ""WITMAX Technologies Sebastian Witkowski"",
""id"": 17942,
""slug"": ""witmax-technologies-sebastian-witkowski""
}
],
""value_min"": ""10455.00"",
""value_for_three"": 10455,
""value_for_one_eur"": 0,
""count"": ""1"",
""value_for_one"": 0,
""value_for_three_eur"": 2269.52,
""suppliers_id"": ""17942"",
""value_eur"": 2269.52,
""value_max"": ""10860.00"",
""offers_count"": [
2
],
""suppliers_name"": ""WITMAX Technologies Sebastian Witkowski"",
""value"": ""10455.00"",
""value_estimated"": ""12290.00"",
""offers_count_data"": {
""2"": {
""value_eur"": 2269.52,
""count"": ""1"",
""value"": ""10455.00""
}
}
},
{
""date"": ""2021-11-04"",
""value_for_two"": 23590,
""value_for_two_eur"": 5120.8,
""suppliers"": [
{
""name"": ""Inventum Sp. z o.o."",
""id"": 2991,
""slug"": ""inventum-sp-z-o-o""
}
],
""value_min"": ""23590.00"",
""value_for_three"": 23590,
""value_for_one_eur"": 0,
""count"": ""1"",
""value_for_one"": 0,
""value_for_three_eur"": 5120.8,
""suppliers_id"": ""2991"",
""value_eur"": 5120.8,
""value_max"": ""24045.00"",
""offers_count"": [
2
],
""suppliers_name"": ""Inventum Sp. z o.o."",
""value"": ""23590.00"",
""value_estimated"": ""19750.78"",
""offers_count_data"": {
""2"": {
""value_eur"": 5120.8,
""count"": ""1"",
""value"": ""23590.00""
}
}
}
]
},
{
""id"": ""570835"",
""date"": ""2021-08-09"",
""deadline_date"": ""2021-08-17"",
""deadline_length_days"": ""7"",
""deadline_length_hours"": ""185"",
""title"": ""Badania ankietowe i zogniskowane wywiady grupowe (FGI) dotyczące dostępności systemu wsparcia relacji w ramach projektu „Zintegrowany system zapobiegania przemocy domowej”"",
""category"": ""services"",
""description"": ""badanie ankietowe dotyczące dostępności systemu wsparcia relacji, realizowane techniką zbierania informacji za pomocą ankiety w formie elektronicznej przy pomocy strony WWW (CAWI)"",
""sid"": ""info:132094"",
""awarded_value"": ""195693.00"",
""awarded_currency"": ""PLN"",
""awarded_value_eur"": ""43008.51"",
""purchaser"": {
""id"": ""33067"",
""sid"": null,
""name"": null
},
""type"": {
""id"": ""art-275-pkt-1-ustawy"",
""name"": ""art. 275 pkt 1 ustawy"",
""slug"": ""art-275-pkt-1-ustawy""
},
""indicators"": [
""high_value_awarded""
],
""awarded"": [
{
""date"": ""2021-09-15"",
""value_for_two"": 0,
""value_for_two_eur"": 0,
""suppliers"": [
{
""name"": ""Biuro Badań Społecznych Question Mark sp. z o.o."",
""id"": 18263,
""slug"": ""biuro-badan-spolecznych-question-mark-sp-z-o-o""
}
],
""value_min"": ""58056.00"",
""value_for_three"": 67650,
""value_for_one_eur"": 0,
""count"": ""1"",
""value_for_one"": 0,
""value_for_three_eur"": 14867.81,
""suppliers_id"": ""18263"",
""value_eur"": 14867.81,
""value_max"": ""73800.00"",
""offers_count"": [
3
],
""suppliers_name"": ""Biuro Badań Społecznych Question Mark sp. z o.o."",
""value"": ""67650.00"",
""value_estimated"": ""56733.33"",
""offers_count_data"": {
""3"": {
""value_eur"": 14867.81,
""count"": ""1"",
""value"": ""67650.00""
}
}
},
{
""date"": ""2021-09-15"",
""value_for_two"": 0,
""value_for_two_eur"": 0,
""suppliers"": [
{
""name"": ""Centrum Badań Marketingowych Indicator sp. z o.o."",
""id"": 19238,
""slug"": ""centrum-badan-marketingowych-indicator-sp-z-o-o""
}
],
""value_min"": ""67650.00"",
""value_for_three"": 0,
""value_for_one_eur"": 0,
""count"": ""1"",
""value_for_one"": 0,
""value_for_three_eur"": 0,
""suppliers_id"": ""19238"",
""value_eur"": 23112.68,
""value_max"": ""135300.00"",
""offers_count"": [
4
],
""suppliers_name"": ""Centrum Badań Marketingowych Indicator sp. z o.o."",
""value"": ""105165.00"",
""value_estimated"": ""65557.14"",
""offers_count_data"": {
""4"": {
""value_eur"": 23112.68,
""count"": ""1"",
""value"": ""105165.00""
}
}
},
{
""date"": ""2021-09-15"",
""value_for_two"": 0,
""value_for_two_eur"": 0,
""suppliers"": [
{
""name"": ""Openfield sp. z o.o."",
""id"": 2659,
""slug"": ""openfield-sp-z-o-o""
}
],
""value_min"": ""19680.00"",
""value_for_three"": 22878,
""value_for_one_eur"": 0,
""count"": ""1"",
""value_for_one"": 0,
""value_for_three_eur"": 5028.02,
""suppliers_id"": ""2659"",
""value_eur"": 5028.02,
""value_max"": ""35178.00"",
""offers_count"": [
3
],
""suppliers_name"": ""Openfield sp. z o.o."",
""value"": ""22878.00"",
""value_estimated"": ""18866.67"",
""offers_count_data"": {
""3"": {
""value_eur"": 5028.02,
""count"": ""1"",
""value"": ""22878.00""
}
}
}
]
},
{
""id"": ""566898"",
""date"": ""2021-08-05"",
""deadline_date"": ""2021-08-20"",
""deadline_length_days"": ""14"",
""deadline_length_hours"": ""356"",
""title"": ""Przebudowa ul. Rodła"",
""category"": ""constructions"",
""description"": ""Przebudowa ul. Rodła w Pile obejmuje odcinek od ul. Podchorążych do ul. Zesłańców Sybiru. Długość przebudowywanego odcinka wynosi 406,36 m.Przedmiot zamówienia obejmuje przebudowę drogi gminnej klasy D (dojazdowa) wraz z budową infrastruktury w postaci chodników, ciągu pieszo-rowerowego, miejsc postojowych dla samochodów osobowych oraz przebudowę zjazdów graniczących z pasem drogowym ul. Rodła. Ponadto w ramach inwestycji przewiduje się rozbudowę kanalizacji deszczowej oraz wykonanie oświetlenia"",
""sid"": ""info:123594"",
""awarded_value"": ""2101196.63"",
""awarded_currency"": ""PLN"",
""awarded_value_eur"": ""461375.57"",
""purchaser"": {
""id"": ""26878"",
""sid"": null,
""name"": null
},
""type"": {
""id"": ""art-275-pkt-1-ustawy"",
""name"": ""art. 275 pkt 1 ustawy"",
""slug"": ""art-275-pkt-1-ustawy""
},
""awarded"": [
{
""date"": ""2021-09-14"",
""value_for_two"": 2101196.63,
""value_for_two_eur"": 461375.57,
""suppliers"": [
{
""name"": ""POL DRÓG Drawsko Pomorskie S.A."",
""id"": 1007,
""slug"": ""pol-drog-drawsko-pomorskie-s-a""
}
],
""value_min"": ""2101196.63"",
""value_for_three"": 2101196.63,
""offers_count_status"": ""only_one"",
""value_for_one_eur"": 461375.57,
""count"": ""1"",
""value_for_one"": 2101196.63,
""value_for_three_eur"": 461375.57,
""suppliers_id"": ""1007"",
""value_eur"": 461375.57,
""value_max"": ""2101196.63"",
""offers_count"": [
1
],
""suppliers_name"": ""POL DRÓG Drawsko Pomorskie S.A."",
""value"": ""2101196.63"",
""value_estimated"": null,
""offers_count_data"": {
""1"": {
""value_eur"": 461375.57,
""count"": ""1"",
""value"": ""2101196.63""
}
}
}
]
},
{
""id"": ""564371"",
""date"": ""2021-06-29"",
""deadline_date"": ""2021-07-12"",
""deadline_length_days"": ""12"",
""deadline_length_hours"": ""311"",
""title"": ""Opracowanie dokumentacji projektowej dla zadania pn. \""Rozbudowa drogi wojewódzkiej nr 179 Szydłowo -Dolaszewo wraz z budową ścieżki rowerowej\""."",
""category"": ""services"",
""description"": ""1. Przedmiotem zamówienia jest usługa wykonania dokumentacji projektowej wraz z uzyskaniem wszystkich niezbędnych decyzji i uzgodnień w tym decyzji ZRiD w ramach zadania pn. „Rozbudowa drogi wojewódzkiej nr 179 Szydłowo – Dolaszewo wraz z budową ścieżki rowerowej”.2. Rozbudową należy objąć odcinek drogi wojewódzkiej nr 179 na odcinku od przejazdu kolejowego (km ok. 25+420) w m. Szydłowo do skrzyżowania drogi wojewódzkiej DW 179 z ul. Kasztanową w m. Dolaszewo.3. Rozwiązania projektowe należy pow"",
""sid"": ""info:118647"",
""awarded_value"": ""289000.00"",
""awarded_currency"": ""PLN"",
""awarded_value_eur"": ""64111.10"",
""purchaser"": {
""id"": ""22970"",
""sid"": null,
""name"": null
},
""type"": {
""id"": ""art-275-pkt-2-ustawy"",
""name"": ""art. 275 pkt 2 ustawy"",
""slug"": ""art-275-pkt-2-ustawy""
},
""awarded"": [
{
""date"": ""2021-09-01"",
""value_for_two"": 289000,
""value_for_two_eur"": 64111.1,
""suppliers"": [
{
""name"": ""Pracownia Projektowa DROG-CAD Maciej Nowak"",
""id"": 14579,
""slug"": ""pracownia-projektowa-drog-cad-maciej-nowak""
}
],
""value_min"": ""289000.00"",
""value_for_three"": 289000,
""offers_count_status"": ""only_one"",
""value_for_one_eur"": 64111.1,
""count"": ""1"",
""value_for_one"": 289000,
""value_for_three_eur"": 64111.1,
""suppliers_id"": ""14579"",
""value_eur"": 64111.1,
""value_max"": ""289000.00"",
""offers_count"": [
1
],
""suppliers_name"": ""Pracownia Projektowa DROG-CAD Maciej Nowak"",
""value"": ""289000.00"",
""value_estimated"": null,
""offers_count_data"": {
""1"": {
""value_eur"": 64111.1,
""count"": ""1"",
""value"": ""289000.00""
}
}
}
]
},
{
""id"": ""564370"",
""date"": ""2021-07-19"",
""deadline_date"": ""2021-08-03"",
""deadline_length_days"": ""15"",
""deadline_length_hours"": ""360"",
""title"": ""Remont drogi gminnej nr G131154P na odcinku Leżenica-Leżenica Kolonia-Jaraczewo"",
""category"": ""constructions"",
""description"": ""1. Przedmiotem zamówienia są roboty budowlane polegające na remoncie drogi gminnej nr G131154P na odcinku Leżenica – Leżenica Kolonia – Jaraczewo. Projektowana droga zlokalizowana jest w miejscowości Leżenica Kolonia w ciągu drogi gminnej G131154P Leżenica - Jaraczewo na działkach ewidencyjnych 330, 171, 206. Istniejący pas drogowy o szerokości zmiennej od 9,7m do 17,8m. Droga obsługuje zlokalizowane przy drodze budynki jednorodzinne, gospodarstwa rolne ( dojazd do pól uprawnych). Teren jest pła"",
""sid"": ""info:118646"",
""awarded_value"": ""446676.71"",
""awarded_currency"": ""PLN"",
""awarded_value_eur"": ""99089.74"",
""purchaser"": {
""id"": ""22970"",
""sid"": null,
""name"": null
},
""type"": {
""id"": ""art-275-pkt-2-ustawy"",
""name"": ""art. 275 pkt 2 ustawy"",
""slug"": ""art-275-pkt-2-ustawy""
},
""awarded"": [
{
""date"": ""2021-09-01"",
""value_for_two"": 0,
""value_for_two_eur"": 0,
""suppliers"": [
{
""name"": ""Roboty Drogowo - Budowlane Jacek Karpinski"",
""id"": 17719,
""slug"": ""roboty-drogowo-budowlane-jacek-karpinski""
}
],
""value_min"": ""446676.71"",
""value_for_three"": 446676.71,
""value_for_one_eur"": 0,
""count"": ""1"",
""value_for_one"": 0,
""value_for_three_eur"": 99089.74,
""suppliers_id"": ""17719"",
""value_eur"": 99089.74,
""value_max"": ""467014.44"",
""offers_count"": [
3
],
""suppliers_name"": ""Roboty Drogowo - Budowlane Jacek Karpinski"",
""value"": ""446676.71"",
""value_estimated"": null,
""offers_count_data"": {
""3"": {
""value_eur"": 99089.74,
""count"": ""1"",
""value"": ""446676.71""
}
}
}
]
},
{
""id"": ""564369"",
""date"": ""2021-07-23"",
""deadline_date"": ""2021-08-10"",
""deadline_length_days"": ""18"",
""deadline_length_hours"": ""434"",
""title"": ""Przebudowa drogi gminnej w m. Leżenica"",
""category"": ""constructions"",
""description"": ""1. Przedmiotem zamówienia jest realizacja zadania „Przebudowa drogi gminnej w miejscowości Leżenica na działkach 89/8, 89/4 i 224. Istniejąca droga w Leżenicy przebiega przez działki będące własnością gminy Szydłowo (dz. nr 89/8, 89/4, 224) wraz z wpięciami w drogę powiatową (dz. nr 1166P). Projektowana trasa maksymalnie wpisuje się w jej istniejący przebieg. Lokalizacja zadania wg załącznika graficznego - zakres wydzielony linią koloru zielonego jest działką gminną.2. Początek oraz koniec przeb"",
""sid"": ""info:118645"",
""awarded_value"": ""168760.00"",
""awarded_currency"": ""PLN"",
""awarded_value_eur"": ""37437.33"",
""purchaser"": {
""id"": ""22970"",
""sid"": null,
""name"": null
},
""type"": {
""id"": ""art-275-pkt-2-ustawy"",
""name"": ""art. 275 pkt 2 ustawy"",
""slug"": ""art-275-pkt-2-ustawy""
},
""awarded"": [
{
""date"": ""2021-09-01"",
""value_for_two"": 168760,
""value_for_two_eur"": 37437.33,
""suppliers"": [
{
""name"": ""Roboty Drogowo - Budowlane Jacek Karpinski"",
""id"": 17719,
""slug"": ""roboty-drogowo-budowlane-jacek-karpinski""
}
],
""value_min"": ""168760.00"",
""value_for_three"": 168760,
""offers_count_status"": ""only_one"",
""value_for_one_eur"": 37437.33,
""count"": ""1"",
""value_for_one"": 168760,
""value_for_three_eur"": 37437.33,
""suppliers_id"": ""17719"",
""value_eur"": 37437.33,
""value_max"": ""168760.00"",
""offers_count"": [
1
],
""suppliers_name"": ""Roboty Drogowo - Budowlane Jacek Karpinski"",
""value"": ""168760.00"",
""value_estimated"": null,
""offers_count_data"": {
""1"": {
""value_eur"": 37437.33,
""count"": ""1"",
""value"": ""168760.00""
}
}
}
]
},
{
""id"": ""564368"",
""date"": ""2021-07-30"",
""deadline_date"": ""2021-08-16"",
""deadline_length_days"": ""16"",
""deadline_length_hours"": ""401"",
""title"": ""Budowa wiaty magazynowej na terenie Zakładu Unieszkodliwiania Odpadów w Siedliskach k/Ełku"",
""category"": ""constructions"",
""description"": ""1. Przedmiotem zamówienia jest Budowa wiaty magazynowej na terenie Zakładu Unieszkodliwiania Odpadów w Siedliskach k/Ełku.2. Szczegółowy opis przedmiotu zmówienia określony jest w załączniku nr 9 do SWZ.3. Zaleca się, aby Wykonawca zapoznał się z lokalnymi warunkami realizacji przedmiotu zamówienia oraz zdobył wszelkie informacje niezbędne do właściwego przygotowania oferty i prawidłowego wykonania robót objętych przedmiotem zamówienia. Wszelkie utrudnienia wynikające z warunków realizacji przed"",
""sid"": ""info:118644"",
""awarded_value"": ""582751.95"",
""awarded_currency"": ""PLN"",
""awarded_value_eur"": ""129276.35"",
""purchaser"": {
""id"": ""24647"",
""sid"": null,
""name"": null
},
""type"": {
""id"": ""art-275-pkt-1-ustawy"",
""name"": ""art. 275 pkt 1 ustawy"",
""slug"": ""art-275-pkt-1-ustawy""
},
""awarded"": [
{
""date"": ""2021-09-01"",
""value_for_two"": 0,
""value_for_two_eur"": 0,
""suppliers"": [
{
""name"": ""„PRIBO-EPB” Sp. z o.o.,"",
""id"": 20459,
""slug"": ""pribo-epb-sp-z-o-o""
}
],
""value_min"": ""582751.95"",
""value_for_three"": 582751.95,
""value_for_one_eur"": 0,
""count"": ""1"",
""value_for_one"": 0,
""value_for_three_eur"": 129276.35,
""suppliers_id"": ""20459"",
""value_eur"": 129276.35,
""value_max"": ""832486.83"",
""offers_count"": [
3
],
""suppliers_name"": ""„PRIBO-EPB” Sp. z o.o.,"",
""value"": ""582751.95"",
""value_estimated"": null,
""offers_count_data"": {
""3"": {
""value_eur"": 129276.35,
""count"": ""1"",
""value"": ""582751.95""
}
}
}
]
},
{
""id"": ""569042"",
""date"": ""2021-07-29"",
""deadline_date"": ""2021-08-06"",
""deadline_length_days"": ""7"",
""deadline_length_hours"": ""191"",
""title"": ""\""Dostawa żywienia pozajelitowego wraz z dzierżawą loży laminarnej oraz dostawa żywienia dojelitowego na rzecz Szpitala Czerniakowskiego sp. z o.o.\"""",
""category"": ""supplies"",
""description"": ""Przedmiotem zamówienia jest dostawa żywienia pozajelitowego wraz z dzierżawą loży laminarnej oraz dostawa żywienia dojelitowego na rzecz Szpitala Czerniakowskiego sp. z o.o.: Pakiet nr 1 – Żywienie pozajelitowe wraz z dzierżawą loży laminarnej, zgodnie z załącznikiem nr 3 do SWZ – formularz asortymentowo-cenowy."",
""sid"": ""info:127811"",
""awarded_value"": ""109287.68"",
""awarded_currency"": ""PLN"",
""awarded_value_eur"": ""23969.53"",
""purchaser"": {
""id"": ""24381"",
""sid"": null,
""name"": null
},
""type"": {
""id"": ""art-275-pkt-1-ustawy"",
""name"": ""art. 275 pkt 1 ustawy"",
""slug"": ""art-275-pkt-1-ustawy""
},
""indicators"": [
""low_value_awarded""
],
""awarded"": [
{
""date"": ""2021-08-31"",
""value_for_two"": 41491.13,
""value_for_two_eur"": 9160,
""suppliers"": [
{
""name"": ""Bialmed sp. z o.o."",
""id"": 12,
""slug"": ""bialmed-sp-z-o-o""
}
],
""value_min"": ""41491.13"",
""value_for_three"": 41491.13,
""offers_count_status"": ""only_one"",
""value_for_one_eur"": 9160,
""count"": ""1"",
""value_for_one"": 41491.13,
""value_for_three_eur"": 9160,
""suppliers_id"": ""12"",
""value_eur"": 9160,
""value_max"": ""41491.13"",
""offers_count"": [
1
],
""suppliers_name"": ""Bialmed sp. z o.o."",
""value"": ""41491.13"",
""value_estimated"": ""45589.50"",
""offers_count_data"": {
""1"": {
""value_eur"": 9160,
""count"": ""1"",
""value"": ""41491.13""
}
}
},
{
""date"": ""2021-08-25"",
""value_for_two"": 67796.55,
""value_for_two_eur"": 14809.53,
""suppliers"": [
{
""name"": ""Fresenius Kabi Polska sp. z o.o."",
""id"": 32,
""slug"": ""fresenius-kabi-polska-sp-z-o-o""
}
],
""value_min"": ""67796.55"",
""value_for_three"": 67796.55,
""offers_count_status"": ""only_one"",
""value_for_one_eur"": 14809.53,
""count"": ""1"",
""value_for_one"": 67796.55,
""value_for_three_eur"": 14809.53,
""suppliers_id"": ""32"",
""value_eur"": 14809.53,
""value_max"": ""67796.55"",
""offers_count"": [
1
],
""suppliers_name"": ""Fresenius Kabi Polska sp. z o.o."",
""value"": ""67796.55"",
""value_estimated"": ""63170.12"",
""offers_count_data"": {
""1"": {
""value_eur"": 14809.53,
""count"": ""1"",
""value"": ""67796.55""
}
}
}
]
},
{
""id"": ""564330"",
""date"": ""2021-08-04"",
""deadline_date"": ""2021-08-19"",
""deadline_length_days"": ""15"",
""deadline_length_hours"": ""360"",
""title"": ""Remont pobocza przy drodze powiatowej Nr 3521L na odcinku Chorążanka - Przewłoka"",
""category"": ""constructions"",
""description"": ""Przedmiot zamówienia obejmuje wykonanie remontu pobocza przy drodze powiatowej Nr 3521L na odcinku Chorążanka - Przewłoka. Zakres opracowania od km 0+000 do km 1+232,00 na długości 1,232km.Zakres robót przedmiotowego zadania obejmuje:- wykonanie koryta pod warstwy konstrukcyjne wraz z profilowaniem i zagęszczeniem,- wykonanie warstw podbudowy z mieszanki cementowej oraz mieszanki mineralnej stabilizowanej mechanicznie,- wykonanie warstw bitumicznych,- wykonanie ulepszonego pobocza gruntowego,- u"",
""sid"": ""info:118578"",
""awarded_value"": ""498611.27"",
""awarded_currency"": ""PLN"",
""awarded_value_eur"": ""110078.43"",
""purchaser"": {
""id"": ""23752"",
""sid"": null,
""name"": null
},
""type"": {
""id"": ""art-275-pkt-1-ustawy"",
""name"": ""art. 275 pkt 1 ustawy"",
""slug"": ""art-275-pkt-1-ustawy""
},
""awarded"": [
{
""date"": ""2021-08-31"",
""value_for_two"": 498611.27,
""value_for_two_eur"": 110078.43,
""suppliers"": [
{
""name"": ""PRZEDSIĘBIORSTWO ROBÓT DROGOWO-MOSTOWYCH Sp. z o.o.,"",
""id"": 52,
""slug"": ""przedsiebiorstwo-robot-drogowo-mostowych-sp-z-o-o""
}
],
""value_min"": ""498611.27"",
""value_for_three"": 498611.27,
""offers_count_status"": ""only_one"",
""value_for_one_eur"": 110078.43,
""count"": ""1"",
""value_for_one"": 498611.27,
""value_for_three_eur"": 110078.43,
""suppliers_id"": ""52"",
""value_eur"": 110078.43,
""value_max"": ""498611.27"",
""offers_count"": [
1
],
""suppliers_name"": ""PRZEDSIĘBIORSTWO ROBÓT DROGOWO-MOSTOWYCH Sp. z o.o.,"",
""value"": ""498611.27"",
""value_estimated"": null,
""offers_count_data"": {
""1"": {
""value_eur"": 110078.43,
""count"": ""1"",
""value"": ""498611.27""
}
}
}
]
},
{
""id"": ""564248"",
""date"": ""2021-07-16"",
""deadline_date"": ""2021-07-28"",
""deadline_length_days"": ""11"",
""deadline_length_hours"": ""287"",
""title"": ""Dostawa sprzętu do utrzymania czystości"",
""category"": ""supplies"",
""description"": ""Przedmiotem zamówienia jest: Dostawa sprzętu do utrzymania czystości;Wykonawca zobowiązuje się dostarczyć towar określony w opisie przedmiotu zamówienia, i na warunkach określonych w umowie: Dostawa sprzętu do utrzymania czystości;1. Towar, stanowiący przedmiot umowy zostanie dostarczony jednym transportem i rozładowa-ny przez Wykonawcę na jego koszt i ryzyko w terminie ustalonym przez przedstawicieli obu stron, w miejscu wskazanym przez Zamawiającego – magazyn środków czystości – w m. Mirosławi"",
""sid"": ""info:118430"",
""awarded_value"": ""166766.50"",
""awarded_currency"": ""PLN"",
""awarded_value_eur"": ""36817.05"",
""purchaser"": {
""id"": ""23478"",
""sid"": null,
""name"": null
},
""type"": {
""id"": ""art-275-pkt-1-ustawy"",
""name"": ""art. 275 pkt 1 ustawy"",
""slug"": ""art-275-pkt-1-ustawy""
},
""indicators"": [
""declined""
],
""awarded"": [
{
""date"": ""2021-08-31"",
""value_for_two"": 0,
""value_for_two_eur"": 0,
""suppliers"": [
{
""name"": ""P.P.H TESS MAŁGORZATA I SŁAWOMIR MAKSYMOWICZ spółka jawna"",
""id"": 23075,
""slug"": ""p-p-h-tess-malgorzata-i-slawomir-maksymowicz-spolka-jawna""
}
],
""value_min"": ""145176.50"",
""value_for_three"": 0,
""value_for_one_eur"": 0,
""count"": ""1"",
""value_for_one"": 0,
""offers_declined"": [
4
],
""value_for_three_eur"": 0,
""suppliers_id"": ""23075"",
""value_eur"": 36817.05,
""value_max"": ""176243.30"",
""offers_count"": [
5
],
""suppliers_name"": ""P.P.H TESS MAŁGORZATA I SŁAWOMIR MAKSYMOWICZ spółka jawna"",
""value"": ""166766.50"",
""value_estimated"": null,
""offers_count_data"": {
""5"": {
""value_eur"": 36817.05,
""count"": ""1"",
""value"": ""166766.50""
}
}
}
]
},
{
""id"": ""564230"",
""date"": ""2021-08-16"",
""deadline_date"": ""2021-08-24"",
""deadline_length_days"": ""8"",
""deadline_length_hours"": ""194"",
""title"": ""Dostawa sprzętu 1x użytku uzupełnienie VII"",
""category"": ""supplies"",
""description"": ""Przedmiotem zamówienia jest dostawa sprzętu 1x użytku dla Zespołu Opieki Zdrowotnej w Suchej Beskidzkiej.Szczegółowy opis przedmiotu zamówienia zawiera załącznik nr 1a do specyfikacji. Opis ten należy odczytywać wraz z ewentualnymi zmianami treści specyfikacji, będącymi np. wynikiem udzielonych odpowiedzi na zapytania wykonawców."",
""sid"": ""info:118387"",
""awarded_value"": ""6588.00"",
""awarded_currency"": ""PLN"",
""awarded_value_eur"": ""1454.43"",
""purchaser"": {
""id"": ""110"",
""sid"": null,
""name"": null
},
""type"": {
""id"": ""art-275-pkt-1-ustawy"",
""name"": ""art. 275 pkt 1 ustawy"",
""slug"": ""art-275-pkt-1-ustawy""
},
""awarded"": [
{
""date"": ""2021-08-31"",
""value_for_two"": 6588,
""value_for_two_eur"": 1454.43,
""suppliers"": [
{
""name"": ""Varimed sp.zo.o."",
""id"": 19616,
""slug"": ""varimed-sp-zo-o""
}
],
""value_min"": ""6588.00"",
""value_for_three"": 6588,
""offers_count_status"": ""only_one"",
""value_for_one_eur"": 1454.43,
""count"": ""1"",
""value_for_one"": 6588,
""value_for_three_eur"": 1454.43,
""suppliers_id"": ""19616"",
""value_eur"": 1454.43,
""value_max"": ""6588.00"",
""offers_count"": [
1
],
""suppliers_name"": ""Varimed sp.zo.o."",
""value"": ""6588.00"",
""value_estimated"": null,
""offers_count_data"": {
""1"": {
""value_eur"": 1454.43,
""count"": ""1"",
""value"": ""6588.00""
}
}
}
]
},
{
""id"": ""564229"",
""date"": ""2021-08-05"",
""deadline_date"": ""2021-08-20"",
""deadline_length_days"": ""15"",
""deadline_length_hours"": ""362"",
""title"": ""Dostawa ziemniaków w okresie jesienno-wiosennym"",
""category"": ""supplies"",
""description"": ""Przedmiotem zamówienia jest dostawa ziemniaków do żywienia pacjentów i personelu w ilości 33 000 kg. Dostawca zobowiązany będzie do rozładunku ziemniaków w magazynie żywnościowym w Szpitalu w Suchej Beskidzkiej. Ziemniaki muszą być dobrej jakości – powinny charakteryzować się gładka powierzchnią, cienką łupiną, płytkimi oczkami, wyrównaną wielkością, powinny być zdrowe, równomiernie rozgotowywać się, nie czernieć po ugotowaniu, oraz być smaczne. Wielkość ziemniaków musi umożliwiać ich maszynowe "",
""sid"": ""info:118386"",
""awarded_value"": ""9900.00"",
""awarded_currency"": ""PLN"",
""awarded_value_eur"": ""2185.62"",
""purchaser"": {
""id"": ""110"",
""sid"": null,
""name"": null
},
""type"": {
""id"": ""art-275-pkt-1-ustawy"",
""name"": ""art. 275 pkt 1 ustawy"",
""slug"": ""art-275-pkt-1-ustawy""
},
""awarded"": [
{
""date"": ""2021-08-31"",
""value_for_two"": 9900,
""value_for_two_eur"": 2185.62,
""suppliers"": [
{
""name"": ""Przedsiębiorstwo Handlowo-Usługowe Wojciech Krasucki"",
""id"": 23068,
""slug"": ""przedsiebiorstwo-handlowo-uslugowe-wojciech-krasucki""
}
],
""value_min"": ""9900.00"",
""value_for_three"": 9900,
""value_for_one_eur"": 0,
""count"": ""1"",
""value_for_one"": 0,
""value_for_three_eur"": 2185.62,
""suppliers_id"": ""23068"",
""value_eur"": 2185.62,
""value_max"": ""37290.00"",
""offers_count"": [
2
],
""suppliers_name"": ""Przedsiębiorstwo Handlowo-Usługowe Wojciech Krasucki"",
""value"": ""9900.00"",
""value_estimated"": null,
""offers_count_data"": {
""2"": {
""value_eur"": 2185.62,
""count"": ""1"",
""value"": ""9900.00""
}
}
}
]
},
{
""id"": ""562905"",
""date"": ""2021-08-13"",
""deadline_date"": ""2021-08-25"",
""deadline_length_days"": ""12"",
""deadline_length_hours"": ""289"",
""title"": ""Usługi przygotowywania i dostarczania posiłków na potrzeby Zespołu Szkolno-Przedszkolnego w Nowym Aleksandrowie"",
""category"": ""services"",
""description"": ""1. Przedmiotem zamówienia są usługi przygotowywanie i dostarczania posiłków na potrzeby Zespołu Szkolno-Przedszkolnego w Nowym Aleksandrowie. 2. Szczegółowy opis przedmiotu zamówienia znajduje się w załączniku nr 1 do SWZ.3. Dostawy posiłków będą realizowane do budynku Zespołu Szkolno-Przedszkolnego w Nowym Aleksandrowie przy ul. Pogodnej 107, 16-002 Dobrzyniewo Duże."",
""sid"": ""info:116341"",
""awarded_value"": ""285757.04"",
""awarded_currency"": ""PLN"",
""awarded_value_eur"": ""63086.59"",
""purchaser"": {
""id"": ""32154"",
""sid"": null,
""name"": null
},
""type"": {
""id"": ""art-275-pkt-1-ustawy"",
""name"": ""art. 275 pkt 1 ustawy"",
""slug"": ""art-275-pkt-1-ustawy""
},
""awarded"": [
{
""date"": ""2021-08-31"",
""value_for_two"": 0,
""value_for_two_eur"": 0,
""suppliers"": [
{
""name"": ""Casablanca Catering sp. z o.o."",
""id"": 23153,
""slug"": ""casablanca-catering-sp-z-o-o""
}
],
""value_min"": ""285757.04"",
""value_for_three"": 285757.04,
""value_for_one_eur"": 0,
""count"": ""1"",
""value_for_one"": 0,
""value_for_three_eur"": 63086.59,
""suppliers_id"": ""23153"",
""value_eur"": 63086.59,
""value_max"": ""307047.20"",
""offers_count"": [
3
],
""suppliers_name"": ""Casablanca Catering sp. z o.o."",
""value"": ""285757.04"",
""value_estimated"": null,
""offers_count_data"": {
""3"": {
""value_eur"": 63086.59,
""count"": ""1"",
""value"": ""285757.04""
}
}
}
]
},
{
""id"": ""561531"",
""date"": ""2021-08-13"",
""deadline_date"": ""2021-08-23"",
""deadline_length_days"": ""9"",
""deadline_length_hours"": ""228"",
""title"": ""Przygotowanie i podanie posiłków w kuchni zamawiającego"",
""category"": ""services"",
""description"": "" Przedmiotem zamówienia są sukcesywne usługi przygotowania i podania posiłków dla mieszkańców Domu Pomocy Społecznej w Gniewie, kody CPV: 55322000-3, 55321000-6, 55523000-2. Zakres zadań Wykonawcy opisany został szczegółowo w Załączniku nr 1 do niniejszej Specyfikacji Warunków Zamówienia (zawierającym zakres usług oraz dane ilościowe składników niezbędnych do kalkulacji ceny oraz wymagania Zamawiającego względem przedmiotu zamówienia). Zakres usługi oraz dane ilościowe składników zamówienia p"",
""sid"": ""info:113384"",
""awarded_value"": ""413745.75"",
""awarded_currency"": ""PLN"",
""awarded_value_eur"": ""91342.67"",
""purchaser"": {
""id"": ""32038"",
""sid"": null,
""name"": null
},
""type"": {
""id"": ""art-275-pkt-2-ustawy"",
""name"": ""art. 275 pkt 2 ustawy"",
""slug"": ""art-275-pkt-2-ustawy""
},
""awarded"": [
{
""date"": ""2021-08-31"",
""value_for_two"": 413745.75,
""value_for_two_eur"": 91342.67,
""suppliers"": [
{
""name"": ""Bar Zamkowa Elżbieta Kołodziejczyk"",
""id"": 23084,
""slug"": ""bar-zamkowa-elzbieta-kolodziejczyk""
}
],
""value_min"": ""413745.75"",
""value_for_three"": 413745.75,
""value_for_one_eur"": 0,
""count"": ""1"",
""value_for_one"": 0,
""value_for_three_eur"": 91342.67,
""suppliers_id"": ""23084"",
""value_eur"": 91342.67,
""value_max"": ""643203.00"",
""offers_count"": [
2
],
""suppliers_name"": ""Bar Zamkowa Elżbieta Kołodziejczyk"",
""value"": ""413745.75"",
""value_estimated"": null,
""offers_count_data"": {
""2"": {
""value_eur"": 91342.67,
""count"": ""1"",
""value"": ""413745.75""
}
}
}
]
},
{
""id"": ""564314"",
""date"": ""2021-08-02"",
""deadline_date"": ""2021-08-11"",
""deadline_length_days"": ""8"",
""deadline_length_hours"": ""213"",
""title"": ""Sukcesywne dostawy kruszyw wraz z transportem i rozładunkiem"",
""category"": ""supplies"",
""description"": ""Część I – kruszywo łamane skalne bazaltowe o granulacji 4-31,5 mm (kliniec) Zapotrzebowanie w tonach - 300Gwarantowany zakup w - 10 %"",
""sid"": ""info:118553"",
""awarded_value"": ""519918.70"",
""awarded_currency"": ""PLN"",
""awarded_value_eur"": ""113822.56"",
""purchaser"": {
""id"": ""29812"",
""sid"": null,
""name"": null
},
""type"": {
""id"": ""art-275-pkt-1-ustawy"",
""name"": ""art. 275 pkt 1 ustawy"",
""slug"": ""art-275-pkt-1-ustawy""
},
""awarded"": [
{
""date"": ""2021-08-30"",
""value_for_two"": 519918.7,
""value_for_two_eur"": 113822.56,
""suppliers"": [
{
""name"": ""Przedsiębiorstwo Wielobranżowe RASPOL Roman Skoczek"",
""id"": 23088,
""slug"": ""przedsiebiorstwo-wielobranzowe-raspol-roman-skoczek""
}
],
""value_min"": ""519918.70"",
""value_for_three"": 519918.7,
""offers_count_status"": ""only_one"",
""value_for_one_eur"": 113822.56,
""count"": ""5"",
""value_for_one"": 519918.7,
""value_for_three_eur"": 113822.56,
""suppliers_id"": ""23088"",
""value_eur"": 113822.56,
""value_max"": ""519918.70"",
""offers_count"": [
1
],
""suppliers_name"": ""Przedsiębiorstwo Wielobranżowe RASPOL Roman Skoczek"",
""value"": ""519918.70"",
""value_estimated"": ""519918.70"",
""offers_count_data"": {
""1"": {
""value_eur"": 113822.56,
""count"": ""5"",
""value"": ""519918.70""
}
}
}
]
},
{
""id"": ""564245"",
""date"": ""2021-07-26"",
""deadline_date"": ""2021-08-06"",
""deadline_length_days"": ""10"",
""deadline_length_hours"": ""263"",
""title"": ""Sprawowanie bezpośredniej opieki, tzw. opieka wytchnieniowa, nad dziećmi i osobaminiepełnosprawnymi na terenie Gminy i Miasta Czerwionka-Leszczyny"",
""category"": ""services"",
""description"": ""1. Przedmiotem zamówienia jest sprawowanie bezpośredniej opieki, tzw. opieka wytchnieniowa, nad dziećmi i osobami niepełnosprawnymi w zastępstwie członków rodzin lub opiekunów sprawujących bezpośrednią, stałą i długotrwałą opiekę nad tymi osobami na terenie Gminy i Miasta Czerwionka-Leszczyny.2. Usługi w ramach opieki wytchnieniowej kierowane będą do członków rodzin lub opiekunów, którzy wymagają wsparcia w postaci doraźnej, czasowej przerwy w sprawowaniu bezpośredniej opieki nad dziećmi z orzec"",
""sid"": ""info:118418"",
""awarded_value"": ""48000.00"",
""awarded_currency"": ""PLN"",
""awarded_value_eur"": ""10508.34"",
""purchaser"": {
""id"": ""24379"",
""sid"": null,
""name"": null
},
""type"": {
""id"": ""art-275-pkt-1-ustawy"",
""name"": ""art. 275 pkt 1 ustawy"",
""slug"": ""art-275-pkt-1-ustawy""
},
""awarded"": [
{
""date"": ""2021-08-30"",
""value_for_two"": 48000,
""value_for_two_eur"": 10508.34,
""suppliers"": [
{
""name"": ""Śląski Oddział Okręgowy Polskiego Czerwonego Krzyża Oddział Rejonowy Polskiego Czerwonego Krzyża w Knurowie"",
""id"": 23072,
""slug"": ""slaski-oddzial-okregowy-polskiego-czerwonego-krzyza-oddzial-rejonowy-polskiego-czerwonego-krzyza-w-knurowie""
}
],
""value_min"": ""48000.00"",
""value_for_three"": 48000,
""offers_count_status"": ""only_one"",
""value_for_one_eur"": 10508.34,
""count"": ""1"",
""value_for_one"": 48000,
""value_for_three_eur"": 10508.34,
""suppliers_id"": ""23072"",
""value_eur"": 10508.34,
""value_max"": ""48000.00"",
""offers_count"": [
1
],
""suppliers_name"": ""Śląski Oddział Okręgowy Polskiego Czerwonego Krzyża Oddział Rejonowy Polskiego Czerwonego Krzyża w Knurowie"",
""value"": ""48000.00"",
""value_estimated"": null,
""offers_count_data"": {
""1"": {
""value_eur"": 10508.34,
""count"": ""1"",
""value"": ""48000.00""
}
}
}
]
},
{
""id"": ""564243"",
""date"": ""2021-07-26"",
""deadline_date"": ""2021-08-05"",
""deadline_length_days"": ""9"",
""deadline_length_hours"": ""238"",
""title"": ""Świadczenie usług Asystenta Osobistego Osoby Niepełnosprawnej dla osób niepełnosprawnych z terenu Gminy i Miasta Czerwionka-Leszczyny"",
""category"": ""services"",
""description"": ""1. Przedmiotem zamówienia jest świadczenie usług asystenta osobistego osoby niepełnosprawnej na rzecz osób niepełnosprawnych z terenu Gminy i Miasta Czerwionka-Leszczyny.2. Usługami asystenta zostaną objęte osoby z niepełnosprawnościami posiadającymi orzeczenie o znacznym stopniu niepełnosprawności oraz orzeczenie o umiarkowanym stopniu niepełnosprawności wydanych na podstawie ustawy z dnia 27 sierpnia 1997 r. o rehabilitacji zawodowej i społecznej oraz zatrudnianiu osób niepełnosprawnych albo o"",
""sid"": ""info:118415"",
""awarded_value"": ""110400.00"",
""awarded_currency"": ""PLN"",
""awarded_value_eur"": ""24169.18"",
""purchaser"": {
""id"": ""24379"",
""sid"": null,
""name"": null
},
""type"": {
""id"": ""art-275-pkt-1-ustawy"",
""name"": ""art. 275 pkt 1 ustawy"",
""slug"": ""art-275-pkt-1-ustawy""
},
""awarded"": [
{
""date"": ""2021-08-30"",
""value_for_two"": 110400,
""value_for_two_eur"": 24169.18,
""suppliers"": [
{
""name"": ""Śląski Oddział Okręgowy Polskiego Czerwonego Krzyża Oddział Rejonowy Polskiego Czerwonego Krzyża w Knurowie"",
""id"": 23072,
""slug"": ""slaski-oddzial-okregowy-polskiego-czerwonego-krzyza-oddzial-rejonowy-polskiego-czerwonego-krzyza-w-knurowie""
}
],
""value_min"": ""110400.00"",
""value_for_three"": 110400,
""offers_count_status"": ""only_one"",
""value_for_one_eur"": 24169.18,
""count"": ""1"",
""value_for_one"": 110400,
""value_for_three_eur"": 24169.18,
""suppliers_id"": ""23072"",
""value_eur"": 24169.18,
""value_max"": ""110400.00"",
""offers_count"": [
1
],
""suppliers_name"": ""Śląski Oddział Okręgowy Polskiego Czerwonego Krzyża Oddział Rejonowy Polskiego Czerwonego Krzyża w Knurowie"",
""value"": ""110400.00"",
""value_estimated"": null,
""offers_count_data"": {
""1"": {
""value_eur"": 24169.18,
""count"": ""1"",
""value"": ""110400.00""
}
}
}
]
},
{
""id"": ""564237"",
""date"": ""2021-07-30"",
""deadline_date"": ""2021-08-16"",
""deadline_length_days"": ""17"",
""deadline_length_hours"": ""408"",
""title"": ""Wzbogacenie oferty spędzania wolnego czasu poprzez budowę i wyznaczenie szlaków rowerowych wraz z nowymi obiektami infrastruktury turystyczno-rekreacyjnej w gminie Wietrzychowice"",
""category"": ""constructions"",
""description"": ""Część 1 – Wzbogacenie oferty spędzania wolnego czasu poprzez budowę i wyznaczenie szlaków rowerowych wraz z nowymi obiektami infrastruktury turystyczno-rekreacyjnej w miejscowości Miechowice Małe, Gmina Wietrzychowice – zakres prac obejmuje: budowę wiaty z drewna wraz z wykonaniem pod nią utwardzenia z płyt betonowych oraz podłogi na legarach z desek, oznakowanie szlaku rowerowego, wykonanie ścieżki rowerowej z betonu asfaltowego, wraz z geodezją powykonawczą."",
""sid"": ""info:118400"",
""awarded_value"": ""627621.97"",
""awarded_currency"": ""PLN"",
""awarded_value_eur"": ""137401.37"",
""purchaser"": {
""id"": ""32280"",
""sid"": null,
""name"": null
},
""type"": {
""id"": ""art-275-pkt-1-ustawy"",
""name"": ""art. 275 pkt 1 ustawy"",
""slug"": ""art-275-pkt-1-ustawy""
},
""awarded"": [
{
""date"": ""2021-08-30"",
""value_for_two"": 627621.97,
""value_for_two_eur"": 137401.37,
""suppliers"": [
{
""name"": ""Firma Handlowo - Usługowa EL - BUD Leszek Wójcik"",
""id"": 23070,
""slug"": ""firma-handlowo-uslugowa-el-bud-leszek-wojcik""
}
],
""value_min"": ""627621.97"",
""value_for_three"": 627621.97,
""offers_count_status"": ""only_one"",
""value_for_one_eur"": 137401.37,
""count"": ""2"",
""value_for_one"": 627621.97,
""value_for_three_eur"": 137401.37,
""suppliers_id"": ""23070"",
""value_eur"": 137401.37,
""value_max"": ""627621.97"",
""offers_count"": [
1
],
""suppliers_name"": ""Firma Handlowo - Usługowa EL - BUD Leszek Wójcik"",
""value"": ""627621.97"",
""value_estimated"": ""469002.59"",
""offers_count_data"": {
""1"": {
""value_eur"": 137401.37,
""count"": ""2"",
""value"": ""627621.97""
}
}
}
]
},
{
""id"": ""564161"",
""date"": ""2021-07-22"",
""deadline_date"": ""2021-08-02"",
""deadline_length_days"": ""11"",
""deadline_length_hours"": ""264"",
""title"": ""Dostawa sprzętu elektronicznego na potrzeby Zespołu Szkół w Dąbrowie Białostockiej."",
""category"": ""supplies"",
""description"": ""Przedmiotem dostawy jest fabrycznie nowy, nieużywany, wolny od wad i kompletny tj.posiadający wszelkie akcesoria, przewody, kable niezbędne do ich użytkowania. Zaoferowanysprzęt musi być kompletny i gotowy do użytkowania bez dodatkowych zakupów., do ZespołuSzkół w Dąbrowie Białostockiej. Dostawa obejmuje:1) Komputer stacjonarny typu All in One – 1 szt.2) Projektor - 1 szt.3) Uchwyt ścienny do projektora – 1 szt.4) Ekran elektryczny– 1 szt.5) Amplituner– 1 szt.6) Głośniki– 2 szt.7) Kamera do wide"",
""sid"": ""info:118272"",
""awarded_value"": ""34169.57"",
""awarded_currency"": ""PLN"",
""awarded_value_eur"": ""7480.53"",
""purchaser"": {
""id"": ""29984"",
""sid"": null,
""name"": null
},
""type"": {
""id"": ""art-275-pkt-1-ustawy"",
""name"": ""art. 275 pkt 1 ustawy"",
""slug"": ""art-275-pkt-1-ustawy""
},
""awarded"": [
{
""date"": ""2021-08-30"",
""value_for_two"": 34169.57,
""value_for_two_eur"": 7480.53,
""suppliers"": [
{
""name"": ""ALLTECH S.J. ZDZISŁAW PAJĄK, ARTUR PAJĄK"",
""id"": 150,
""slug"": ""alltech-s-j-zdzislaw-pajak-artur-pajak""
}
],
""value_min"": ""34169.57"",
""value_for_three"": 34169.57,
""value_for_one_eur"": 0,
""count"": ""1"",
""value_for_one"": 0,
""value_for_three_eur"": 7480.53,
""suppliers_id"": ""150"",
""value_eur"": 7480.53,
""value_max"": ""35182.84"",
""offers_count"": [
2
],
""suppliers_name"": ""ALLTECH S.J. ZDZISŁAW PAJĄK, ARTUR PAJĄK"",
""value"": ""34169.57"",
""value_estimated"": null,
""offers_count_data"": {
""2"": {
""value_eur"": 7480.53,
""count"": ""1"",
""value"": ""34169.57""
}
}
}
]
},
{
""id"": ""559820"",
""date"": ""2021-06-09"",
""deadline_date"": ""2021-06-25"",
""deadline_length_days"": ""15"",
""deadline_length_hours"": ""381"",
""title"": ""Modernizacja budynku Przedszkola Samorządowego nr 7 w Piotrkowie Trybunalskim"",
""category"": ""constructions"",
""description"": ""1) Modernizacja budynku Przedszkola Samorządowego nr 7, 97-300 Piotrków Trybunalski ul. Poprzeczna 7 a ETAP I – obejmujący roboty remontowe:1. modernizacja zewnętrznej strefy wejściowej do budynku przedszkola,2. utwardzenia terenu przed budynkiem, remont ogrodzenia, modernizacja pochylni wraz zabudową obiektów małej architektury,3. remont tarasów, schodów zewnętrznych,4. termomodernizacja dachu budynku wraz z wymianą poszycia dachowego oraz obróbką blacharską, orynnowaniem, remontem kominów, ogn"",
""sid"": ""info:109244"",
""awarded_value"": ""712822.12"",
""awarded_currency"": ""PLN"",
""awarded_value_eur"": ""156053.71"",
""purchaser"": {
""id"": ""2524"",
""sid"": null,
""name"": null
},
""type"": {
""id"": ""art-275-pkt-1-ustawy"",
""name"": ""art. 275 pkt 1 ustawy"",
""slug"": ""art-275-pkt-1-ustawy""
},
""awarded"": [
{
""date"": ""2021-08-30"",
""value_for_two"": 712822.12,
""value_for_two_eur"": 156053.71,
""suppliers"": [
{
""name"": ""D&F Spółka z o.o."",
""id"": 20079,
""slug"": ""d-f-spolka-z-o-o""
}
],
""value_min"": ""712822.12"",
""value_for_three"": 712822.12,
""offers_count_status"": ""only_one"",
""value_for_one_eur"": 156053.71,
""count"": ""1"",
""value_for_one"": 712822.12,
""value_for_three_eur"": 156053.71,
""suppliers_id"": ""20079"",
""value_eur"": 156053.71,
""value_max"": ""712822.12"",
""offers_count"": [
1
],
""suppliers_name"": ""D&F Spółka z o.o."",
""value"": ""712822.12"",
""value_estimated"": null,
""offers_count_data"": {
""1"": {
""value_eur"": 156053.71,
""count"": ""1"",
""value"": ""712822.12""
}
}
}
]
},
{
""id"": ""567400"",
""date"": ""2021-06-28"",
""deadline_date"": ""2021-07-14"",
""deadline_length_days"": ""15"",
""deadline_length_hours"": ""382"",
""title"": ""Przebudowa drogi gminnej Nr 115164E relacji Wola Pękoszewska - Niemieryczew"",
""category"": ""constructions"",
""description"": ""Przedmiotem zamówienia jest przebudowa drogi gminnej Nr 115164E relacji Wola Pękoszewska - Niemieryczew o łącznej długości 1,409 km. Lokalizacja:Obręb Wola Pękoszewska (23) – dz. ewid. nr 30.Parametry drogi: kategoria drogi - G (gminna) klasa drogi - D (dojazdowa) prędkość projektowa – 30 km/h kategoria ruchu – KR2 długość jezdni - 1,409 km szerokość jezdni – 4,00 m  szerokość poboczy – 0,75 mParametry jezdni i mijanki: warstwa ścieralna z betonu asfaltowego AC11S dla KR 2 gr. 4 cm wars"",
""sid"": ""info:124554"",
""awarded_value"": ""902397.68"",
""awarded_currency"": ""PLN"",
""awarded_value_eur"": ""196913.98"",
""purchaser"": {
""id"": ""32603"",
""sid"": null,
""name"": null
},
""type"": {
""id"": ""art-275-pkt-1-ustawy"",
""name"": ""art. 275 pkt 1 ustawy"",
""slug"": ""art-275-pkt-1-ustawy""
},
""awarded"": [
{
""date"": ""2021-08-27"",
""value_for_two"": 0,
""value_for_two_eur"": 0,
""suppliers"": [
{
""name"": ""Przedsiębiorstwo Budowy Dróg i Mostów „Erbedim” Sp. z o.o."",
""id"": 16402,
""slug"": ""przedsiebiorstwo-budowy-drog-i-mostow-erbedim-sp-z-o-o""
}
],
""value_min"": ""695786.86"",
""value_for_three"": 0,
""value_for_one_eur"": 0,
""count"": ""1"",
""value_for_one"": 0,
""offers_declined"": [
1
],
""value_for_three_eur"": 0,
""suppliers_id"": ""16402"",
""value_eur"": 196913.98,
""value_max"": ""1134250.47"",
""offers_count"": [
6
],
""suppliers_name"": ""Przedsiębiorstwo Budowy Dróg i Mostów „Erbedim” Sp. z o.o."",
""value"": ""902397.68"",
""value_estimated"": null,
""offers_count_data"": {
""6"": {
""value_eur"": 196913.98,
""count"": ""1"",
""value"": ""902397.68""
}
}
}
]
},
{
""id"": ""564338"",
""date"": ""2021-07-16"",
""deadline_date"": ""2021-08-03"",
""deadline_length_days"": ""17"",
""deadline_length_hours"": ""430"",
""title"": ""Wymiana źródła ciepła i instalacji centralnego ogrzewania, ciepłej wody użytkowej oraz wod-kan w budynku przy ul. Parkowej 10 w Rogowie"",
""category"": ""constructions"",
""description"": ""1. Przedmiotem zamówienia są roboty budowlane obejmujące wykonanie zadania pn.: „Wymiana źródła ciepła i instalacji centralnego ogrzewania, ciepłej wody użytkowej oraz wod-kan w budynku przy ul. Parkowej 10 w Rogowie”. Roboty budowlane realizowane będą na podstawie dokumentacji projektowej wykonanej przez Chowaniec Barbarę Biuro Projektowe „SANWEKO” z Rydułtów oraz decyzji o pozwoleniu na budowę nr 0196/21 z dnia 12.02.2021 r.2. Zakres robót obejmuje:1) demontaż przewodów c.o. i grzejników,2) de"",
""sid"": ""info:118593"",
""awarded_value"": ""205510.33"",
""awarded_currency"": ""PLN"",
""awarded_value_eur"": ""44844.81"",
""purchaser"": {
""id"": ""3949"",
""sid"": null,
""name"": null
},
""type"": {
""id"": ""art-275-pkt-1-ustawy"",
""name"": ""art. 275 pkt 1 ustawy"",
""slug"": ""art-275-pkt-1-ustawy""
},
""awarded"": [
{
""date"": ""2021-08-27"",
""value_for_two"": 0,
""value_for_two_eur"": 0,
""suppliers"": [
{
""name"": ""Przedsiebiorstwo Handlowo-Usługowe \""WIMAR\"" Spółka jawna Wiesław i Mariusz Słanina"",
""id"": 23093,
""slug"": ""przedsiebiorstwo-handlowo-uslugowe-wimar-spolka-jawna-wieslaw-i-mariusz-slanina""
}
],
""value_min"": ""205510.33"",
""value_for_three"": 0,
""value_for_one_eur"": 0,
""count"": ""1"",
""value_for_one"": 0,
""offers_declined"": [
1
],
""value_for_three_eur"": 0,
""suppliers_id"": ""23093"",
""value_eur"": 44844.81,
""value_max"": ""674040.00"",
""offers_count"": [
4
],
""suppliers_name"": ""Przedsiebiorstwo Handlowo-Usługowe \""WIMAR\"" Spółka jawna Wiesław i Mariusz Słanina"",
""value"": ""205510.33"",
""value_estimated"": null,
""offers_count_data"": {
""4"": {
""value_eur"": 44844.81,
""count"": ""1"",
""value"": ""205510.33""
}
}
}
]
},
{
""id"": ""564206"",
""date"": ""2021-07-12"",
""deadline_date"": ""2021-08-02"",
""deadline_length_days"": ""20"",
""deadline_length_hours"": ""502"",
""title"": ""Modernizacja systemu sygnalizacji pożarowej budynku Centrum Sztuki Mościce"",
""category"": ""constructions"",
""description"": ""W zakres przedmiotu wchodzi w szczególności:- wymianę centrali sygnalizacji pożaru- wymianę czujek optycznych dymu- wymianę ręcznych ostrzegaczy pożarowych - wymianę sygnalizatorów pożarowych - wymianę elementów kontrolno- sterujących- podłączenie do centrali i konfigurację pętli dozorowych- podłączenie do centrali istniejącego systemu DSO- podłączenie kurtyn pożarowych - podłączenie klap pożarowych -podłączenie do centrali świateł ostrzegawczych umiejscowionych w toaletach - podłączenie do cent"",
""sid"": ""info:118345"",
""awarded_value"": ""174660.00"",
""awarded_currency"": ""PLN"",
""awarded_value_eur"": ""38112.90"",
""purchaser"": {
""id"": ""32276"",
""sid"": null,
""name"": null
},
""type"": {
""id"": ""art-275-pkt-1-ustawy"",
""name"": ""art. 275 pkt 1 ustawy"",
""slug"": ""art-275-pkt-1-ustawy""
},
""awarded"": [
{
""date"": ""2021-08-27"",
""value_for_two"": 0,
""value_for_two_eur"": 0,
""suppliers"": [
{
""name"": ""Amipoż 2 Sp. z o.o."",
""id"": 23064,
""slug"": ""amipoz-2-sp-z-o-o""
}
],
""value_min"": ""174660.00"",
""value_for_three"": 0,
""value_for_one_eur"": 0,
""count"": ""1"",
""value_for_one"": 0,
""offers_declined"": [
1
],
""value_for_three_eur"": 0,
""suppliers_id"": ""23064"",
""value_eur"": 38112.9,
""value_max"": ""374124.77"",
""offers_count"": [
5
],
""suppliers_name"": ""Amipoż 2 Sp. z o.o."",
""value"": ""174660.00"",
""value_estimated"": null,
""offers_count_data"": {
""5"": {
""value_eur"": 38112.9,
""count"": ""1"",
""value"": ""174660.00""
}
}
}
]
},
{
""id"": ""564165"",
""date"": ""2021-08-04"",
""deadline_date"": ""2021-08-20"",
""deadline_length_days"": ""16"",
""deadline_length_hours"": ""387"",
""title"": ""Wykonanie pokrycia dachu z dachówki ceramicznej karpiówki budynku mieszkalnego usytuowanego przy ul. Stylowej 14 w Warszawie."",
""category"": ""constructions"",
""description"": ""Krótki opis przedmiotu zamówienia: Przedmiotem zamówienia jest wykonanie robót budowlanych polegających na: - Wykonanie ocieplenia stropu warstwą wełny o grubości 25 cm o współczynniku Lambda 0,036 W/mK pod nieogrzewanym poddaszem,- Rozebranie pokrycia z dachówki ceramicznej i blachy trapezowej,- Wymiana wszelkich obróbek blacharskich,- Wymiana zgniłego pokrycia z desek,- Rozstawienie rusztowań wraz z zabezpieczeniem,- Wykonanie przedłużenia dachu zgodnie z załączonym rysunkiem poglądowym,- Wyko"",
""sid"": ""info:118276"",
""awarded_value"": ""337997.04"",
""awarded_currency"": ""PLN"",
""awarded_value_eur"": ""73755.00"",
""purchaser"": {
""id"": ""20597"",
""sid"": null,
""name"": null
},
""type"": {
""id"": ""art-275-pkt-1-ustawy"",
""name"": ""art. 275 pkt 1 ustawy"",
""slug"": ""art-275-pkt-1-ustawy""
},
""awarded"": [
{
""date"": ""2021-08-27"",
""value_for_two"": 337997.04,
""value_for_two_eur"": 73755,
""suppliers"": [
{
""name"": ""Dach Expert Ewa Ladosz"",
""id"": 17328,
""slug"": ""dach-expert-ewa-ladosz""
}
],
""value_min"": ""337997.04"",
""value_for_three"": 337997.04,
""offers_count_status"": ""only_one"",
""value_for_one_eur"": 73755,
""count"": ""1"",
""value_for_one"": 337997.04,
""value_for_three_eur"": 73755,
""suppliers_id"": ""17328"",
""value_eur"": 73755,
""value_max"": ""337997.04"",
""offers_count"": [
1
],
""suppliers_name"": ""Dach Expert Ewa Ladosz"",
""value"": ""337997.04"",
""value_estimated"": null,
""offers_count_data"": {
""1"": {
""value_eur"": 73755,
""count"": ""1"",
""value"": ""337997.04""
}
}
}
]
},
{
""id"": ""564136"",
""date"": ""2021-08-03"",
""deadline_date"": ""2021-08-11"",
""deadline_length_days"": ""8"",
""deadline_length_hours"": ""194"",
""title"": ""Usługi restauracyjne na rzecz dzieci uczęszczającychdo Przedszkola nr 104 „Na Misiowej Polanie” we Wrocławiu"",
""category"": ""services"",
""description"": ""Przedmiotem zamówienia są: Usługi restauracyjne na rzecz dzieci uczęszczających do Przedszkola nr 104 „Na Misiowej Polanie” we Wrocławiu.Przez wykonanie niniejszej usługi rozumie się realizację przedmiotu zamówienia zgodnie z zakresem określonym w § 1 i 2 załączonej umowy, gdzie jest wymagane świadczenie usług na rzecz Zamawiającego w zakresie: przygotowania, dostawy i dystrybucji posiłków zgodnie z zasadami racjonalnego żywienia dzieci przedszkolnych w wieku od 2,5 do 7 lat (śniadanie, obiad, p"",
""sid"": ""info:118212"",
""awarded_value"": ""962800.00"",
""awarded_currency"": ""PLN"",
""awarded_value_eur"": ""210094.49"",
""purchaser"": {
""id"": ""32263"",
""sid"": null,
""name"": null
},
""type"": {
""id"": ""art-275-pkt-1-ustawy"",
""name"": ""art. 275 pkt 1 ustawy"",
""slug"": ""art-275-pkt-1-ustawy""
},
""awarded"": [
{
""date"": ""2021-08-27"",
""value_for_two"": 962800,
""value_for_two_eur"": 210094.49,
""suppliers"": [
{
""name"": ""2. RETTMAN Spółka z ograniczoną odpowiedzialnością Sp. K ."",
""id"": 23040,
""slug"": ""2-rettman-spolka-z-ograniczona-odpowiedzialnoscia-sp-k""
}
],
""value_min"": ""962800.00"",
""value_for_three"": 962800,
""offers_count_status"": ""only_one"",
""value_for_one_eur"": 210094.49,
""count"": ""1"",
""value_for_one"": 962800,
""value_for_three_eur"": 210094.49,
""suppliers_id"": ""23040"",
""value_eur"": 210094.49,
""value_max"": ""962800.00"",
""offers_count"": [
1
],
""suppliers_name"": ""2. RETTMAN Spółka z ograniczoną odpowiedzialnością Sp. K ."",
""value"": ""962800.00"",
""value_estimated"": null,
""offers_count_data"": {
""1"": {
""value_eur"": 210094.49,
""count"": ""1"",
""value"": ""962800.00""
}
}
}
]
},
{
""id"": ""564131"",
""date"": ""2021-07-22"",
""deadline_date"": ""2021-07-30"",
""deadline_length_days"": ""7"",
""deadline_length_hours"": ""185"",
""title"": ""Opracowanie dokumentacji projektowej wraz z uzyskaniem niezbędnych decyzji administracyjnych dla: Budowa sieci kanalizacji sanitarnej wraz z przyłączami w 2 sołectwach w Gminie Brzeszcze"",
""category"": ""services"",
""description"": ""Przedmiotem zamówienia jest opracowanie dokumentacji projektowej wraz z uzyskaniem niezbędnych decyzji administracyjnych dla zadania: Budowa sieci kanalizacji sanitarnej wraz z przyłączami (od sieci do granicy nieruchomości) w sołectwach Przecieszyn (ul. Graniczna-Wyzwolenia) oraz Jawiszowice (ul. Tulipanów-Boczna) w Gminie Brzeszcze.Przedmiotem zamówienia jest opracowanie i przekazanie Zamawiającemu projektu (dokumentacji projektowej obejmującej projekt budowlany i wykonawczy) wraz z uzyskaniem"",
""sid"": ""info:118200"",
""awarded_value"": ""442800.00"",
""awarded_currency"": ""PLN"",
""awarded_value_eur"": ""96624.26"",
""purchaser"": {
""id"": ""24948"",
""sid"": null,
""name"": null
},
""type"": {
""id"": ""art-275-pkt-1-ustawy"",
""name"": ""art. 275 pkt 1 ustawy"",
""slug"": ""art-275-pkt-1-ustawy""
},
""awarded"": [
{
""date"": ""2021-08-27"",
""value_for_two"": 442800,
""value_for_two_eur"": 96624.26,
""suppliers"": [
{
""name"": ""AS-GOR s.c. Anna Konieczny, Łukasz Gorczowski"",
""id"": 23037,
""slug"": ""as-gor-s-c-anna-konieczny-lukasz-gorczowski""
},
{
""name"": ""AS-GOR s.c. Anna Konieczny, AS-GOR s.c. Łukasz Gorczowski"",
""id"": 23038,
""slug"": ""as-gor-s-c-anna-konieczny-as-gor-s-c-lukasz-gorczowski""
}
],
""value_min"": ""442800.00"",
""value_for_three"": 442800,
""offers_count_status"": ""only_one"",
""value_for_one_eur"": 96624.26,
""count"": ""1"",
""value_for_one"": 442800,
""value_for_three_eur"": 96624.26,
""suppliers_id"": ""23037,23038"",
""value_eur"": 96624.26,
""value_max"": ""442800.00"",
""offers_count"": [
1
],
""suppliers_name"": ""AS-GOR s.c. Anna Konieczny, Łukasz Gorczowski AS-GOR s.c. Anna Konieczny, AS-GOR s.c. Łukasz Gorczowski"",
""value"": ""442800.00"",
""value_estimated"": null,
""offers_count_data"": {
""1"": {
""value_eur"": 96624.26,
""count"": ""1"",
""value"": ""442800.00""
}
}
}
]
},
{
""id"": ""564108"",
""date"": ""2021-07-21"",
""deadline_date"": ""2021-07-29"",
""deadline_length_days"": ""7"",
""deadline_length_hours"": ""191"",
""title"": ""Dostawa nowego samochodu ratowniczo-gaśniczego typu średniego z napędem 4x4 dla Ochotniczej Straży Pożarnej w Zimnej Brzeźnicy"",
""category"": ""supplies"",
""description"": ""8.2 Przedmiotem zamówienia jest Dostawa nowego samochodu ratowniczo-gaśniczego typuśredniego z napędem 4x4 dla Ochotniczej Straży Pożarnej Zimna Brzeźnica. 8.3 Szczegółowyopis przedmiotu zamówienia zawiera załącznik nr 3 do SWZ."",
""sid"": ""info:118154"",
""awarded_value"": ""847470.00"",
""awarded_currency"": ""PLN"",
""awarded_value_eur"": ""184928.10"",
""purchaser"": {
""id"": ""32046"",
""sid"": null,
""name"": null
},
""type"": {
""id"": ""art-275-pkt-1-ustawy"",
""name"": ""art. 275 pkt 1 ustawy"",
""slug"": ""art-275-pkt-1-ustawy""
},
""awarded"": [
{
""date"": ""2021-08-27"",
""value_for_two"": 847470,
""value_for_two_eur"": 184928.1,
""suppliers"": [
{
""name"": ""Wawrzaszek ISS Spółka z ograniczoną odpowiedzialnością Spółka komandytowa, 43-300 Bielsko-Biała"",
""id"": 23026,
""slug"": ""wawrzaszek-iss-spolka-z-ograniczona-odpowiedzialnoscia-spolka-komandytowa-43-300-bielsko-biala""
}
],
""value_min"": ""847470.00"",
""value_for_three"": 847470,
""offers_count_status"": ""only_one"",
""value_for_one_eur"": 184928.1,
""count"": ""1"",
""value_for_one"": 847470,
""value_for_three_eur"": 184928.1,
""suppliers_id"": ""23026"",
""value_eur"": 184928.1,
""value_max"": ""847470.00"",
""offers_count"": [
1
],
""suppliers_name"": ""Wawrzaszek ISS Spółka z ograniczoną odpowiedzialnością Spółka komandytowa, 43-300 Bielsko-Biała"",
""value"": ""847470.00"",
""value_estimated"": null,
""offers_count_data"": {
""1"": {
""value_eur"": 184928.1,
""count"": ""1"",
""value"": ""847470.00""
}
}
}
]
},
{
""id"": ""564083"",
""date"": ""2021-07-23"",
""deadline_date"": ""2021-08-09"",
""deadline_length_days"": ""16"",
""deadline_length_hours"": ""407"",
""title"": ""Termomodernizacja budynku mieszkalnego przy ul. Michała Drzymały 10 w Policach wraz z robotami towarzyszącymi, administrowanego przez Zakład Gospodarki Komunalnej i Mieszkaniowej w Policach"",
""category"": ""constructions"",
""description"": ""1. Przedmiotem zamówienia jest zadanie pn. Termomodernizacja budynku mieszkalnego przy ul. Michała Drzymały 10 w Policach wraz z robotami towarzyszącymi, administrowanego przez Zakład Gospodarki Komunalnej i Mieszkaniowej w Policach.2. Szczegółowy opis przedmiotu zamówienia oraz zakres prac – zgodnie z dokumentacją projektową, stanowiącą załącznik 13 do swz, ze specyfikacją techniczną wykonania i odbioru robót budowlanych, stanowiącą załącznik nr 5 do swz, oraz pomocniczo z przedmiarami robót, s"",
""sid"": ""info:118101"",
""awarded_value"": ""197700.00"",
""awarded_currency"": ""PLN"",
""awarded_value_eur"": ""43140.51"",
""purchaser"": {
""id"": ""32253"",
""sid"": null,
""name"": null
},
""type"": {
""id"": ""art-275-pkt-1-ustawy"",
""name"": ""art. 275 pkt 1 ustawy"",
""slug"": ""art-275-pkt-1-ustawy""
},
""awarded"": [
{
""date"": ""2021-08-27"",
""value_for_two"": 197700,
""value_for_two_eur"": 43140.51,
""suppliers"": [
{
""name"": ""POL-BUD Wiesław Łokucjewski"",
""id"": 23024,
""slug"": ""pol-bud-wieslaw-lokucjewski""
}
],
""value_min"": ""197700.00"",
""value_for_three"": 197700,
""offers_count_status"": ""only_one"",
""value_for_one_eur"": 43140.51,
""count"": ""1"",
""value_for_one"": 197700,
""value_for_three_eur"": 43140.51,
""suppliers_id"": ""23024"",
""value_eur"": 43140.51,
""value_max"": ""197700.00"",
""offers_count"": [
1
],
""suppliers_name"": ""POL-BUD Wiesław Łokucjewski"",
""value"": ""197700.00"",
""value_estimated"": null,
""offers_count_data"": {
""1"": {
""value_eur"": 43140.51,
""count"": ""1"",
""value"": ""197700.00""
}
}
}
]
},
{
""id"": ""563882"",
""date"": ""2021-07-16"",
""deadline_date"": ""2021-07-27"",
""deadline_length_days"": ""11"",
""deadline_length_hours"": ""268"",
""title"": ""Systematyczne dostawy do PAP S.A. prasy krajowej w wersji papierowej"",
""category"": ""supplies"",
""description"": ""Przedmiotem zamówienia są systematyczne dostawy do PAP S.A., ul. Bracka 6/8, Warszawa prasy krajowej w wersji papierowej."",
""sid"": ""info:117736"",
""awarded_value"": ""54296.93"",
""awarded_currency"": ""PLN"",
""awarded_value_eur"": ""11848.24"",
""purchaser"": {
""id"": ""23835"",
""sid"": null,
""name"": null
},
""type"": {
""id"": ""art-275-pkt-1-ustawy"",
""name"": ""art. 275 pkt 1 ustawy"",
""slug"": ""art-275-pkt-1-ustawy""
},
""awarded"": [
{
""date"": ""2021-08-27"",
""value_for_two"": 0,
""value_for_two_eur"": 0,
""suppliers"": [
{
""name"": ""G.L.M. Sp. z o.o.,"",
""id"": 3899,
""slug"": ""g-l-m-sp-z-o-o""
}
],
""value_min"": ""54296.93"",
""value_for_three"": 54296.93,
""value_for_one_eur"": 0,
""count"": ""1"",
""value_for_one"": 0,
""value_for_three_eur"": 11848.24,
""suppliers_id"": ""3899"",
""value_eur"": 11848.24,
""value_max"": ""62516.98"",
""offers_count"": [
3
],
""suppliers_name"": ""G.L.M. Sp. z o.o.,"",
""value"": ""54296.93"",
""value_estimated"": null,
""offers_count_data"": {
""3"": {
""value_eur"": 11848.24,
""count"": ""1"",
""value"": ""54296.93""
}
}
}
]
},
{
""id"": ""561260"",
""date"": ""2021-08-03"",
""deadline_date"": ""2021-08-13"",
""deadline_length_days"": ""9"",
""deadline_length_hours"": ""232"",
""title"": ""Wykonywanie usług przewozów regularnych specjalnych dla uczniów placówek oświatowych działających na terenie Gminy Chodzież w okresach nauki szkolnej 2021-2023."",
""category"": ""services"",
""description"": ""Przedmiotem zamówienia jest świadczenie usługi regularnych przewozów uczniów do placówek oświatowych prowadzonych przez Gminę Chodzież autobusami na podstawie biletów miesięcznych w roku szkolnym 2021/2022 oraz 2022/2023.Przewóz uczniów będzie odbywał się od poniedziałku do piątku każdego tygodnia, w dni nauki szkolnej, zgodnie z rozporządzeniem Ministra Edukacji Narodowej z dnia 11 sierpnia 2017 roku w sprawie organizacji roku szkolnego (Dz. U. poz. 1603 z późniejszymi zmianami).Przewozy będą r"",
""sid"": ""info:112766"",
""awarded_value"": ""728160.00"",
""awarded_currency"": ""PLN"",
""awarded_value_eur"": ""158893.23"",
""purchaser"": {
""id"": ""30367"",
""sid"": null,
""name"": null
},
""type"": {
""id"": ""art-275-pkt-2-ustawy"",
""name"": ""art. 275 pkt 2 ustawy"",
""slug"": ""art-275-pkt-2-ustawy""
},
""awarded"": [
{
""date"": ""2021-08-27"",
""value_for_two"": 728160,
""value_for_two_eur"": 158893.23,
""suppliers"": [
{
""name"": ""PKS Spółka z o.o. w Pile"",
""id"": 22956,
""slug"": ""pks-spolka-z-o-o-w-pile""
}
],
""value_min"": ""728160.00"",
""value_for_three"": 728160,
""offers_count_status"": ""only_one"",
""value_for_one_eur"": 158893.23,
""count"": ""1"",
""value_for_one"": 728160,
""value_for_three_eur"": 158893.23,
""suppliers_id"": ""22956"",
""value_eur"": 158893.23,
""value_max"": ""728160.00"",
""offers_count"": [
1
],
""suppliers_name"": ""PKS Spółka z o.o. w Pile"",
""value"": ""728160.00"",
""value_estimated"": null,
""offers_count_data"": {
""1"": {
""value_eur"": 158893.23,
""count"": ""1"",
""value"": ""728160.00""
}
}
}
]
},
{
""id"": ""564304"",
""date"": ""2021-06-29"",
""deadline_date"": ""2021-07-15"",
""deadline_length_days"": ""15"",
""deadline_length_hours"": ""378"",
""title"": ""Budowa boiska wielofunkcyjnego, bieżni prostej zakończonej skocznią do skoku w dal przy Zespole Szkolno - Przedszkolnym w Łuszczowie"",
""category"": ""constructions"",
""description"": ""1. Przedmiotem zamówienia jest budowa boiska wielofunkcyjnego, bieżni prostej zakończonej skocznią do skoku w dal przy Zespole Szkolno - Przedszkolnym w Łuszczowie obejmującej boisko wielofunkcyjne, bieżnię i rozbieżnię do skoku w dal, zeskocznię do skoku w dal, piłkochwyty, ogrodzenie. Poniżej wymienione są główne cechy przedmiotu zamówienia i przybliżone ilości:2. Zakres zamówienia obejmuje:2.1. Boisko wielofunkcyjne o nawierzchni z trawy syntetycznej o wymiarach 33,8m x 62,9m, na którym linia"",
""sid"": ""info:118531"",
""awarded_value"": ""925880.06"",
""awarded_currency"": ""PLN"",
""awarded_value_eur"": ""202249.95"",
""purchaser"": {
""id"": ""3059"",
""sid"": null,
""name"": null
},
""type"": {
""id"": ""art-275-pkt-1-ustawy"",
""name"": ""art. 275 pkt 1 ustawy"",
""slug"": ""art-275-pkt-1-ustawy""
},
""awarded"": [
{
""date"": ""2021-08-26"",
""value_for_two"": 0,
""value_for_two_eur"": 0,
""suppliers"": [
{
""name"": ""EVERSPORT Sp. z o.o."",
""id"": 23145,
""slug"": ""eversport-sp-z-o-o""
}
],
""value_min"": ""925880.06"",
""value_for_three"": 0,
""value_for_one_eur"": 0,
""count"": ""1"",
""value_for_one"": 0,
""value_for_three_eur"": 0,
""suppliers_id"": ""23145"",
""value_eur"": 202249.95,
""value_max"": ""1474770.00"",
""offers_count"": [
5
],
""suppliers_name"": ""EVERSPORT Sp. z o.o."",
""value"": ""925880.06"",
""value_estimated"": null,
""offers_count_data"": {
""5"": {
""value_eur"": 202249.95,
""count"": ""1"",
""value"": ""925880.06""
}
}
}
]
},
{
""id"": ""564299"",
""date"": ""2021-07-01"",
""deadline_date"": ""2021-07-19"",
""deadline_length_days"": ""18"",
""deadline_length_hours"": ""435"",
""title"": ""Budowa oświetlenia ulicznego na terenie Gminy Zarszyn"",
""category"": ""constructions"",
""description"": ""a. Budowa oświetlenia ulicznego w miejscowości Pielnia ul. Mikołaja Skałki- kabel ziemny YAKXS4x35 – 907 m- montaż słupów oświetleniowych o wys. 6 m – 18 szt.- montaż wysięgników rurowych – 18 szt.- montaż opraw oświetlenia – 19 szt.b. Budowa części oświetlenia na ul. Uroczej w Pielni - kabel ziemny YAKXS4x35 –153 m- montaż słupów oświetleniowych o wys. 6 m – 3 szt. (słup Nr 11, 12, 13)- montaż wysięgników rurowych – 3 szt.- montaż opraw oświetlenia – 3 szt.- szafa oświetleniowa – 1 kpl."",
""sid"": ""info:118524"",
""awarded_value"": ""591042.77"",
""awarded_currency"": ""PLN"",
""awarded_value_eur"": ""129107.84"",
""purchaser"": {
""id"": ""30652"",
""sid"": null,
""name"": null
},
""type"": {
""id"": ""art-275-pkt-1-ustawy"",
""name"": ""art. 275 pkt 1 ustawy"",
""slug"": ""art-275-pkt-1-ustawy""
},
""awarded"": [
{
""date"": ""2021-08-26"",
""value_for_two"": 0,
""value_for_two_eur"": 0,
""suppliers"": [
{
""name"": ""EL-KROS Usługi Elektryczne Wiesław Jachyra, ul. Ślączka 9A, 38-400 Krosno"",
""id"": 23085,
""slug"": ""el-kros-uslugi-elektryczne-wieslaw-jachyra-ul-slaczka-9a-38-400-krosno""
}
],
""value_min"": ""112183.60"",
""value_for_three"": 0,
""value_for_one_eur"": 0,
""count"": ""1"",
""value_for_one"": 0,
""value_for_three_eur"": 0,
""suppliers_id"": ""23085"",
""value_eur"": 24505.47,
""value_max"": ""215043.53"",
""offers_count"": [
7
],
""suppliers_name"": ""EL-KROS Usługi Elektryczne Wiesław Jachyra, ul. Ślączka 9A, 38-400 Krosno"",
""value"": ""112183.60"",
""value_estimated"": ""108253.87"",
""offers_count_data"": {
""7"": {
""value_eur"": 24505.47,
""count"": ""1"",
""value"": ""112183.60""
}
}
},
{
""date"": ""2021-08-26"",
""value_for_two"": 0,
""value_for_two_eur"": 0,
""suppliers"": [
{
""name"": ""EL-KROS Usługi Elektryczne Wiesław Jachyra"",
""id"": 23086,
""slug"": ""el-kros-uslugi-elektryczne-wieslaw-jachyra""
}
],
""value_min"": ""478859.17"",
""value_for_three"": 0,
""value_for_one_eur"": 0,
""count"": ""2"",
""value_for_one"": 0,
""value_for_three_eur"": 0,
""suppliers_id"": ""23086"",
""value_eur"": 104602.37,
""value_max"": ""1076467.10"",
""offers_count"": [
7,
8
],
""suppliers_name"": ""EL-KROS Usługi Elektryczne Wiesław Jachyra"",
""value"": ""478859.17"",
""value_estimated"": ""524659.30"",
""offers_count_data"": {
""7"": {
""value_eur"": 59691.93,
""count"": ""1"",
""value"": ""273263.68""
},
""8"": {
""value_eur"": 44910.44,
""count"": ""1"",
""value"": ""205595.49""
}
}
}
]
},
{
""id"": ""564196"",
""date"": ""2021-07-09"",
""deadline_date"": ""2021-07-19"",
""deadline_length_days"": ""9"",
""deadline_length_hours"": ""239"",
""title"": ""Wykonanie usługi polegającej na wsparciu modernizacji oprogramowania Centrum Infrastruktury Badawczej Indukowanej Sejsmiczności (CIBIS)"",
""category"": ""services"",
""description"": ""Przedmiotem zamówienia jest wykonanie przez Wykonawcę na rzecz Zamawiającego usług programistycznych w wymiarze 640 roboczogodzin polegających na wsparciu modernizacji oprogramowania Centrum Infrastruktury Badawczej Indukowanej Sejsmiczności (CIBIS) dla Centrów Infrastruktury Badawczej – Indukowanej Sejsmiczności (CIBIS), Analitycznych Laboratoriów (CIBAL), Sejsmicznych Badań Litosfery (CIBSBL) oraz Obserwacji Geomagnetycznych i Magnetotellurycznych (CIBOGM).Zakres realizowanych prac w ramach us"",
""sid"": ""info:118330"",
""awarded_value"": ""159014.40"",
""awarded_currency"": ""PLN"",
""awarded_value_eur"": ""34735.23"",
""purchaser"": {
""id"": ""23416"",
""sid"": null,
""name"": null
},
""type"": {
""id"": ""art-275-pkt-1-ustawy"",
""name"": ""art. 275 pkt 1 ustawy"",
""slug"": ""art-275-pkt-1-ustawy""
},
""awarded"": [
{
""date"": ""2021-08-26"",
""value_for_two"": 159014.4,
""value_for_two_eur"": 34735.23,
""suppliers"": [
{
""name"": ""Infomex Sp. z o.o."",
""id"": 23062,
""slug"": ""infomex-sp-z-o-o""
}
],
""value_min"": ""159014.40"",
""value_for_three"": 159014.4,
""offers_count_status"": ""only_one"",
""value_for_one_eur"": 34735.23,
""count"": ""1"",
""value_for_one"": 159014.4,
""value_for_three_eur"": 34735.23,
""suppliers_id"": ""23062"",
""value_eur"": 34735.23,
""value_max"": ""159014.40"",
""offers_count"": [
1
],
""suppliers_name"": ""Infomex Sp. z o.o."",
""value"": ""159014.40"",
""value_estimated"": null,
""offers_count_data"": {
""1"": {
""value_eur"": 34735.23,
""count"": ""1"",
""value"": ""159014.40""
}
}
}
]
},
{
""id"": ""564179"",
""date"": ""2021-07-01"",
""deadline_date"": ""2021-07-16"",
""deadline_length_days"": ""14"",
""deadline_length_hours"": ""357"",
""title"": ""„Przebudowa wiaduktu w ciągu drogi powiatowej nr 5055S w km 1+745 w miejscowości Bluszczów”"",
""category"": ""constructions"",
""description"": ""Przedmiotem zamówienia jest wykonanie przebudowy wiaduktu w ciągu drogi powiatowej nr 5055S w km 1+745 w miejscowości Bluszczów.Wiadukt znajduje się nad przeszkodą, którą stanowi linia kolejowa.Zakres inwestycji obejmuje rozbiórkę istniejącego wiaduktu i budowę nowego z wykorzystaniem części podpory po stronie zachodniej. Zakres przebudowy obejmuje także dojazdy do obiektu."",
""sid"": ""info:118295"",
""awarded_value"": ""1523509.57"",
""awarded_currency"": ""PLN"",
""awarded_value_eur"": ""332796.60"",
""purchaser"": {
""id"": ""25624"",
""sid"": null,
""name"": null
},
""type"": {
""id"": ""art-275-pkt-1-ustawy"",
""name"": ""art. 275 pkt 1 ustawy"",
""slug"": ""art-275-pkt-1-ustawy""
},
""awarded"": [
{
""date"": ""2021-08-26"",
""value_for_two"": 0,
""value_for_two_eur"": 0,
""suppliers"": [
{
""name"": ""Przedsiębiorstwo Remontów Ulic i Mostów S.A."",
""id"": 20812,
""slug"": ""przedsiebiorstwo-remontow-ulic-i-mostow-s-a""
}
],
""value_min"": ""1523509.57"",
""value_for_three"": 0,
""value_for_one_eur"": 0,
""count"": ""1"",
""value_for_one"": 0,
""value_for_three_eur"": 0,
""suppliers_id"": ""20812"",
""value_eur"": 332796.6,
""value_max"": ""2255045.16"",
""offers_count"": [
5
],
""suppliers_name"": ""Przedsiębiorstwo Remontów Ulic i Mostów S.A."",
""value"": ""1523509.57"",
""value_estimated"": null,
""offers_count_data"": {
""5"": {
""value_eur"": 332796.6,
""count"": ""1"",
""value"": ""1523509.57""
}
}
}
]
},
{
""id"": ""564157"",
""date"": ""2021-08-04"",
""deadline_date"": ""2021-08-12"",
""deadline_length_days"": ""8"",
""deadline_length_hours"": ""194"",
""title"": ""Dowóz i odwóz uczniów do placówek oświatowych na terenie Gminy Pionki oraz uczniów niepełnosprawnych do placówki oświatowej na terenie Gminy Miasta Pionki w roku szkolnym 2021/2022"",
""category"": ""services"",
""description"": ""Dowóz i odwóz uczniów do Publicznej Szkoły Podstawowej w CzarnejTrasa dowozu:Wincentów – Marcelów - Czarna (szkoła) – Helenów – Czarna (szkoła) – 25 uczniów – 1 kursTrasa odwozu:Czarna (szkoła)-Helenów – Marcelów – Wincentów - 2 kursy 1 autobus"",
""sid"": ""info:118259"",
""awarded_value"": ""202511.65"",
""awarded_currency"": ""PLN"",
""awarded_value_eur"": ""44236.80"",
""purchaser"": {
""id"": ""32269"",
""sid"": null,
""name"": null
},
""type"": {
""id"": ""art-275-pkt-1-ustawy"",
""name"": ""art. 275 pkt 1 ustawy"",
""slug"": ""art-275-pkt-1-ustawy""
},
""awarded"": [
{
""date"": ""2021-08-26"",
""value_for_two"": 0,
""value_for_two_eur"": 0,
""suppliers"": [
{
""name"": ""PHU Dominator Małgorzata Amanowicz"",
""id"": 23053,
""slug"": ""phu-dominator-malgorzata-amanowicz""
}
],
""value_min"": ""54529.20"",
""value_for_three"": 54529.2,
""value_for_one_eur"": 0,
""count"": ""1"",
""value_for_one"": 0,
""value_for_three_eur"": 11911.4,
""suppliers_id"": ""23053"",
""value_eur"": 11911.4,
""value_max"": ""91630.00"",
""offers_count"": [
3
],
""suppliers_name"": ""PHU Dominator Małgorzata Amanowicz"",
""value"": ""54529.20"",
""value_estimated"": ""80436.56"",
""offers_count_data"": {
""3"": {
""value_eur"": 11911.4,
""count"": ""1"",
""value"": ""54529.20""
}
}
},
{
""date"": ""2021-08-26"",
""value_for_two"": 0,
""value_for_two_eur"": 0,
""suppliers"": [
{
""name"": ""AMP Sp. z o.o."",
""id"": 515,
""slug"": ""amp-sp-z-o-o""
}
],
""value_min"": ""147982.45"",
""value_for_three"": 92177.91,
""value_for_one_eur"": 0,
""count"": ""3"",
""value_for_one"": 0,
""offers_declined"": [
1
],
""value_for_three_eur"": 20135.41,
""suppliers_id"": ""515"",
""value_eur"": 32325.4,
""value_max"": ""251141.00"",
""offers_count"": [
3,
4
],
""suppliers_name"": ""AMP Sp. z o.o."",
""value"": ""147982.45"",
""value_estimated"": ""136650.43"",
""offers_count_data"": {
""3"": {
""value_eur"": 20135.41,
""count"": ""2"",
""value"": ""92177.91""
},
""4"": {
""value_eur"": 12189.99,
""count"": ""1"",
""value"": ""55804.54""
}
}
}
]
},
{
""id"": ""564148"",
""date"": ""2021-07-23"",
""deadline_date"": ""2021-08-10"",
""deadline_length_days"": ""17"",
""deadline_length_hours"": ""431"",
""title"": ""Remont drogi dz. ewid. nr 769/1 „Do leśniczówki „ w km 0 + 420 – km 0 + 940 w miejscowosci Nowy Dzików"",
""category"": ""constructions"",
""description"": ""1. Przedmiotem zamówienia jest właściwe i zgodne z zasadami sztuki budowlanej kompleksowe wykonanie inwestycji pn.: Remont drogi dz. ewid. nr 769/1 „Do leśniczówki „ w km 0 + 420 – km 0 + 940 w miejscowosci Nowy Dzików 2. W zakres przedmiotu zamówienia wchodzi także:1) budowa obiektów oraz infrastruktury technicznej,2) osiągnięcie efektu oraz parametrów techniczno-technologicznych nie gorszych niż zdefiniowane w dokumentacji projektowej,3) uzyskanie wszelkich dokumentów i spełnienie wszelkich wy"",
""sid"": ""info:118241"",
""awarded_value"": ""213910.21"",
""awarded_currency"": ""PLN"",
""awarded_value_eur"": ""46726.71"",
""purchaser"": {
""id"": ""29938"",
""sid"": null,
""name"": null
},
""type"": {
""id"": ""art-275-pkt-1-ustawy"",
""name"": ""art. 275 pkt 1 ustawy"",
""slug"": ""art-275-pkt-1-ustawy""
},
""awarded"": [
{
""date"": ""2021-08-26"",
""value_for_two"": 213910.21,
""value_for_two_eur"": 46726.71,
""suppliers"": [
{
""name"": ""Strabag Sp.z o.o."",
""id"": 1257,
""slug"": ""strabag-sp-z-o-o""
},
{
""name"": ""PBI Infrastruktura"",
""id"": 23052,
""slug"": ""pbi-infrastruktura""
}
],
""value_min"": ""213910.21"",
""value_for_three"": 213910.21,
""value_for_one_eur"": 0,
""count"": ""1"",
""value_for_one"": 0,
""value_for_three_eur"": 46726.71,
""suppliers_id"": ""1257,23052"",
""value_eur"": 46726.71,
""value_max"": ""288573.74"",
""offers_count"": [
2
],
""suppliers_name"": ""Strabag Sp.z o.o. PBI Infrastruktura"",
""value"": ""213910.21"",
""value_estimated"": null,
""offers_count_data"": {
""2"": {
""value_eur"": 46726.71,
""count"": ""1"",
""value"": ""213910.21""
}
}
}
]
},
{
""id"": ""564135"",
""date"": ""2021-07-28"",
""deadline_date"": ""2021-08-05"",
""deadline_length_days"": ""7"",
""deadline_length_hours"": ""188"",
""title"": ""Usługi restauracyjne na rzecz uczniów uczęszczającychdo Szkoły Podstawowej nr 118 we Wrocławiu."",
""category"": ""services"",
""description"": ""Usługi restauracyjne na rzecz uczniów uczęszczających do Szkoły Podstawowej nr 118 we Wrocławiu. Przez wykonanie niniejszej usługi rozumie się realizację przedmiotu zamówienia zgodnie z zakresem określonym w § 1 i 2 załączonej umowy, gdzie jest wymagane świadczenie usług na rzecz Zamawiającego w zakresie: przygotowania, dostawy i dystrybucji posiłków zgodnie z zasadami racjonalnego żywienia uczniów w wieku od 6 do 15 lat (tylko obiady, przewiduje się diety standardowe, eliminacyjne: bezmleczna i"",
""sid"": ""info:118210"",
""awarded_value"": ""1049070.00"",
""awarded_currency"": ""PLN"",
""awarded_value_eur"": ""229159.66"",
""purchaser"": {
""id"": ""32261"",
""sid"": null,
""name"": null
},
""type"": {
""id"": ""art-275-pkt-1-ustawy"",
""name"": ""art. 275 pkt 1 ustawy"",
""slug"": ""art-275-pkt-1-ustawy""
},
""awarded"": [
{
""date"": ""2021-08-26"",
""value_for_two"": 1049070,
""value_for_two_eur"": 229159.66,
""suppliers"": [
{
""name"": ""KANZEON WROCŁAWSKI CATERING Grzegorz Ciężkal"",
""id"": 16833,
""slug"": ""kanzeon-wroclawski-catering-grzegorz-ciezkal""
}
],
""value_min"": ""1049070.00"",
""value_for_three"": 1049070,
""value_for_one_eur"": 0,
""count"": ""1"",
""value_for_one"": 0,
""value_for_three_eur"": 229159.66,
""suppliers_id"": ""16833"",
""value_eur"": 229159.66,
""value_max"": ""1055241.00"",
""offers_count"": [
2
],
""suppliers_name"": ""KANZEON WROCŁAWSKI CATERING Grzegorz Ciężkal"",
""value"": ""1049070.00"",
""value_estimated"": null,
""offers_count_data"": {
""2"": {
""value_eur"": 229159.66,
""count"": ""1"",
""value"": ""1049070.00""
}
}
}
]
},
{
""id"": ""564100"",
""date"": ""2021-07-28"",
""deadline_date"": ""2021-08-10"",
""deadline_length_days"": ""12"",
""deadline_length_hours"": ""307"",
""title"": ""DOWÓZ UCZNIÓW DO SZKÓŁ PODSTAWOWYCH z terenu Miasta i Gminy Czerwińsk nad Wisłą W ROKU SZKOLNYM 2021/2022"",
""category"": ""services"",
""description"": ""1. Przedmiotem zamówienia są usługi przewozu, polegające na przywozie i odwozie uczniów do i ze szkół podstawowych, dla których organem prowadzącym jest Miasto i Gmina Czerwińsk nad Wisłą w dni nauki szkolnej w trybie stacjonarnym."",
""sid"": ""info:118136"",
""awarded_value"": ""368879.94"",
""awarded_currency"": ""PLN"",
""awarded_value_eur"": ""80578.42"",
""purchaser"": {
""id"": ""32254"",
""sid"": null,
""name"": null
},
""type"": {
""id"": ""art-275-pkt-1-ustawy"",
""name"": ""art. 275 pkt 1 ustawy"",
""slug"": ""art-275-pkt-1-ustawy""
},
""awarded"": [
{
""date"": ""2021-08-26"",
""value_for_two"": 0,
""value_for_two_eur"": 0,
""suppliers"": [
{
""name"": ""HM TRANS S.C. Hubert Kalman, Marcin Stasiak"",
""id"": 23025,
""slug"": ""hm-trans-s-c-hubert-kalman-marcin-stasiak""
}
],
""value_min"": ""368879.94"",
""value_for_three"": 368879.94,
""value_for_one_eur"": 0,
""count"": ""1"",
""value_for_one"": 0,
""value_for_three_eur"": 80578.42,
""suppliers_id"": ""23025"",
""value_eur"": 80578.42,
""value_max"": ""499196.50"",
""offers_count"": [
3
],
""suppliers_name"": ""HM TRANS S.C. Hubert Kalman, Marcin Stasiak"",
""value"": ""368879.94"",
""value_estimated"": null,
""offers_count_data"": {
""3"": {
""value_eur"": 80578.42,
""count"": ""1"",
""value"": ""368879.94""
}
}
}
]
},
{
""id"": ""564081"",
""date"": ""2021-07-22"",
""deadline_date"": ""2021-08-09"",
""deadline_length_days"": ""17"",
""deadline_length_hours"": ""431"",
""title"": ""„Modernizacja dachów na budynkach oświatowych Gminy Wolbrom w Gołaczewach i Zarzeczu oraz modernizacja budynku gminnego w Porębie Dzierżnej”."",
""category"": ""constructions"",
""description"": ""Przedmiotem zamówienia jest realizacja zadania pn. „Modernizacja dachów na budynkach oświatowych Gminy Wolbrom w Gołaczewach i Zarzeczu oraz modernizacja budynku gminnego w Porębie Dzierżnej”. Część nr 1: Modernizacja pokrycia dachowego na budynku szkoły w Gołaczewach."",
""sid"": ""info:118099"",
""awarded_value"": ""237321.96"",
""awarded_currency"": ""PLN"",
""awarded_value_eur"": ""51840.79"",
""purchaser"": {
""id"": ""834"",
""sid"": null,
""name"": null
},
""type"": {
""id"": ""art-275-pkt-2-ustawy"",
""name"": ""art. 275 pkt 2 ustawy"",
""slug"": ""art-275-pkt-2-ustawy""
},
""indicators"": [
""low_value_awarded""
],
""awarded"": [
{
""date"": ""2021-08-26"",
""value_for_two"": 237321.96,
""value_for_two_eur"": 51840.79,
""suppliers"": [
{
""name"": ""Firma Budowlano-Usługowa „Seka-Bud” Serafin Michał"",
""id"": 23023,
""slug"": ""firma-budowlano-uslugowa-seka-bud-serafin-michal""
}
],
""value_min"": ""237321.96"",
""value_for_three"": 237321.96,
""offers_count_status"": ""only_one"",
""value_for_one_eur"": 51840.79,
""count"": ""2"",
""value_for_one"": 237321.96,
""value_for_three_eur"": 51840.79,
""suppliers_id"": ""23023"",
""value_eur"": 51840.79,
""value_max"": ""172797.51"",
""offers_count"": [
1
],
""suppliers_name"": ""Firma Budowlano-Usługowa „Seka-Bud” Serafin Michał"",
""value"": ""237321.96"",
""value_estimated"": ""215947.90"",
""offers_count_data"": {
""1"": {
""value_eur"": 51840.79,
""count"": ""2"",
""value"": ""237321.96""
}
}
}
]
},
{
""id"": ""564034"",
""date"": ""2021-06-14"",
""deadline_date"": ""2021-06-22"",
""deadline_length_days"": ""7"",
""deadline_length_hours"": ""191"",
""title"": ""˜Zakup nowego ciężkiego samochodu ratowniczo-gaśniczego z napędem 4x4 dla Ochotniczej Straży Pożarnej w Gniewkowie"",
""category"": ""supplies"",
""description"": ""˜1. Przedmiotem zamówienia jest: Zakup nowego ciężkiego samochodu ratowniczo-gaśniczego z napędem 4x4 dla Ochotniczej Straży Pożarnej w Gniewkowie. 2. Pojazd oraz podwozie fabrycznie nowe, rok produkcji podwozia min. 2021, silnik, podwozie i kabina tego samego producenta.3. Szczegółowy opis przedmiotu zamówienia – stanowi załącznik nr 3 do SWZ."",
""sid"": ""info:118018"",
""awarded_value"": ""1088796.00"",
""awarded_currency"": ""PLN"",
""awarded_value_eur"": ""237837.44"",
""purchaser"": {
""id"": ""32248"",
""sid"": null,
""name"": null
},
""type"": {
""id"": ""art-275-pkt-1-ustawy"",
""name"": ""art. 275 pkt 1 ustawy"",
""slug"": ""art-275-pkt-1-ustawy""
},
""awarded"": [
{
""date"": ""2021-08-26"",
""value_for_two"": 1088796,
""value_for_two_eur"": 237837.44,
""suppliers"": [
{
""name"": ""SZCZĘŚNIAK Pojazdy Specjalne Sp. z o.o."",
""id"": 12978,
""slug"": ""szczesniak-pojazdy-specjalne-sp-z-o-o""
}
],
""value_min"": ""1088796.00"",
""value_for_three"": 1088796,
""offers_count_status"": ""only_one"",
""value_for_one_eur"": 237837.44,
""count"": ""1"",
""value_for_one"": 1088796,
""value_for_three_eur"": 237837.44,
""suppliers_id"": ""12978"",
""value_eur"": 237837.44,
""value_max"": ""1088796.00"",
""offers_count"": [
1
],
""suppliers_name"": ""SZCZĘŚNIAK Pojazdy Specjalne Sp. z o.o."",
""value"": ""1088796.00"",
""value_estimated"": null,
""offers_count_data"": {
""1"": {
""value_eur"": 237837.44,
""count"": ""1"",
""value"": ""1088796.00""
}
}
}
]
},
{
""id"": ""561428"",
""date"": ""2021-08-10"",
""deadline_date"": ""2021-08-18"",
""deadline_length_days"": ""7"",
""deadline_length_hours"": ""182"",
""title"": ""Świadczenie usług w zakresie sprzątania w budynku szkołyZespołu Szkolno-Przedszkolnego nr 22we Wrocławiu"",
""category"": ""services"",
""description"": ""1. Przedmiotem zamówienia jest świadczenie usług w zakresie sprzątania w okresie od 02.09.2021r. do 31.08.2022r., (z wyłączeniem miesiąca lipca) polegające na sprzątaniu i utrzymaniu czystości pomieszczeń i ciągów komunikacyjnych w budynku szkoły od poniedziałku do piątku od godz. 6.30 do 22.00. Szczegółowy zakres obowiązków Wykonawcy w oparciu o zał. nr 8 - Zestawienie powierzchni do sprzątania. Powierzchnia do sprzątania podłóg w budynku wynosi 3 114,30 m2"",
""sid"": ""info:113156"",
""awarded_value"": ""181500.00"",
""awarded_currency"": ""PLN"",
""awarded_value_eur"": ""39647.00"",
""purchaser"": {
""id"": ""20856"",
""sid"": null,
""name"": null
},
""type"": {
""id"": ""art-275-pkt-1-ustawy"",
""name"": ""art. 275 pkt 1 ustawy"",
""slug"": ""art-275-pkt-1-ustawy""
},
""awarded"": [
{
""date"": ""2021-08-26"",
""value_for_two"": 181500,
""value_for_two_eur"": 39647,
""suppliers"": [
{
""name"": ""„Pu Flora” Jacek Chojnacki"",
""id"": 23042,
""slug"": ""pu-flora-jacek-chojnacki""
}
],
""value_min"": ""181500.00"",
""value_for_three"": 181500,
""value_for_one_eur"": 0,
""count"": ""1"",
""value_for_one"": 0,
""value_for_three_eur"": 39647,
""suppliers_id"": ""23042"",
""value_eur"": 39647,
""value_max"": ""185631.60"",
""offers_count"": [
2
],
""suppliers_name"": ""„Pu Flora” Jacek Chojnacki"",
""value"": ""181500.00"",
""value_estimated"": null,
""offers_count_data"": {
""2"": {
""value_eur"": 39647,
""count"": ""1"",
""value"": ""181500.00""
}
}
}
]
},
{
""id"": ""564238"",
""date"": ""2021-06-21"",
""deadline_date"": ""2021-07-06"",
""deadline_length_days"": ""15"",
""deadline_length_hours"": ""363"",
""title"": ""Modernizacja dachu na budynku Szkoły Podstawowej w Skępem"",
""category"": ""constructions"",
""description"": ""1. Przedmiotem zamówienia jest Modernizacja dachu na budynku Szkoły Podstawowej w Skępem, zgodnie z dokumentacją projektową/techniczną oraz specyfikacją techniczną wykonania i odbioru robót.2. Szczegółowy opis przedmiotu zamówienia zawiera dokumentacja projektowa/techniczna (w zakresie wskazanym w pkt 1), która stanowi Załącznik nr 5 do SWZ oraz specyfikacja techniczna wykonania i odbioru robót stanowiąca Załącznik nr 6 do SWZ. Przedmiar robót/ kosztorys nakładczy stanowiący Załącznik nr 7 do SW"",
""sid"": ""info:118402"",
""awarded_value"": ""336515.70"",
""awarded_currency"": ""PLN"",
""awarded_value_eur"": ""73508.75"",
""purchaser"": {
""id"": ""32281"",
""sid"": null,
""name"": null
},
""type"": {
""id"": ""art-275-pkt-1-ustawy"",
""name"": ""art. 275 pkt 1 ustawy"",
""slug"": ""art-275-pkt-1-ustawy""
},
""awarded"": [
{
""date"": ""2021-08-25"",
""value_for_two"": 336515.7,
""value_for_two_eur"": 73508.75,
""suppliers"": [
{
""name"": ""Usługi Transportowe Produkcja i Handel Przemysław Skowroński"",
""id"": 23071,
""slug"": ""uslugi-transportowe-produkcja-i-handel-przemyslaw-skowronski""
}
],
""value_min"": ""336515.70"",
""value_for_three"": 336515.7,
""value_for_one_eur"": 0,
""count"": ""1"",
""value_for_one"": 0,
""value_for_three_eur"": 73508.75,
""suppliers_id"": ""23071"",
""value_eur"": 73508.75,
""value_max"": ""382530.00"",
""offers_count"": [
2
],
""suppliers_name"": ""Usługi Transportowe Produkcja i Handel Przemysław Skowroński"",
""value"": ""336515.70"",
""value_estimated"": null,
""offers_count_data"": {
""2"": {
""value_eur"": 73508.75,
""count"": ""1"",
""value"": ""336515.70""
}
}
}
]
},
{
""id"": ""564109"",
""date"": ""2021-07-13"",
""deadline_date"": ""2021-07-27"",
""deadline_length_days"": ""14"",
""deadline_length_hours"": ""337"",
""title"": ""Wykonanie podbudowy z gruntu rodzimego stabilizowanego spoiwem hydraulicznym: Droga nr 61 Nadleśnictwo Międzyrzecz, Rm 2,5 MPa gr. Warstwy 30 cm"",
""category"": ""constructions"",
""description"": ""Przedmiotem zamówienia jest wykonanie robót budowlanych polegających na Wykonanie podbudowy z gruntu rodzimego stabilizowanego spoiwem hydraulicznym: Droga nr 61 Nadleśnictwo Międzyrzecz, Rm 2,5 MPa gr. Warstwy 30 cm.Projektowana budowa nie spowoduje zmiany w sposobie zagospodarowania terenu."",
""sid"": ""info:118157"",
""awarded_value"": ""344404.00"",
""awarded_currency"": ""PLN"",
""awarded_value_eur"": ""75231.87"",
""purchaser"": {
""id"": ""3884"",
""sid"": null,
""name"": null
},
""type"": {
""id"": ""art-275-pkt-1-ustawy"",
""name"": ""art. 275 pkt 1 ustawy"",
""slug"": ""art-275-pkt-1-ustawy""
},
""awarded"": [
{
""date"": ""2021-08-25"",
""value_for_two"": 344404,
""value_for_two_eur"": 75231.87,
""suppliers"": [
{
""name"": ""Grupa MCE Zapaśnik i Konstańczak Spółka Jawna z siedzibą w Oławie"",
""id"": 23028,
""slug"": ""grupa-mce-zapasnik-i-konstanczak-spolka-jawna-z-siedziba-w-olawie""
}
],
""value_min"": ""344404.00"",
""value_for_three"": 344404,
""offers_count_status"": ""only_one"",
""value_for_one_eur"": 75231.87,
""count"": ""1"",
""value_for_one"": 344404,
""value_for_three_eur"": 75231.87,
""suppliers_id"": ""23028"",
""value_eur"": 75231.87,
""value_max"": ""344404.00"",
""offers_count"": [
1
],
""suppliers_name"": ""Grupa MCE Zapaśnik i Konstańczak Spółka Jawna z siedzibą w Oławie"",
""value"": ""344404.00"",
""value_estimated"": null,
""offers_count_data"": {
""1"": {
""value_eur"": 75231.87,
""count"": ""1"",
""value"": ""344404.00""
}
}
}
]
},
{
""id"": ""564063"",
""date"": ""2021-07-30"",
""deadline_date"": ""2021-08-09"",
""deadline_length_days"": ""9"",
""deadline_length_hours"": ""236"",
""title"": ""Przewozy dzieci z terenu gminy Ochotnica Dolna na zajęcia szkolne wraz z zapewnieniem opieki nad nimi w trakcie przewozów"",
""category"": ""services"",
""description"": ""Przedmiot zamówienia składa się z 4 oddzielnych zadań, tj.:Zadanie Iczęść 1) przewozy uczniów uczęszczających do Szkoły Podstawowej im. Jana Pawła II w Ochotnicy Dolnej;część 2) przewozy uczniów uczęszczających do Szkoły Podstawowej im. ks. prof. Józefa Tischnera w Ochotnicy Dolnej - Skrodne;część 3) przewozy uczniów uczęszczających do Szkoły Podstawowej im. Marii Konopnickiej w Ochotnicy Górnej;Zadanie II - przewozy uczniów uczęszczających do Specjalnego Ośrodka Szkolno-Wychowawczego Nr 1 w Now"",
""sid"": ""info:118065"",
""awarded_value"": ""75050.00"",
""awarded_currency"": ""PLN"",
""awarded_value_eur"": ""16393.98"",
""purchaser"": {
""id"": ""19146"",
""sid"": null,
""name"": null
},
""type"": {
""id"": ""art-275-pkt-1-ustawy"",
""name"": ""art. 275 pkt 1 ustawy"",
""slug"": ""art-275-pkt-1-ustawy""
},
""indicators"": [
""low_value_awarded""
],
""awarded"": [
{
""date"": ""2021-08-25"",
""value_for_two"": 75050,
""value_for_two_eur"": 16393.98,
""suppliers"": [
{
""name"": ""Usługi Przewozowe Jacek Syjud"",
""id"": 23018,
""slug"": ""uslugi-przewozowe-jacek-syjud""
}
],
""value_min"": ""75050.00"",
""value_for_three"": 75050,
""value_for_one_eur"": 0,
""count"": ""1"",
""value_for_one"": 0,
""value_for_three_eur"": 16393.98,
""suppliers_id"": ""23018"",
""value_eur"": 16393.98,
""value_max"": ""82080.00"",
""offers_count"": [
2
],
""suppliers_name"": ""Usługi Przewozowe Jacek Syjud"",
""value"": ""75050.00"",
""value_estimated"": ""91200.00"",
""offers_count_data"": {
""2"": {
""value_eur"": 16393.98,
""count"": ""1"",
""value"": ""75050.00""
}
}
}
]
},
{
""id"": ""564058"",
""date"": ""2021-08-10"",
""deadline_date"": ""2021-08-18"",
""deadline_length_days"": ""7"",
""deadline_length_hours"": ""189"",
""title"": ""Dowóz uczniów szkół gminy Bytów do Kompleksu Basenowo-Rekreacyjnego „Nimfa” w Bytowie oraz dowóz uczniów z niepełnosprawnością do szkół w gminie Bytów w roku szkolnym 2021/2022"",
""category"": ""services"",
""description"": ""Część I zamówienia - dowóz uczniów szkół gminy Bytów do Kompleksu Basenowo-Rekreacyjnego „Nimfa” w Bytowie w roku szkolnym 2021/2022.Łączna długość tras w miesiącu wynosi około 970 km. Wykonawca musi dysponować taką ilością pojazdów, aby można było przewieźć na zajęcia do trzech grup uczniów (z trzech szkół) w tym samym czasie."",
""sid"": ""info:118053"",
""awarded_value"": ""104760.00"",
""awarded_currency"": ""PLN"",
""awarded_value_eur"": ""22883.86"",
""purchaser"": {
""id"": ""23788"",
""sid"": null,
""name"": null
},
""type"": {
""id"": ""art-275-pkt-1-ustawy"",
""name"": ""art. 275 pkt 1 ustawy"",
""slug"": ""art-275-pkt-1-ustawy""
},
""indicators"": [
""low_value_awarded""
],
""awarded"": [
{
""date"": ""2021-08-25"",
""value_for_two"": 104760,
""value_for_two_eur"": 22883.86,
""suppliers"": [
{
""name"": ""Przedsiębiorstwo Komunikacji Samochodowej w Bytowie Spółka Akcyjna"",
""id"": 23014,
""slug"": ""przedsiebiorstwo-komunikacji-samochodowej-w-bytowie-spolka-akcyjna""
}
],
""value_min"": ""104760.00"",
""value_for_three"": 104760,
""offers_count_status"": ""only_one"",
""value_for_one_eur"": 22883.86,
""count"": ""1"",
""value_for_one"": 104760,
""value_for_three_eur"": 22883.86,
""suppliers_id"": ""23014"",
""value_eur"": 22883.86,
""value_max"": ""104760.00"",
""offers_count"": [
1
],
""suppliers_name"": ""Przedsiębiorstwo Komunikacji Samochodowej w Bytowie Spółka Akcyjna"",
""value"": ""104760.00"",
""value_estimated"": ""103693.00"",
""offers_count_data"": {
""1"": {
""value_eur"": 22883.86,
""count"": ""1"",
""value"": ""104760.00""
}
}
}
]
},
{
""id"": ""564009"",
""date"": ""2021-07-20"",
""deadline_date"": ""2021-07-29"",
""deadline_length_days"": ""8"",
""deadline_length_hours"": ""213"",
""title"": ""KONSERWACJA I PRZEGLĄD URZĄDZEŃ WENTYLACYJNYCH I KLIMATYZACYJNYCH W BUDYNKACH INSTYTUT HEMATOLOGII I TRANSFUZJOLOGII W WARSZAWIE W SIEDZIBACH PRZY UL. I. GANDHI 14 I CHOCIMSKIEJ 5"",
""category"": ""services"",
""description"": ""Przedmiotem postępowania jest konserwacja i przeglądy urządzeń wentylacyjnych i klimatyzacyjnych w budynkach Instytutu Hematologii i Transfuzjologii w Warszawie w siedzibach przy ul. I. Gandhi 14 i Chocimskiej 5.Więcej informacji zawiera: Załącznik nr 1A, 1B, 1C, 1D do SWZ."",
""sid"": ""info:117961"",
""awarded_value"": ""17600.00"",
""awarded_currency"": ""PLN"",
""awarded_value_eur"": ""3844.56"",
""purchaser"": {
""id"": ""25189"",
""sid"": null,
""name"": null
},
""type"": {
""id"": ""art-275-pkt-1-ustawy"",
""name"": ""art. 275 pkt 1 ustawy"",
""slug"": ""art-275-pkt-1-ustawy""
},
""awarded"": [
{
""date"": ""2021-08-25"",
""value_for_two"": 0,
""value_for_two_eur"": 0,
""suppliers"": [
{
""name"": ""Mera Technik Sp. z o.o."",
""id"": 23004,
""slug"": ""mera-technik-sp-z-o-o""
}
],
""value_min"": ""176000.00"",
""value_for_three"": 17600,
""value_for_one_eur"": 0,
""count"": ""1"",
""value_for_one"": 0,
""value_for_three_eur"": 3844.56,
""suppliers_id"": ""23004"",
""value_eur"": 3844.56,
""value_max"": ""1020000.00"",
""offers_count"": [
3
],
""suppliers_name"": ""Mera Technik Sp. z o.o."",
""value"": ""17600.00"",
""value_estimated"": null,
""offers_count_data"": {
""3"": {
""value_eur"": 3844.56,
""count"": ""1"",
""value"": ""17600.00""
}
}
}
]
}
]
}
            ";
    }
}
