﻿using Autofarmer.Models;
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
        public static CityGeolocation[] CityGeolocations { get; set; }


        static GeoDataBase()
        {
            //649
            CityGeolocations = [
                //usa partial
                 new CityGeolocation("New York", 40.70771001, -74.08630371, 40.81276986, -73.91601563),
                 new CityGeolocation("Los Angeles", 33.96101678, -118.32962036, 34.09474770, -118.17100525),
                 new CityGeolocation("Chicago", 41.85294071, -87.65819550, 41.88668781, -87.61802673),
                 new CityGeolocation("Houston", 29.71012130, -95.44441223, 29.80609284, -95.28030396),
                 new CityGeolocation("Philadelphia", 39.92816810, -75.20244598, 39.98580147, -75.13172150),
                 new CityGeolocation("Phoenix", 33.43889050, -112.14775085, 33.50704925, -111.99050903),
                 new CityGeolocation("San Antonio", 29.39713197, -98.53019714, 29.44886586, -98.46084595),
                 new CityGeolocation("San Diego", 32.70728895, -117.17004776, 32.72339290, -117.15571404),
                 new CityGeolocation("Dallas", 32.74685758, -96.82388306, 32.81382424, -96.75212860),
                 new CityGeolocation("San Jose", 37.25820564, -121.96678162, 37.42525247, -121.84249878),
                 new CityGeolocation("Austin", 30.23237435, -97.78072357, 30.30264994, -97.67223358),
                 new CityGeolocation("Jacksonville", 30.32428587, -81.70618057, 30.36235942, -81.62755966),
                 new CityGeolocation("San Francisco", 37.73447587, -122.43713379, 37.80666460, -122.39696503),
                 new CityGeolocation("Indianapolis", 39.73729032, -86.16920471, 39.81038217, -86.10157013),
                 new CityGeolocation("Fort Worth", 32.71046664, -97.35157013, 32.75804625, -97.31964111),
                 new CityGeolocation("Columbus", 39.94975341, -83.03844452, 40.00920937, -82.93853760),
                 new CityGeolocation("Detroit", 42.31844717, -83.15345764, 42.44423464, -83.01750183),
                 new CityGeolocation("El Paso", 31.75955334, -106.50060654, 31.78436280, -106.46541595),
                 new CityGeolocation("Seattle", 47.58104186, -122.33774185, 47.62502494, -122.31044769),
                 new CityGeolocation("Denver", 39.69767751, -105.02758026, 39.77767195, -104.91462708),


                //new zealand partial
                new CityGeolocation("Auckland", -36.89678263, 174.73257065, -36.84610922, 174.78715897),
                new CityGeolocation("Christchurch", -43.55153408, 172.61100769, -43.51519470, 172.66250610),
                new CityGeolocation("Wellington", -41.29954051, 174.76552963, -41.27954804, 174.78157997),
                new CityGeolocation("Hamilton", -37.80435891, 175.25356293, -37.77017197, 175.30094147),
                new CityGeolocation("Tauranga", -37.71343018, 176.15564346, -37.67682361, 176.16997719),
                new CityGeolocation("Lower Hutt", -41.23276753, 174.89135742, -41.20526432, 174.92036819),
                new CityGeolocation("Dunedin", -45.90864435, 170.48343658, -45.86634552, 170.51210403),
                new CityGeolocation("New Plymouth", -39.06764698, 174.06463623, -39.05258492, 174.08961296),
                new CityGeolocation("Palmerston", -40.37165889, 175.59310913, -40.33803961, 175.63499451),
                new CityGeolocation("Palmerston", -39.51013316, 176.88537598, -39.48059302, 176.91936493),


                //canada partial
                new CityGeolocation("Toronto", 43.64154137, -79.45449829, 43.76068042, -79.30824280),
                new CityGeolocation("Montreal", 45.45338760, -73.72512817, 45.56983236, -73.54728699),
                new CityGeolocation("Calgary", 50.99949673, -114.13558960, 51.08152780, -113.96186829),
                new CityGeolocation("Ottawa", 45.36444864, -75.73047638, 45.44495767, -75.64361572),
                new CityGeolocation("Edmonton", 53.48641131, -113.56979370, 53.57864615, -113.41323853),
                new CityGeolocation("Winnipeg", 49.82380909, -97.20153809, 49.93398605, -97.04635620),
                new CityGeolocation("Mississauga", 43.55750558, -79.74014282, 43.64402585, -79.58290100),
                new CityGeolocation("Vancouver", 49.21737285, -123.18145752, 49.27990050, -123.02421570),
                new CityGeolocation("Brampton", 43.65296912, -79.80091095, 43.71553473, -79.72846985),
                new CityGeolocation("Scarborough", 43.74803313, -79.28369522, 43.79104777, -79.22721863),


                //sweden COMPLETE
                new CityGeolocation("Stockholm", 59.31059273, 18.04281235, 59.34859561, 18.09997559),
                new CityGeolocation("Gothenburg", 57.69222204, 11.94969177, 57.72376939, 12.00839996),
                new CityGeolocation("Malmo", 55.57271615, 12.96489716, 55.61151715, 13.04248810),
                new CityGeolocation("Uppsala", 59.84817778, 17.62241364, 59.87188102, 17.66807556),
                new CityGeolocation("Helsingborg", 56.02291210, 12.69978762, 56.06916098, 12.72594452),
                new CityGeolocation("Helsingborg", 59.26219584, 15.20130157, 59.28763032, 15.23340225),
                new CityGeolocation("Västerås", 59.60161667, 16.52069092, 59.62566891, 16.56360626),
                new CityGeolocation("Karlstad", 59.37518983, 13.48520279, 59.38751758, 13.51764679),
                new CityGeolocation("Luleå", 65.57819791, 22.13350296, 65.60898221, 22.17864990),
                new CityGeolocation("Norrköping", 58.57568161, 16.15367889, 58.60198455, 16.22440338),
                new CityGeolocation("Södertälje", 59.17715967, 17.59906769, 59.20511847, 17.65914917),
                new CityGeolocation("Halmstad", 56.66584954, 12.82413483, 56.68301396, 12.89245605),
                new CityGeolocation("Eskilstuna", 59.37230397, 16.47193909, 59.38305912, 16.53991699),

                //germany COMPLETE
                new CityGeolocation("Berlin", 52.47943476, 13.31989288, 52.54128466, 13.45207214),
                new CityGeolocation("Hamburg", 53.54907943, 9.90039825, 53.59331988, 10.0686264),
                new CityGeolocation("Munich", 48.12118429, 11.52843475, 48.16379550, 11.64104462),
                new CityGeolocation("Cologne", 50.90714636, 6.91555023, 50.98091165, 7.03983307),
                new CityGeolocation("Frankfurt am Main", 50.09635771, 8.63697052, 50.13246362, 8.71765137),
                new CityGeolocation("Stuttgart", 48.77033305, 9.15830612, 48.78944980, 9.20259476),
                new CityGeolocation("Leipzig", 51.32696471, 12.36459732, 51.35773999, 12.41678238),
                new CityGeolocation("Dortmund", 51.48352095, 7.40615845, 51.53437714, 7.51602173),
                new CityGeolocation("Essen", 51.43539042, 6.97803497, 51.46726920, 7.03056335),
                new CityGeolocation("Bremen", 53.06638887, 8.77824783, 53.08577660, 8.86253357),
                new CityGeolocation("Dresden", 51.02844006, 13.70544434, 51.05736532, 13.77410889),
                new CityGeolocation("Hanover", 52.35798989, 9.70951080, 52.39403947, 9.74899292),
                new CityGeolocation("Nuremberg", 49.43218930, 11.04915619, 49.46968585, 11.10923767),
                new CityGeolocation("Duisburg", 51.40434606, 6.71333313, 51.44288072, 6.78268433),
                new CityGeolocation("Bochum", 51.46095940, 7.20085144, 51.49581284, 7.22986221),
                new CityGeolocation("Wuppertal", 51.25106425, 7.14540482, 51.27813227, 7.19793320),
                new CityGeolocation("Bielefeld", 52.01880372, 8.51852417, 52.03433024, 8.56229782),
                new CityGeolocation("Bonn", 50.72298153, 7.08480835, 50.75274868, 7.12909698),
                new CityGeolocation("Mannheim", 49.48095153, 8.45895767, 49.49399863, 8.47414970),
                new CityGeolocation("Karlsruhe", 48.99474862, 8.37226868, 49.01186572, 8.43063354),
                new CityGeolocation("Augsburg", 48.36103968, 10.88195801, 48.37917163, 10.91096878),
                new CityGeolocation("Wiesbaden", 50.07135384, 8.23099136, 50.09327424, 8.26000214),
                new CityGeolocation("Gelsenkirchen", 51.50318638, 7.07965851, 51.52070710, 7.11296082),
                new CityGeolocation("Aachen", 50.76708230, 6.07269287, 50.78124873, 6.09294891),
                new CityGeolocation("Braunschweig", 52.25554946, 10.50619125, 52.27319954, 10.54121017),
                new CityGeolocation("Chemnitz", 50.82502352, 12.90550232, 50.84009382, 12.94120789),
                new CityGeolocation("Halle", 51.47325736, 11.96256638, 51.48982764, 11.97853088),
                new CityGeolocation("Magdeburg", 52.12400374, 11.61684036, 52.15108133, 11.66044235),
                new CityGeolocation("Freiburg im Breisgau", 47.99187470, 7.83488274, 48.00094958, 7.85779953),
                new CityGeolocation("Krefeld", 51.32095736, 6.54819489, 51.34766256, 6.59162521),
                new CityGeolocation("Mainz", 49.98302008, 8.24609756, 50.01369614, 8.29124451),
                new CityGeolocation("Erfurt", 50.97069749, 11.01250648, 50.98545055, 11.04005814),
                new CityGeolocation("Oberhausen", 51.45764373, 6.82456970, 51.48031383, 6.88602448),
                new CityGeolocation("Potsdam", 52.39582023, 13.03956985, 52.41697431, 13.06652069),

                //australia none

                //ireland COMPLETE
                new CityGeolocation("Dublin", 53.30133845, -6.33636475, 53.39888863, -6.19766235),
                new CityGeolocation("Cork", 51.87882240, -8.48505020, 51.91134377, -8.44488144),
                new CityGeolocation("Limerick", 52.64858359, -8.63851547, 52.67388406, -8.61379623),
                new CityGeolocation("Galway", 53.26788234, -9.06955719, 53.28399791, -9.04252052),
                new CityGeolocation("Bandon", 51.73845703, -8.74610424, 51.75001586, -8.72666359),
                new CityGeolocation("Waterford", 52.24955944, -7.13424683, 52.26258932, -7.10643768),
                new CityGeolocation("Drogheda", 53.70524284, -6.36434555, 53.72530665, -6.33627892),
                new CityGeolocation("Dundalk", 53.99288613, -6.41550064, 54.00776876, -6.37850761),
                new CityGeolocation("Swords", 53.45023805, -6.23662949, 53.46531399, -6.20590210),
                new CityGeolocation("Navan", 53.64657121, -6.69874191, 53.66066189, -6.67050362),
                new CityGeolocation("Bray", 53.18927047, -6.12599373, 53.21209819, -6.10505104),
                new CityGeolocation("Ennis", 52.83777297, -8.99179459, 52.84560132, -8.97831917),
                new CityGeolocation("Carlow", 52.83580270, -6.93640709, 52.84299635, -6.91542149),
                new CityGeolocation("Kilkenny", 52.64280303, -7.26093292, 52.66248505, -7.23544121),
                new CityGeolocation("Naas", 53.21250939, -6.66337967, 53.23573571, -6.64981842),
                new CityGeolocation("Tralee", 52.26500573, -9.71706390, 52.28296710, -9.69260216),

                //netherlands COMPLETE
                new CityGeolocation("Amsterdam", 52.33617820, 4.83261108, 52.42461660, 4.94659424),
                new CityGeolocation("Rotterdam", 51.90594283, 4.42405701, 51.94214849, 4.50508118),
                new CityGeolocation("The Hague", 52.03939895, 4.26475525, 52.10523997, 4.38354492),
                new CityGeolocation("Utrecht", 52.05945698, 5.07877350, 52.11240909, 5.14537811),
                new CityGeolocation("Eindhoven", 51.41912152, 5.44372559, 51.45700196, 5.50415039),
                new CityGeolocation("Tilburg", 51.54163767, 5.04444122, 51.58090989, 5.11001587),
                new CityGeolocation("Almere", 52.34435885, 5.17765045, 52.40241887, 5.27515411),
                new CityGeolocation("Groningen", 53.19636688, 6.53068542, 53.23522199, 6.60655975),
                new CityGeolocation("Nijmegen", 51.81625594, 5.80249786, 51.84680772, 5.87940216),
                new CityGeolocation("Apeldoorn", 52.19413974, 5.93364716, 52.23032287, 6.00025177),
                new CityGeolocation("Arnhem", 51.97642166, 5.90497971, 51.99333702, 5.93793869),
                new CityGeolocation("Haarlem", 52.37287439, 4.61116791, 52.40597964, 4.65648651),
                new CityGeolocation("Enschede", 52.20245185, 6.86164856, 52.23295131, 6.91057205),
                new CityGeolocation("Amersfoort", 52.14297032, 5.36939621, 52.16824652, 5.40716171),
                new CityGeolocation("Hertogenbosch", 51.68522172, 5.27875900, 51.73213164, 5.34124374),
                new CityGeolocation("Zwolle", 52.49835419, 6.08333588, 52.52572590, 6.12367630),
                new CityGeolocation("Leiden", 52.14665733, 4.47692871, 52.16772008, 4.51589584),
                new CityGeolocation("Maastricht", 50.84280379, 5.67967415, 50.85786835, 5.71743965),
                new CityGeolocation("Dordrecht", 51.79439021, 4.65597153, 51.81784769, 4.67708588),
                new CityGeolocation("Alkmaar", 52.61915208, 4.73399162, 52.63634457, 4.76531982),
                new CityGeolocation("Delft", 51.99058871, 4.34320450, 52.01743037, 4.37135696),
                new CityGeolocation("Venlo", 51.35752560, 6.16581917, 51.37922754, 6.18787766),
                new CityGeolocation("Deventer", 52.25323762, 6.15019798, 52.26243172, 6.17362976),
                new CityGeolocation("Amstelveen", 52.29168256, 4.84445572, 52.30800632, 4.86883163),
                new CityGeolocation("Helmond", 51.47240196, 5.64165115, 51.48555201, 5.67272186),
                new CityGeolocation("Oss", 51.75679035, 5.51307678, 51.77431961, 5.54560661),
                new CityGeolocation("Leeuwarden", 53.19610978, 5.77528954, 53.20880846, 5.81288338),
                new CityGeolocation("Hilversum", 52.21402307, 5.15636444, 52.23494882, 5.19584656),
                new CityGeolocation("Heerlen", 50.87753165, 5.97441673, 50.89588741, 5.99269867),
                new CityGeolocation("Purmerend", 52.49281509, 4.94470596, 52.51648202, 4.97697830),
                new CityGeolocation("Hengelo", 52.25449863, 6.77332878, 52.27225418, 6.80680275),
                new CityGeolocation("Lelystad", 52.50112347, 5.46072006, 52.52107809, 5.49651146),
                new CityGeolocation("Schiedam", 51.90970238, 4.38672066, 51.92325532, 4.41573143),
                new CityGeolocation("Gouda", 52.00749872, 4.69923019, 52.01954320, 4.72721100),
                new CityGeolocation("Almelo", 52.34771457, 6.65659904, 52.36150183, 6.67247772),
                new CityGeolocation("Roermond", 51.18735937, 5.98282814, 51.19822500, 6.01020813),
                new CityGeolocation("Den Helder", 52.95355059, 4.74978447, 52.96306414, 4.76798058),
                new CityGeolocation("Osterhout", 51.63677159, 4.84497070, 51.65328240, 4.86986160),
                new CityGeolocation("Zeist", 52.08108844, 5.22090912, 52.09427321, 5.24339676),
                new CityGeolocation("Middelburg", 51.49228594, 3.60119820, 51.50692612, 3.62857819),

                //austria COMPLETE
                new CityGeolocation("Vienna", 48.17593092, 16.32431030, 48.24113824, 16.41014099),
                new CityGeolocation("Graz", 47.03316260, 15.39527893, 47.09910986, 15.45639038),
                new CityGeolocation("Linz", 48.28570594, 14.26694870, 48.31779345, 14.30643082),
                new CityGeolocation("Salzburg", 47.79009354, 13.01845551, 47.82260656, 13.06137085),

                //italy none

                //finland none 

                //france partial
                new CityGeolocation("Paris", 48.81884597, 2.29202271, 48.89767817, 2.39604950),
                new CityGeolocation("Marcel", 43.27820513, 5.35892487, 43.31431226, 5.39394379),
                new CityGeolocation("Lyon", 45.74536554, 4.80136871, 45.77315074, 4.86763000),
                new CityGeolocation("Toulouse", 43.58424567, 1.42187119, 43.62029489, 1.46650314),
                new CityGeolocation("Nice", 43.69356971, 7.25149155, 43.70908256, 7.27603912),
                new CityGeolocation("Nantes", 47.17244450, -1.59301758, 47.25336867, -1.51165009),
                new CityGeolocation("Montpellier", 43.58287786, 3.85499954, 43.62427141, 3.90632629),
                new CityGeolocation("Strasbourg", 48.55979535, 7.68802643, 48.60453868, 7.79170990),
                new CityGeolocation("Bordeaux", 44.78938889, -0.64647675, 44.87630874, -0.51258087),
                new CityGeolocation("Lille", 50.59892964, 2.99720764, 50.67840411, 3.14552307),
                new CityGeolocation("Toulon", 43.12216144, 5.91716766, 43.13299853, 5.94523430),
                new CityGeolocation("Reims", 49.24987918, 4.02391434, 49.26898068, 4.05455589),
                new CityGeolocation("Saint-Etienne", 45.42881685, 4.38191414, 45.44736635, 4.40217018),
                new CityGeolocation("Havre", 49.48630461, 0.10007858, 49.50949451, 0.15312195),
                new CityGeolocation("Dijon", 47.31526096, 5.03302574, 47.33126081, 5.05173683),
                new CityGeolocation("Grenoble", 45.16194785, 5.71374893, 45.19328841, 5.75443268),
                new CityGeolocation("Angers", 47.45943343, -0.56013107, 47.48362685, -0.53249359),
                new CityGeolocation("Villeurbanne", 45.75458889, 4.86179352, 45.78254907, 4.90264893),
                new CityGeolocation("St. Denis", 48.92999958, 2.35090256, 48.94448947, 2.37210274),
                new CityGeolocation("Nîmes", 43.82474367, 4.35195923, 43.84381306, 4.36955452),

                //great britain none

                //hungary none

                //spain none

                //belgium COMPLETE
                new CityGeolocation("Brussels", 50.82025206, 4.29634094, 50.85992715, 4.40963745),
                new CityGeolocation("Antwerp", 51.16944162, 4.34852600, 51.24558426, 4.46456909),
                new CityGeolocation("Ghent", 51.03405383, 3.68797302, 51.07678259, 3.78101349),
                new CityGeolocation("Charleroi", 50.39462151, 4.42508698, 50.42306569, 4.47280884),
                new CityGeolocation("Liège", 50.62311281, 5.53144455, 50.65664365, 5.61813354),
                //Brussels2?
                new CityGeolocation("Anderlecht", 50.83077033, 4.31874275, 50.84648910, 4.33848381),
                new CityGeolocation("Bruges", 51.19386830, 3.19753647, 51.22301271, 3.25315475),
                new CityGeolocation("Namur", 50.45039975, 4.84685898, 50.48143210, 4.88239288),
                new CityGeolocation("Leuven", 50.87027399, 4.68781471, 50.88505893, 4.71459389),

                //denmark none

                //norway COMPLETE
                new CityGeolocation("Oslo", 59.91372983, 10.64987183, 59.94331935, 10.80711365),
                new CityGeolocation("Bergen", 60.38362328, 5.31068802, 60.39948326, 5.34244537),
                new CityGeolocation("Trondheim", 63.38198634, 10.35118103, 63.44053289, 10.46756744),
                new CityGeolocation("Sannvika", 59.88600873, 10.51700592, 59.89569653, 10.53400040),
                new CityGeolocation("Sandvika", 59.88600873, 10.51700592, 59.89569653, 10.53400040),
                new CityGeolocation("Ålesund", 62.46628846, 6.12762451, 62.47640438, 6.19508743),

                //united arab emirates none

                //switzerland COMPLETE
                new CityGeolocation("Zurich", 47.36510635, 8.50702286, 47.39416594, 8.55182648),
                new CityGeolocation("Geneva", 46.16604117, 6.10771179, 46.20644812, 6.18736267),
                new CityGeolocation("Basel", 47.53713768, 7.55516052, 47.57119848, 7.63343811),
                new CityGeolocation("Lausanne", 46.51446065, 6.60209656, 46.53335856, 6.66286469),
                new CityGeolocation("Bern", 46.93315098, 7.43156433, 46.96853947, 7.48821259),
                new CityGeolocation("Winterthur", 47.48600498, 8.70357513, 47.51024415, 8.76296997),

                //israel none

                //south korea partial
                new CityGeolocation("Busan", 35.16791477, 129.06961441, 35.19569489, 129.09502029),
                new CityGeolocation("Incheon", 37.38543518, 126.62155151, 37.51027052, 126.73072815),
                new CityGeolocation("Daegu", 35.82560781, 128.53454590, 35.89238774, 128.63994598),
                new CityGeolocation("Daejeon", 36.31014547, 127.36930847, 36.37209212, 127.41239548),
                new CityGeolocation("Gwangju", 35.13759836, 126.79304123, 35.19260868, 126.92195892),
                new CityGeolocation("Suwon", 37.23852865, 127.01568604, 37.28552627, 127.05963135),
                new CityGeolocation("Ulsan", 35.52524112, 129.29500580, 35.56211562, 129.35234070),
                new CityGeolocation("Koyang", 37.60253626, 126.77776337, 37.67267961, 126.84436798),
                new CityGeolocation("Ionine", 37.23039673, 127.18151093, 37.23702534, 127.21730232),
                new CityGeolocation("Changwon", 35.19036409, 128.63342285, 35.24449754, 128.69899750),

                //china none

                //iceland COMPLETE
                new CityGeolocation("Reykjavik", 64.07520169, -21.97402954, 64.14775427, -21.81404114)

                //japan none
            ];
        }
    }
}
