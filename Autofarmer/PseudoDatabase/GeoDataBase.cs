using Autofarmer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Autofarmer.PseudoDatabase
{
    internal static class GeoDataBase
    {
        public static Country[] Countries { get; set; }   
        public static CityGeolocation[] CityGeolocations { get; set; }


        static GeoDataBase()
        {
            Countries = [
                new Country(1, "USA"),
                new Country(2, "New Zealand"),
                new Country(3, "Canada"),
                new Country(4, "Sweden"),
                new Country(5, "Germany"),
                new Country(6, "Australia"),
                new Country(7, "Ireland"),
                new Country(8, "Netherlands"),
                new Country(9, "Austria"),
                new Country(10, "Italy"),
                new Country(12, "Finland"),
                new Country(11, "France"),
                new Country(13, "Great Britain"),
                new Country(14, "Hungary"),
                new Country(15, "Spain"),
                new Country(16, "Belgium"),
                new Country(17, "Denmark"),
                new Country(18, "Norway"),
                new Country(19, "UAE"),
                new Country(20, "Switzerland"),
                new Country(21, "Israel"),
                new Country(22, "South Korea"),
                new Country(23, "China"),
                new Country(24, "Iceland"),
                new Country(25, "Japan"),
            ];

            //649

            Country US = Countries.FirstOrDefault(c => c.Name == "USA")!;
            Country NZ = Countries.FirstOrDefault(c => c.Name == "New Zealand")!;
            Country CA = Countries.FirstOrDefault(c => c.Name == "Canada")!;
            Country SE = Countries.FirstOrDefault(c => c.Name == "Sweden")!;
            Country DE = Countries.FirstOrDefault(c => c.Name == "Germany")!;
            Country AU = Countries.FirstOrDefault(c => c.Name == "Australia")!;
            Country IE = Countries.FirstOrDefault(c => c.Name == "Ireland")!;
            Country NL = Countries.FirstOrDefault(c => c.Name == "Netherlands")!;
            Country AT = Countries.FirstOrDefault(c => c.Name == "Austria")!;
            Country FI = Countries.FirstOrDefault(c => c.Name == "Finland")!;
            Country FR = Countries.FirstOrDefault(c => c.Name == "France")!;
            Country GB = Countries.FirstOrDefault(c => c.Name == "Great Britain")!;
            Country BE = Countries.FirstOrDefault(c => c.Name == "Belgium")!;
            Country NO = Countries.FirstOrDefault(c => c.Name == "Norway")!;
            Country CH = Countries.FirstOrDefault(c => c.Name == "Switzerland")!;
            Country KR = Countries.FirstOrDefault(c => c.Name == "South Korea")!;
            Country IS = Countries.FirstOrDefault(c => c.Name == "Iceland")!;


            CityGeolocations = [
               //usa partial
               
                new CityGeolocation(US, "New York", 40.70771001, -74.08630371, 40.81276986, -73.91601563),
                new CityGeolocation(US, "Los Angeles", 33.96101678, -118.32962036, 34.09474770, -118.17100525),
                new CityGeolocation(US, "Chicago", 41.85294071, -87.65819550, 41.88668781, -87.61802673),
                new CityGeolocation(US, "Houston", 29.71012130, -95.44441223, 29.80609284, -95.28030396),
                new CityGeolocation(US, "Philadelphia", 39.92816810, -75.20244598, 39.98580147, -75.13172150),
                new CityGeolocation(US, "Phoenix", 33.43889050, -112.14775085, 33.50704925, -111.99050903),
                new CityGeolocation(US, "San Antonio", 29.39713197, -98.53019714, 29.44886586, -98.46084595),
                new CityGeolocation(US, "San Diego", 32.70728895, -117.17004776, 32.72339290, -117.15571404),
                new CityGeolocation(US, "Dallas", 32.74685758, -96.82388306, 32.81382424, -96.75212860),
                new CityGeolocation(US, "San Jose", 37.25820564, -121.96678162, 37.42525247, -121.84249878),
                new CityGeolocation(US, "Austin", 30.23237435, -97.78072357, 30.30264994, -97.67223358),
                new CityGeolocation(US, "Jacksonville", 30.32428587, -81.70618057, 30.36235942, -81.62755966),
                new CityGeolocation(US, "San Francisco", 37.73447587, -122.43713379, 37.80666460, -122.39696503),
                new CityGeolocation(US, "Indianapolis", 39.73729032, -86.16920471, 39.81038217, -86.10157013),
                new CityGeolocation(US, "Fort Worth", 32.71046664, -97.35157013, 32.75804625, -97.31964111),
                new CityGeolocation(US, "Columbus", 39.94975341, -83.03844452, 40.00920937, -82.93853760),
                new CityGeolocation(US, "Detroit", 42.31844717, -83.15345764, 42.44423464, -83.01750183),
                new CityGeolocation(US, "El Paso", 31.75955334, -106.50060654, 31.78436280, -106.46541595),
                new CityGeolocation(US, "Seattle", 47.58104186, -122.33774185, 47.62502494, -122.31044769),
                new CityGeolocation(US, "Denver", 39.69767751, -105.02758026, 39.77767195, -104.91462708),
                new CityGeolocation(US, "Memphis", 35.10713022, -90.05475998, 35.14882798, -90.01132965),
                new CityGeolocation(US, "Nashville", 36.14827156, -86.79748535, 36.16864538, -86.77207947),
                new CityGeolocation(US, "Baltimore", 39.28475543, -76.64714813, 39.31384734, -76.57230377),
                new CityGeolocation(US, "Boston", 42.34090957, -71.07158661, 42.36558359, -71.04987144),
                new CityGeolocation(US, "Oklahoma City", 35.46304687, -97.54795074, 35.49296202, -97.50143051),
                new CityGeolocation(US, "Portland", 45.51236185, -122.69668579, 45.53088387, -122.64553070),
                new CityGeolocation(US, "Washington, D.C.", 38.89156727, -77.05312729, 38.91948630, -77.01622009),
                new CityGeolocation(US, "Washington", 38.89156727, -77.05312729, 38.91948630, -77.01622009),
                new CityGeolocation(US, "Louisville", 38.23696664, -85.77730179, 38.25637996, -85.73455811),
                new CityGeolocation(US, "Las Vegas", 36.09627357, -115.23902893, 36.22433449, -115.06530762),
                new CityGeolocation(US, "Milwaukee", 43.03363903, -87.96804428, 43.07064341, -87.89749146),

                //new zealand partial
                new CityGeolocation(NZ, "Auckland", -36.89678263, 174.73257065, -36.84610922, 174.78715897),
                new CityGeolocation(NZ, "Christchurch", -43.55153408, 172.61100769, -43.51519470, 172.66250610),
                new CityGeolocation(NZ, "Wellington", -41.29954051, 174.76552963, -41.27954804, 174.78157997),
                new CityGeolocation(NZ, "Hamilton", -37.80435891, 175.25356293, -37.77017197, 175.30094147),
                new CityGeolocation(NZ, "Tauranga", -37.71343018, 176.15564346, -37.67682361, 176.16997719),
                new CityGeolocation(NZ, "Lower Hutt", -41.23276753, 174.89135742, -41.20526432, 174.92036819),
                new CityGeolocation(NZ, "Dunedin", -45.90864435, 170.48343658, -45.86634552, 170.51210403),
                new CityGeolocation(NZ, "New Plymouth", -39.06764698, 174.06463623, -39.05258492, 174.08961296),
                new CityGeolocation(NZ, "Palmerston", -40.37165889, 175.59310913, -40.33803961, 175.63499451),
                new CityGeolocation(NZ, "Palmerston", -39.51013316, 176.88537598, -39.48059302, 176.91936493),

                //canada COMPLETE
                new CityGeolocation(CA, "Toronto", 43.64154137, -79.45449829, 43.76068042, -79.30824280),
                new CityGeolocation(CA, "Montreal", 45.45338760, -73.72512817, 45.56983236, -73.54728699),
                new CityGeolocation(CA, "Calgary", 50.99949673, -114.13558960, 51.08152780, -113.96186829),
                new CityGeolocation(CA, "Ottawa", 45.36444864, -75.73047638, 45.44495767, -75.64361572),
                new CityGeolocation(CA, "Edmonton", 53.48641131, -113.56979370, 53.57864615, -113.41323853),
                new CityGeolocation(CA, "Winnipeg", 49.82380909, -97.20153809, 49.93398605, -97.04635620),
                new CityGeolocation(CA, "Mississauga", 43.55750558, -79.74014282, 43.64402585, -79.58290100),
                new CityGeolocation(CA, "Vancouver", 49.21737285, -123.18145752, 49.27990050, -123.02421570),
                new CityGeolocation(CA, "Brampton", 43.65296912, -79.80091095, 43.71553473, -79.72846985),
                new CityGeolocation(CA, "Scarborough", 43.74803313, -79.28369522, 43.79104777, -79.22721863),
                new CityGeolocation(CA, "Hamilton", 43.23069601, -79.90047455, 43.27033118, -79.83575821),
                new CityGeolocation(CA, "Surrey", 49.10399413, -122.89100647, 49.20929900, -122.77187347),
                new CityGeolocation(CA, "Halifax", 44.63592543, -63.59942436, 44.65540537, -63.58071327),
                new CityGeolocation(CA, "Laval", 45.46783598, -73.61011505, 45.51597052, -73.55329514),
                new CityGeolocation(CA, "London", 42.95705068, -81.26037598, 43.00753438, -81.20956421),
                new CityGeolocation(CA, "Markham", 43.82536290, -79.36214447, 43.87661302, -79.29416656),
                new CityGeolocation(CA, "Gatineau", 45.39519541, -75.71537018, 45.42833496, -75.67339897),
                new CityGeolocation(CA, "Saskatoon", 52.12350313, -106.67707443, 52.13530563, -106.65617466),
                new CityGeolocation(CA, "Kitchener", 43.43222913, -80.50678253, 43.46064458, -80.47991753),
                new CityGeolocation(CA, "Longueuil", 45.50526414, -73.49475861, 45.52920030, -73.44120026),
                new CityGeolocation(CA, "Burnaby", 49.22230622, -123.01237106, 49.25906675, -122.97580719),
                new CityGeolocation(CA, "Regina", 50.44187322, -104.64039803, 50.46580920, -104.58417892),
                new CityGeolocation(CA, "Oakville", 43.44388357, -79.67362404, 43.45167272, -79.66220856),
                new CityGeolocation(CA, "Richmond", 49.13387945, -123.18214417, 49.17115466, -123.11553955),
                new CityGeolocation(CA, "Richmond Hill", 43.86176245, -79.44934845, 43.88787224, -79.42359924),
                new CityGeolocation(CA, "Burlington", 43.32180586, -79.81704712, 43.34540467, -79.78185654),
                new CityGeolocation(CA, "Oshawa", 43.87314822, -78.87634277, 43.91533086, -78.84304047),

                //sweden COMPLETE
                new CityGeolocation(SE, "Stockholm", 59.31059273, 18.04281235, 59.34859561, 18.09997559),
                new CityGeolocation(SE, "Gothenburg", 57.69222204, 11.94969177, 57.72376939, 12.00839996),
                new CityGeolocation(SE, "Malmo", 55.57271615, 12.96489716, 55.61151715, 13.04248810),
                new CityGeolocation(SE, "Uppsala", 59.84817778, 17.62241364, 59.87188102, 17.66807556),
                new CityGeolocation(SE, "Helsingborg", 56.02291210, 12.69978762, 56.06916098, 12.72594452),
                new CityGeolocation(SE, "Umea", 63.82537690, 20.24488449, 63.82855701, 20.28385162),
                new CityGeolocation(SE, "Örebro", 59.26079200, 15.19752502, 59.28613986, 15.23838043),
                new CityGeolocation(SE, "Västerås", 59.60161667, 16.52069092, 59.62566891, 16.56360626),
                new CityGeolocation(SE, "Karlstad", 59.37518983, 13.48520279, 59.38751758, 13.51764679),
                new CityGeolocation(SE, "Luleå", 65.57819791, 22.13350296, 65.60898221, 22.17864990),
                new CityGeolocation(SE, "Norrköping", 58.57568161, 16.15367889, 58.60198455, 16.22440338),
                new CityGeolocation(SE, "Södertälje", 59.17715967, 17.59906769, 59.20511847, 17.65914917),
                new CityGeolocation(SE, "Halmstad", 56.66584954, 12.82413483, 56.68301396, 12.89245605),
                new CityGeolocation(SE, "Eskilstuna", 59.37230397, 16.47193909, 59.38305912, 16.53991699),

                //germany COMPLETE
                new CityGeolocation(DE, "Berlin", 52.47943476, 13.31989288, 52.54128466, 13.45207214),
                new CityGeolocation(DE, "Hamburg", 53.54907943, 9.90039825, 53.59331988, 10.0686264),
                new CityGeolocation(DE, "Munich", 48.12118429, 11.52843475, 48.16379550, 11.64104462),
                new CityGeolocation(DE, "Cologne", 50.90714636, 6.91555023, 50.98091165, 7.03983307),
                new CityGeolocation(DE, "Frankfurt am Main", 50.09635771, 8.63697052, 50.13246362, 8.71765137),
                new CityGeolocation(DE, "Stuttgart", 48.77033305, 9.15830612, 48.78944980, 9.20259476),
                new CityGeolocation(DE, "Leipzig", 51.32696471, 12.36459732, 51.35773999, 12.41678238),
                new CityGeolocation(DE, "Dortmund", 51.48352095, 7.40615845, 51.53437714, 7.51602173),
                new CityGeolocation(DE, "Essen", 51.43539042, 6.97803497, 51.46726920, 7.03056335),
                new CityGeolocation(DE, "Bremen", 53.06638887, 8.77824783, 53.08577660, 8.86253357),
                new CityGeolocation(DE, "Dresden", 51.02844006, 13.70544434, 51.05736532, 13.77410889),
                new CityGeolocation(DE, "Hanover", 52.35798989, 9.70951080, 52.39403947, 9.74899292),
                new CityGeolocation(DE, "Nuremberg", 49.43218930, 11.04915619, 49.46968585, 11.10923767),
                new CityGeolocation(DE, "Duisburg", 51.40434606, 6.71333313, 51.44288072, 6.78268433),
                new CityGeolocation(DE, "Bochum", 51.46095940, 7.20085144, 51.49581284, 7.22986221),
                new CityGeolocation(DE, "Wuppertal", 51.25106425, 7.14540482, 51.27813227, 7.19793320),
                new CityGeolocation(DE, "Bielefeld", 52.01880372, 8.51852417, 52.03433024, 8.56229782),
                new CityGeolocation(DE, "Bonn", 50.72298153, 7.08480835, 50.75274868, 7.12909698),
                new CityGeolocation(DE, "Mannheim", 49.48095153, 8.45895767, 49.49399863, 8.47414970),
                new CityGeolocation(DE, "Karlsruhe", 48.99474862, 8.37226868, 49.01186572, 8.43063354),
                new CityGeolocation(DE, "Augsburg", 48.36103968, 10.88195801, 48.37917163, 10.91096878),
                new CityGeolocation(DE, "Wiesbaden", 50.07135384, 8.23099136, 50.09327424, 8.26000214),
                new CityGeolocation(DE, "Gelsenkirchen", 51.50318638, 7.07965851, 51.52070710, 7.11296082),
                new CityGeolocation(DE, "Aachen", 50.76708230, 6.07269287, 50.78124873, 6.09294891),
                new CityGeolocation(DE, "Braunschweig", 52.25554946, 10.50619125, 52.27319954, 10.54121017),
                new CityGeolocation(DE, "Chemnitz", 50.82502352, 12.90550232, 50.84009382, 12.94120789),
                new CityGeolocation(DE, "Halle", 51.47325736, 11.96256638, 51.48982764, 11.97853088),
                new CityGeolocation(DE, "Magdeburg", 52.12400374, 11.61684036, 52.15108133, 11.66044235),
                new CityGeolocation(DE, "Freiburg im Breisgau", 47.99187470, 7.83488274, 48.00094958, 7.85779953),
                new CityGeolocation(DE, "Krefeld", 51.32095736, 6.54819489, 51.34766256, 6.59162521),
                new CityGeolocation(DE, "Mainz", 49.98302008, 8.24609756, 50.01369614, 8.29124451),
                new CityGeolocation(DE, "Erfurt", 50.97069749, 11.01250648, 50.98545055, 11.04005814),
                new CityGeolocation(DE, "Oberhausen", 51.45764373, 6.82456970, 51.48031383, 6.88602448),
                new CityGeolocation(DE, "Potsdam", 52.39582023, 13.03956985, 52.41697431, 13.06652069),

                //australia COMPLETE
                new CityGeolocation(AU, "Adelaide", -34.96924965, 138.52043152, -34.85550981, 138.66531372),
                new CityGeolocation(AU, "Sydney", -33.91743764, 151.15779877, -33.87326611, 151.23847961),
                new CityGeolocation(AU, "Brisbane", -27.48847661, 152.99697876, -27.44095455, 153.04744720),
                new CityGeolocation(AU, "Perth", -31.96293993, 115.80757141, -31.88980161, 115.88619232),
                new CityGeolocation(AU, "Gold Coast", -28.01652922, 153.38802338, -27.97530116, 153.42956543),
                new CityGeolocation(AU, "Newcastl", -32.93608125, 151.72050476, -32.92585158, 151.79140091),
                new CityGeolocation(AU, "Canberra", -35.34593540, 149.08138275, -35.30251763, 149.13940430),
                new CityGeolocation(AU, "Wollongong", -34.43905313, 150.86717606, -34.41629201, 150.90399742),
                new CityGeolocation(AU, "Hobart", -42.90331917, 147.31052399, -42.87464321, 147.33163834),
                new CityGeolocation(AU, "Geelong", -38.16223093, 144.33683395, -38.14836132, 144.37429905),
                new CityGeolocation(AU, "Townsville", -19.28198019, 146.81141853, -19.25451346, 146.83364868),
                new CityGeolocation(AU, "Cairns", -16.94433496, 145.74274063, -16.91296838, 145.77363968),
                new CityGeolocation(AU, "Darwin", -12.46423457, 130.83437920, -12.45208216, 130.84776878),
                new CityGeolocation(AU, "Toowoomba", -27.57486239, 151.93233490, -27.55424253, 151.97181702),
                new CityGeolocation(AU, "Ballarat", -37.57424269, 143.83712769, -37.55628159, 143.88072968),
                new CityGeolocation(AU, "Bendigo", -36.77409249, 144.26731110, -36.74589958, 144.30679321),
                new CityGeolocation(AU, "Launceston", -41.45192637, 147.13439941, -41.43204502, 147.15199471),
                new CityGeolocation(AU, "Rockhampton", -23.38748267, 150.49900532, -23.37590166, 150.51672935),
                new CityGeolocation(AU, "Bunbury", -33.35920865, 115.62114716, -33.32608194, 115.66337585),
                new CityGeolocation(AU, "Geraldton", -28.78345775, 114.61091995, -28.76698197, 114.62430954),

                //ireland COMPLETE
                new CityGeolocation(IE, "Dublin", 53.30133845, -6.33636475, 53.39888863, -6.19766235),
                new CityGeolocation(IE, "Cork", 51.87882240, -8.48505020, 51.91134377, -8.44488144),
                new CityGeolocation(IE, "Limerick", 52.64858359, -8.63851547, 52.67388406, -8.61379623),
                new CityGeolocation(IE, "Galway", 53.26788234, -9.06955719, 53.28399791, -9.04252052),
                new CityGeolocation(IE, "Bandon", 51.73845703, -8.74610424, 51.75001586, -8.72666359),
                new CityGeolocation(IE, "Waterford", 52.24955944, -7.13424683, 52.26258932, -7.10643768),
                new CityGeolocation(IE, "Drogheda", 53.70524284, -6.36434555, 53.72530665, -6.33627892),
                new CityGeolocation(IE, "Dundalk", 53.99288613, -6.41550064, 54.00776876, -6.37850761),
                new CityGeolocation(IE, "Swords", 53.45023805, -6.23662949, 53.46531399, -6.20590210),
                new CityGeolocation(IE, "Navan", 53.64657121, -6.69874191, 53.66066189, -6.67050362),
                new CityGeolocation(IE, "Bray", 53.18927047, -6.12599373, 53.21209819, -6.10505104),
                new CityGeolocation(IE, "Ennis", 52.83777297, -8.99179459, 52.84560132, -8.97831917),
                new CityGeolocation(IE, "Carlow", 52.83580270, -6.93640709, 52.84299635, -6.91542149),
                new CityGeolocation(IE, "Kilkenny", 52.64280303, -7.26093292, 52.66248505, -7.23544121),
                new CityGeolocation(IE, "Naas", 53.21250939, -6.66337967, 53.23573571, -6.64981842),
                new CityGeolocation(IE, "Tralee", 52.26500573, -9.71706390, 52.28296710, -9.69260216),

                //netherlands COMPLETE
                new CityGeolocation(NL, "Amsterdam", 52.33617820, 4.83261108, 52.42461660, 4.94659424),
                new CityGeolocation(NL, "Rotterdam", 51.90594283, 4.42405701, 51.94214849, 4.50508118),
                new CityGeolocation(NL, "The Hague", 52.03939895, 4.26475525, 52.10523997, 4.38354492),
                new CityGeolocation(NL, "Utrecht", 52.05945698, 5.07877350, 52.11240909, 5.14537811),
                new CityGeolocation(NL, "Eindhoven", 51.41912152, 5.44372559, 51.45700196, 5.50415039),
                new CityGeolocation(NL, "Tilburg", 51.54163767, 5.04444122, 51.58090989, 5.11001587),
                new CityGeolocation(NL, "Almere", 52.34435885, 5.17765045, 52.40241887, 5.27515411),
                new CityGeolocation(NL, "Groningen", 53.19636688, 6.53068542, 53.23522199, 6.60655975),
                new CityGeolocation(NL, "Nijmegen", 51.81625594, 5.80249786, 51.84680772, 5.87940216),
                new CityGeolocation(NL, "Apeldoorn", 52.19413974, 5.93364716, 52.23032287, 6.00025177),
                new CityGeolocation(NL, "Arnhem", 51.97642166, 5.90497971, 51.99333702, 5.93793869),
                new CityGeolocation(NL, "Haarlem", 52.37287439, 4.61116791, 52.40597964, 4.65648651),
                new CityGeolocation(NL, "Enschede", 52.20245185, 6.86164856, 52.23295131, 6.91057205),
                new CityGeolocation(NL, "Amersfoort", 52.14297032, 5.36939621, 52.16824652, 5.40716171),
                new CityGeolocation(NL, "Hertogenbosch", 51.68522172, 5.27875900, 51.73213164, 5.34124374),
                new CityGeolocation(NL, "Zwolle", 52.49835419, 6.08333588, 52.52572590, 6.12367630),
                new CityGeolocation(NL, "Leiden", 52.14665733, 4.47692871, 52.16772008, 4.51589584),
                new CityGeolocation(NL, "Maastricht", 50.84280379, 5.67967415, 50.85786835, 5.71743965),
                new CityGeolocation(NL, "Dordrecht", 51.79439021, 4.65597153, 51.81784769, 4.67708588),
                new CityGeolocation(NL, "Alkmaar", 52.61915208, 4.73399162, 52.63634457, 4.76531982),
                new CityGeolocation(NL, "Delft", 51.99058871, 4.34320450, 52.01743037, 4.37135696),
                new CityGeolocation(NL, "Venlo", 51.35752560, 6.16581917, 51.37922754, 6.18787766),
                new CityGeolocation(NL, "Deventer", 52.25323762, 6.15019798, 52.26243172, 6.17362976),
                new CityGeolocation(NL, "Amstelveen", 52.29168256, 4.84445572, 52.30800632, 4.86883163),
                new CityGeolocation(NL, "Helmond", 51.47240196, 5.64165115, 51.48555201, 5.67272186),
                new CityGeolocation(NL, "Oss", 51.75679035, 5.51307678, 51.77431961, 5.54560661),
                new CityGeolocation(NL, "Leeuwarden", 53.19610978, 5.77528954, 53.20880846, 5.81288338),
                new CityGeolocation(NL, "Hilversum", 52.21402307, 5.15636444, 52.23494882, 5.19584656),
                new CityGeolocation(NL, "Heerlen", 50.87753165, 5.97441673, 50.89588741, 5.99269867),
                new CityGeolocation(NL, "Purmerend", 52.49281509, 4.94470596, 52.51648202, 4.97697830),
                new CityGeolocation(NL, "Hengelo", 52.25449863, 6.77332878, 52.27225418, 6.80680275),
                new CityGeolocation(NL, "Lelystad", 52.50112347, 5.46072006, 52.52107809, 5.49651146),
                new CityGeolocation(NL, "Schiedam", 51.90970238, 4.38672066, 51.92325532, 4.41573143),
                new CityGeolocation(NL, "Gouda", 52.00749872, 4.69923019, 52.01954320, 4.72721100),
                new CityGeolocation(NL, "Almelo", 52.34771457, 6.65659904, 52.36150183, 6.67247772),
                new CityGeolocation(NL, "Roermond", 51.18735937, 5.98282814, 51.19822500, 6.01020813),
                new CityGeolocation(NL, "Den Helder", 52.95355059, 4.74978447, 52.96306414, 4.76798058),
                new CityGeolocation(NL, "Osterhout", 51.63677159, 4.84497070, 51.65328240, 4.86986160),
                new CityGeolocation(NL, "Zeist", 52.08108844, 5.22090912, 52.09427321, 5.24339676),
                new CityGeolocation(NL, "Middelburg", 51.49228594, 3.60119820, 51.50692612, 3.62857819),

                //austria COMPLETE
                new CityGeolocation(AT, "Vienna", 48.17593092, 16.32431030, 48.24113824, 16.41014099),
                new CityGeolocation(AT, "Graz", 47.03316260, 15.39527893, 47.09910986, 15.45639038),
                new CityGeolocation(AT, "Linz", 48.28570594, 14.26694870, 48.31779345, 14.30643082),
                new CityGeolocation(AT, "Salzburg", 47.79009354, 13.01845551, 47.82260656, 13.06137085),

                //italy none

                //finland COMPLETE
                new CityGeolocation(FI, "Helsinki", 60.16324795, 24.92317200, 60.17268404, 24.95201111),
                new CityGeolocation(FI, "Espoo", 60.20163720, 24.65310574, 60.20797063, 24.66254711),
                new CityGeolocation(FI, "Tampere", 61.49268245, 23.74394417, 61.50509222, 23.78625870),
                new CityGeolocation(FI, "Oulu", 65.00450442, 25.46416283, 65.01498368, 25.48158646),
                new CityGeolocation(FI, "Turku", 60.44646653, 22.24662781, 60.45751404, 22.27280617),

                //france COMPLETE
                new CityGeolocation(FR, "Paris", 48.81884597, 2.29202271, 48.89767817, 2.39604950),
                new CityGeolocation(FR, "Marcel", 43.27820513, 5.35892487, 43.31431226, 5.39394379),
                new CityGeolocation(FR, "Lyon", 45.74536554, 4.80136871, 45.77315074, 4.86763000),
                new CityGeolocation(FR, "Toulouse", 43.58424567, 1.42187119, 43.62029489, 1.46650314),
                new CityGeolocation(FR, "Nice", 43.69356971, 7.25149155, 43.70908256, 7.27603912),
                new CityGeolocation(FR, "Nantes", 47.17244450, -1.59301758, 47.25336867, -1.51165009),
                new CityGeolocation(FR, "Montpellier", 43.58287786, 3.85499954, 43.62427141, 3.90632629),
                new CityGeolocation(FR, "Strasbourg", 48.55979535, 7.68802643, 48.60453868, 7.79170990),
                new CityGeolocation(FR, "Bordeaux", 44.78938889, -0.64647675, 44.87630874, -0.51258087),
                new CityGeolocation(FR, "Lille", 50.59892964, 2.99720764, 50.67840411, 3.14552307),
                new CityGeolocation(FR, "Toulon", 43.12216144, 5.91716766, 43.13299853, 5.94523430),
                new CityGeolocation(FR, "Reims", 49.24987918, 4.02391434, 49.26898068, 4.05455589),
                new CityGeolocation(FR, "Saint-Etienne", 45.42881685, 4.38191414, 45.44736635, 4.40217018),
                new CityGeolocation(FR, "Havre", 49.48630461, 0.10007858, 49.50949451, 0.15312195),
                new CityGeolocation(FR, "Dijon", 47.31526096, 5.03302574, 47.33126081, 5.05173683),
                new CityGeolocation(FR, "Grenoble", 45.16194785, 5.71374893, 45.19328841, 5.75443268),
                new CityGeolocation(FR, "Angers", 47.45943343, -0.56013107, 47.48362685, -0.53249359),
                new CityGeolocation(FR, "Villeurbanne", 45.75458889, 4.86179352, 45.78254907, 4.90264893),
                new CityGeolocation(FR, "St. Denis", 48.92999958, 2.35090256, 48.94448947, 2.37210274),
                new CityGeolocation(FR, "Nîmes", 43.82474367, 4.35195923, 43.84381306, 4.36955452),
                new CityGeolocation(FR, "Aix-en-Provence", 43.52372149, 5.43784618, 43.53258931, 5.45488358),
                new CityGeolocation(FR, "Clermont-Ferrand", 45.76728347, 3.07076454, 45.78637978, 3.09840202),
                new CityGeolocation(FR, "Le Mans", 47.99692926, 0.19097328, 48.01013770, 0.20256042),
                new CityGeolocation(FR, "Brest", 48.38418814, -4.49435234, 48.40003250, -4.47246552),
                new CityGeolocation(FR, "Thor", 43.92278084, 4.98663425, 43.93047715, 5.00131130),
                new CityGeolocation(FR, "Amiens", 49.88296643, 2.27597237, 49.89640370, 2.30996132),
                new CityGeolocation(FR, "Limoges", 45.82694520, 1.24033928, 45.84040064, 1.27621651),
                new CityGeolocation(FR, "Boulogne-Billancourt", 48.82788748, 2.22979546, 48.84218104, 2.25219727),
                new CityGeolocation(FR, "Perpignan", 42.68155205, 2.87532806, 42.70337976, 2.90966034),

                //great britain COMPLETE
                new CityGeolocation(GB, "Birmingham", 52.46437703, -1.93702698, 52.49845869, -1.86012268),
                new CityGeolocation(GB, "Leeds", 53.77286279, -1.57636642, 53.82031444, -1.49791718),
                new CityGeolocation(GB, "Liverpool", 53.39366839, -2.98982620, 53.43029893, -2.94622421),
                new CityGeolocation(GB, "Sheffield", 53.37047662, -1.48624420, 53.38834513, -1.45208359),
                new CityGeolocation(GB, "Manchester", 53.46955473, -2.26060867, 53.48814767, -2.22421646),
                new CityGeolocation(GB, "Bristol", 51.43292905, -2.61028290, 51.46780389, -2.56702423),
                new CityGeolocation(GB, "Leicester", 52.61764090, -1.15905762, 52.64608399, -1.10017776),
                new CityGeolocation(GB, "Coventry", 52.40205231, -1.52272224, 52.41304795, -1.49645805),
                new CityGeolocation(GB, "Bradford", 53.77103665, -1.77772522, 53.81028107, -1.72382355),
                new CityGeolocation(GB, "Nottingham", 52.94046604, -1.17708206, 52.97572838, -1.11751556),
                new CityGeolocation(GB, "Newcastle-upon-Tyne", 54.96771161, -1.62056923, 54.98239141, -1.60220146),
                new CityGeolocation(GB, "Brighton & Hove", 50.82149919, -0.15973091, 50.83093296, -0.12951851),
                new CityGeolocation(GB, "Derby", 52.90196523, -1.50203705, 52.92970582, -1.45156860),
                new CityGeolocation(GB, "Kingston-upon-Hull", 53.73866029, -0.36581039, 53.76362984, -0.32426834),
                new CityGeolocation(GB, "Plymouth", 50.36780273, -4.17514801, 50.39582527, -4.11403656),
                new CityGeolocation(GB, "Stoke-on-Trent", 53.01488652, -2.19263077, 53.02619341, -2.16945648),
                new CityGeolocation(GB, "Southampton", 50.89978505, -1.42547607, 50.92316402, -1.38710976),
                new CityGeolocation(GB, "Northampton", 52.23444945, -0.90534210, 52.24430437, -0.88907719),
                new CityGeolocation(GB, "Wolverhampton", 52.57640210, -2.14104652, 52.58949219, -2.11890221),
                new CityGeolocation(GB, "Luton", 51.87548418, -0.42297363, 51.88300806, -0.40486336),
                new CityGeolocation(GB, "Portsmouth", 50.78477610, -1.09691620, 50.82361382, -1.05262756),
                new CityGeolocation(GB, "Reading", 51.44020576, -1.00559235, 51.46138721, -0.93469620),
                new CityGeolocation(GB, "Norwich", 52.61920419, 1.27999306, 52.63530279, 1.31484032),
                new CityGeolocation(GB, "Milton Keynes", 52.01447224, -0.78723907, 52.05249048, -0.70518494),
                new CityGeolocation(GB, "Bournemouth", 50.71319987, -1.94526672, 50.75296588, -1.83780670),
                new CityGeolocation(GB, "Peterborough", 52.54838346, -0.27191162, 52.58897075, -0.21183014),
                new CityGeolocation(GB, "Bolton", 53.56799432, -2.44248390, 53.58542320, -2.42291451),
                new CityGeolocation(GB, "Swindon", 51.55380715, -1.80484772, 51.56949456, -1.76742554),
                new CityGeolocation(GB, "Southend-on-Sea", 51.53512460, 0.66484451, 51.55316673, 0.73780060),
                new CityGeolocation(GB, "Warrington", 53.38619516, -2.61388779, 53.40646197, -2.56977081),
                new CityGeolocation(GB, "Oxford", 51.74727921, -1.27355576, 51.75886235, -1.25020981),
                new CityGeolocation(GB, "Sunderland", 54.88835780, -1.40178680, 54.91135642, -1.36513710),
                new CityGeolocation(GB, "Slough", 51.50575081, -0.62690735, 51.52198884, -0.56991577),
                new CityGeolocation(GB, "Telford", 52.67440450, -2.45904922, 52.68127362, -2.43827820),
                new CityGeolocation(GB, "Cambridge", 52.19840120, 0.11715889, 52.20931605, 0.12977600),
                new CityGeolocation(GB, "Ipswich", 52.05201545, 1.14240646, 52.06077627, 1.17012978),
                new CityGeolocation(GB, "Blackpool", 53.80191809, -3.05548668, 53.82816717, -3.04089546),
                new CityGeolocation(GB, "Middlesbrough", 54.55782947, -1.24746323, 54.57643979, -1.22051239),
                new CityGeolocation(GB, "Huddersfield", 53.63873537, -1.79274559, 53.65287953, -1.77454948),
                new CityGeolocation(GB, "York", 53.95265117, -1.09880447, 53.96477118, -1.07185364),
                new CityGeolocation(GB, "Watford", 51.64758419, -0.40383339, 51.66063044, -0.38971424),
                new CityGeolocation(GB, "Colchester", 51.88449150, 0.88165283, 51.89286138, 0.91246605),
                new CityGeolocation(GB, "Exeter", 50.71412378, -3.54437828, 50.73449953, -3.51536751),
                new CityGeolocation(GB, "Blackburn", 53.73693420, -2.49561310, 53.75520682, -2.46694565),
                //Rabbits           GB, 
                new CityGeolocation(GB, "Gloucester", 51.84892860, -2.24945068, 51.87670292, -2.22318649),
                new CityGeolocation(GB, "Stockport", 53.40042388, -2.17537880, 53.41142484, -2.15143204),
                new CityGeolocation(GB, "Basildon", 51.56736054, 0.43996811, 51.58186992, 0.49472809),
                new CityGeolocation(GB, "Cheltenham", 51.88412064, -2.09083557, 51.90742550, -2.06113815),
                new CityGeolocation(GB, "Gateshead", 54.93019958, -1.61790848, 54.96569148, -1.58597946),
                new CityGeolocation(GB, "Worthing", 50.80604321, -0.40306091, 50.82350538, -0.36443710),
                new CityGeolocation(GB, "Rochdale", 53.60452555, -2.17237473, 53.62305931, -2.14336395),
                new CityGeolocation(GB, "Oldham", 53.53648181, -2.12508202, 53.54795752, -2.10190773),
                new CityGeolocation(GB, "Chelmsford", 51.73037738, 0.45936584, 51.73904169, 0.48065186),
                new CityGeolocation(GB, "Birkenhead", 53.36878666, -3.04510117, 53.39325893, -3.01368713),
                new CityGeolocation(GB, "Maidstone", 51.26599660, 0.50665855, 51.27840072, 0.53309441),
                new CityGeolocation(GB, "Salford", 53.48298946, -2.30661392, 53.49075208, -2.27863312),
                new CityGeolocation(GB, "Solihull", 52.40969719, -1.78510666, 52.41817832, -1.76575184),
                new CityGeolocation(GB, "St. Helens", 53.44793786, -2.74186134, 53.45805777, -2.72787094),
                new CityGeolocation(GB, "Lincoln", 53.22350749, -0.55403709, 53.23344961, -0.53356647),
                new CityGeolocation(GB, "West Bromwich", 52.51371370, -2.00603485, 52.52243593, -1.98698044),

                //hungary none

                //spain none

                //belgium COMPLETE
                new CityGeolocation(BE, "Brussels", 50.82025206, 4.29634094, 50.85992715, 4.40963745),
                new CityGeolocation(BE, "Antwerp", 51.16944162, 4.34852600, 51.24558426, 4.46456909),
                new CityGeolocation(BE, "Ghent", 51.03405383, 3.68797302, 51.07678259, 3.78101349),
                new CityGeolocation(BE, "Charleroi", 50.39462151, 4.42508698, 50.42306569, 4.47280884),
                new CityGeolocation(BE, "Liège", 50.62311281, 5.53144455, 50.65664365, 5.61813354),
                //Brussels2?        BE, 
                new CityGeolocation(BE, "Anderlecht", 50.83077033, 4.31874275, 50.84648910, 4.33848381),
                new CityGeolocation(BE, "Bruges", 51.19386830, 3.19753647, 51.22301271, 3.25315475),
                new CityGeolocation(BE, "Namur", 50.45039975, 4.84685898, 50.48143210, 4.88239288),
                new CityGeolocation(BE, "Leuven", 50.87027399, 4.68781471, 50.88505893, 4.71459389),

                //denmark none

                //norway COMPLETE
                new CityGeolocation(NO, "Oslo", 59.91372983, 10.64987183, 59.94331935, 10.80711365),
                new CityGeolocation(NO, "Bergen", 60.38362328, 5.31068802, 60.39948326, 5.34244537),
                new CityGeolocation(NO, "Trondheim", 63.38198634, 10.35118103, 63.44053289, 10.46756744),
                new CityGeolocation(NO, "Sannvika", 59.88600873, 10.51700592, 59.89569653, 10.53400040),
                new CityGeolocation(NO, "Sandvika", 59.88600873, 10.51700592, 59.89569653, 10.53400040),
                new CityGeolocation(NO, "Ålesund", 62.46628846, 6.12762451, 62.47640438, 6.19508743),

                //united arab emirates none

                //switzerland COMPLETE
                new CityGeolocation(CH, "Zurich", 47.36510635, 8.50702286, 47.39416594, 8.55182648),
                new CityGeolocation(CH, "Geneva", 46.16604117, 6.10771179, 46.20644812, 6.18736267),
                new CityGeolocation(CH, "Basel", 47.53713768, 7.55516052, 47.57119848, 7.63343811),
                new CityGeolocation(CH, "Lausanne", 46.51446065, 6.60209656, 46.53335856, 6.66286469),
                new CityGeolocation(CH, "Bern", 46.93315098, 7.43156433, 46.96853947, 7.48821259),
                new CityGeolocation(CH, "Winterthur", 47.48600498, 8.70357513, 47.51024415, 8.76296997),

                //israel none

                //south korea partial
                new CityGeolocation(KR, "Busan", 35.16791477, 129.06961441, 35.19569489, 129.09502029),
                new CityGeolocation(KR, "Incheon", 37.38543518, 126.62155151, 37.51027052, 126.73072815),
                new CityGeolocation(KR, "Daegu", 35.82560781, 128.53454590, 35.89238774, 128.63994598),
                new CityGeolocation(KR, "Daejeon", 36.31014547, 127.36930847, 36.37209212, 127.41239548),
                new CityGeolocation(KR, "Gwangju", 35.13759836, 126.79304123, 35.19260868, 126.92195892),
                new CityGeolocation(KR, "Suwon", 37.23852865, 127.01568604, 37.28552627, 127.05963135),
                new CityGeolocation(KR, "Ulsan", 35.52524112, 129.29500580, 35.56211562, 129.35234070),
                new CityGeolocation(KR, "Koyang", 37.60253626, 126.77776337, 37.67267961, 126.84436798),
                new CityGeolocation(KR, "Ionine", 37.23039673, 127.18151093, 37.23702534, 127.21730232),
                new CityGeolocation(KR, "Changwon", 35.19036409, 128.63342285, 35.24449754, 128.69899750),
                //kor things        KR, 
                new CityGeolocation(KR, "Iksan", 35.94007309, 126.94264412, 35.95529020, 126.96315765),
                new CityGeolocation(KR, "Kunpho", 37.35705928, 126.93191528, 37.38598077, 126.96899414),
                new CityGeolocation(KR, "Kodje", 34.88807830, 128.60647202, 34.89476645, 128.62299442),
                new CityGeolocation(KR, "Gyeongju", 35.83952494, 129.20093536, 35.85935262, 129.22848701),
                new CityGeolocation(KR, "Osan", 37.13582444, 127.06297874, 37.15716996, 127.08323479),
                new CityGeolocation(KR, "Mokpo", 34.78335552, 126.37933731, 34.81549453, 126.40302658),
                new CityGeolocation(KR, "Gangneung", 37.74255311, 128.88113022, 37.77071474, 128.91082764),
                new CityGeolocation(KR, "Icheon", 37.27558953, 127.43441105, 37.28644816, 127.45646954),
                new CityGeolocation(KR, "Chungju", 36.96710658, 127.91399002, 36.99281864, 127.94626236),
                new CityGeolocation(KR, "Yangju", 37.78407080, 127.04280853, 37.78757265, 127.05006123),
                new CityGeolocation(KR, "Anson", 37.00234704, 127.25635529, 37.01694579, 127.27515221),



                //china none

                //iceland COMPLETE
                new CityGeolocation(IS, "Reykjavik", 64.07520169, -21.97402954, 64.14775427, -21.81404114)

                //japan none
            ];
        }
    }
}
