using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RegionGuesser.Model;

namespace RegionGuesser.Control
{
    class Controler
    {

        public Controler()
        {
            InitRegions();
            InitDepartment();
        }

        public void InitRegions()
        {
             new Region(1, "Auvergne-Rhône-Alpes");
             new Region(2, "Bourgogne-Franche-Comté");
             new Region(3, "Bretagne");
             new Region(4, "Centre-Val de Loire");
             new Region(5, "Corse");
             new Region(6, "Grand Est");
             new Region(8, "Hauts-de-France");
             new Region(9, "Île-de-France");
             new Region(10, "Normandie");
             new Region(11, "Nouvelle-Aquitaine");
             new Region(12, "Occitanie");
             new Region(13, "Pays de la Loire");
             new Region(14, "Provence-Alpes-Côte d'Azur");
            new Region(15, "Guadeloupe");
            new Region(16, "Martinique");
            new Region(17, "Guyane");
            new Region(18, "La Réunion");
            new Region(19, "Mayotte");
            
        }

        public void InitDepartment()
        {
            new Department("01", "Ain", "Bourg-En-Bresse", Region.Find("Auvergne-Rhône-Alpes"));
            new Department("02", "Aine", "Laon", Region.Find("Hauts-de-France"));
            new Department("03", "Allier", "Moulins", Region.Find("Auvergne-Rhône-Alpes"));
            new Department("04", "Alpes-de-Haute-Provence", "Digne-les-Bains", Region.Find("Provence-Alpes-Côte d'Azur"));
            new Department("05", "Hautes-Alpes", "Gap", Region.Find("Provence-Alpes-Côte d'Azur"));
            new Department("06", "Alpes-Maritimes", "Nice", Region.Find("Provence-Alpes-Côte d'Azur"));
            new Department("07", "Ardèche", "Privas", Region.Find("Auvergne-Rhône-Alpes"));
            new Department("08", "Ardennes", "Charleville-Mézières", Region.Find("Grand Est"));
            new Department("09", "Ariège", "Foix", Region.Find("Occitanie"));
            new Department("10", "Aube", "Troyes", Region.Find("Grand Est"));
            new Department("11", "Aude", "Carcassonne", Region.Find("Occitanie"));
            new Department("12", "Aveyron", "Rodez", Region.Find("Occitanie"));
            new Department("13", "Bouches-du-Rhône", "Marseille", Region.Find("Provence-Alpes-Côte d'Azur"));
            new Department("14", "Calvados", "Caen", Region.Find("Normandie"));
            new Department("15", "Cantal", "Aurillac", Region.Find("Auvergne-Rhône-Alpes"));
            new Department("16", "Charente", "Angoulême", Region.Find("Nouvelle-Aquitaine"));
            new Department("17", "Charente-Maritime", "La Rochelle", Region.Find("Nouvelle-Aquitaine"));
            new Department("18", "Cher", "Bourges", Region.Find("Centre-Val de Loire"));
            new Department("19", "Corrèze", "Tulle", Region.Find("Nouvelle-Aquitaine"));
            new Department("2A", "Corse-du-Sud", "Ajaccio", Region.Find("Corse"));
            new Department("2B", "Haute-Corse", "Bastia", Region.Find("Corse"));
            new Department("21", "Côte-d'Or", "Dijon", Region.Find("Bourgogne-Franche-Comté"));
            new Department("22", "Côtes d'Armor", "St-Brieuc", Region.Find("Bretagne"));
            new Department("23", "Creuse", "Guéret", Region.Find("Nouvelle-Aquitaine"));
            new Department("24", "Dordogne", "Périgueux", Region.Find("Nouvelle-Aquitaine"));
            new Department("25", "Doubs", "	Besançon", Region.Find("Bourgogne-Franche-Comté"));
            new Department("26", "Drôme", "Valence", Region.Find("Auvergne-Rhône-Alpes"));
            new Department("27", "Eure", "Évreux", Region.Find("Normandie"));
            new Department("28", "Eure-et-Loir", "Chartres", Region.Find("Centre-Val de Loire"));
            new Department("29", "Finistère", "Quimper", Region.Find("Bretagne"));
            new Department("30", "Gard", "Nîmes", Region.Find("Occitanie"));
            new Department("31", "Haute-Garonne", "Toulouse", Region.Find("Occitanie"));
            new Department("32", "Gers", "Auch", Region.Find("Occitanie"));
            new Department("33", "Gironde", "Bordeaux", Region.Find("Nouvelle-Aquitaine"));
            new Department("34", "Hérault", "Montpellier", Region.Find("Occitanie"));
            new Department("35", "Ille-et-Vilaine", "Rennes", Region.Find("Bretagne"));
            new Department("36", "Indre", "Châteauroux", Region.Find("Centre-Val de Loire"));
            new Department("37", "Indre-et-Loire", "Tours", Region.Find("Centre-Val de Loire"));
            new Department("38", "Isère", "Grenoble", Region.Find("Auvergne-Rhône-Alpes"));
            new Department("39", "Jura", "Lons-le-Saunier", Region.Find("Bourgogne-Franche-Comté"));
            new Department("40", "Landes", "Mont-de-Marsan", Region.Find("Nouvelle-Aquitaine"));
            new Department("41", "Loir-et-Cher", "Blois", Region.Find("Centre-Val de Loire"));
            new Department("42", "Loire", "Saint-Étienne", Region.Find("Auvergne-Rhône-Alpes"));
            new Department("43", "Haute-Loire", "Le Puy-en-Velay", Region.Find("Auvergne-Rhône-Alpes"));
            new Department("44", "Loire-Atlantique", "Nantes", Region.Find("Pays de la Loire"));
            new Department("45", "Loiret", "Orléans", Region.Find("Centre-Val de Loire"));
            new Department("46", "Lot", "Cahors", Region.Find("Occitanie"));
            new Department("47", "Lot-et-Garonne", "Agen", Region.Find("Nouvelle-Aquitaine"));
            new Department("48", "Lozère", "Mende", Region.Find("Occitanie"));
            new Department("49", "Maine-et-Loire", "Angers", Region.Find("Pays de la Loire"));
            new Department("50", "Manche", "Saint-Lô", Region.Find("Normandie"));
            new Department("51", "Marne", "Châlons-en-Champagne", Region.Find("Grand Est"));
            new Department("52", "Haute-Marne", "Chaumont", Region.Find("Grand Est"));
            new Department("53", "Mayenne", "Laval", Region.Find("Pays de la Loire"));
            new Department("54", "Meurthe-et-Moselle", "Nancy", Region.Find("Grand Est"));
            new Department("55", "Meuse", "Bar-le-Duc", Region.Find("Grand Est"));
            new Department("56", "Morbihan", "Vannes", Region.Find("Bretagne"));
            new Department("57", "Moselle", "Metz", Region.Find("Grand Est"));
            new Department("58", "Nièvre", "Nevers", Region.Find("Bourgogne-Franche-Comté"));
            new Department("59", "Nord", "Lille", Region.Find("Hauts-de-France"));
            new Department("60", "Oise", "Beauvais", Region.Find("Hauts-de-France"));
            new Department("61", "Orne", "Alençon", Region.Find("Normandie"));
            new Department("62", "Pas-de-Calais", "Arras", Region.Find("Hauts-de-France"));
            new Department("63", "Puy-de-Dôme", "Clermont-Ferrand", Region.Find("Auvergne-Rhône-Alpes"));
            new Department("64", "Pyrénées-Atlantiques", "Pau", Region.Find("Nouvelle-Aquitaine"));
            new Department("65", "Hautes-Pyrénées", "Tarbes", Region.Find("Occitanie"));
            new Department("66", "Pyrénées-Orientales", "Perpignan", Region.Find("Occitanie"));
            new Department("67", "Bas-Rhin", "Strasbourg", Region.Find("Grand Est"));
            new Department("68", "Haut-Rhin", "Colmar", Region.Find("Grand Est"));
            new Department("69", "Rhône", "Lyon", Region.Find("Auvergne-Rhône-Alpes"));
            new Department("70", "Haute-Saône", "Vesoul", Region.Find("Bourgogne-Franche-Comté"));
            new Department("71", "Saône-et-Loire", "Mâcon", Region.Find("Bourgogne-Franche-Comté"));
            new Department("72", "Sarthe", "Le Mans", Region.Find("Pays de la Loire"));
            new Department("73", "Savoie", "Chambéry", Region.Find("Auvergne-Rhône-Alpes"));
            new Department("74", "Haute-Savoie", "Annecy", Region.Find("Auvergne-Rhône-Alpes"));
            new Department("75", "Paris", "Paris", Region.Find("Île-de-France"));
            new Department("76", "Seine-Maritime", "Rouen", Region.Find("Normandie"));
            new Department("77", "Seine-et-Marne", "Melun", Region.Find("Île-de-France"));
            new Department("78", "Yvelines", "Versailles", Region.Find("Île-de-France"));
            new Department("79", "Deux-Sèvres", "Niort", Region.Find("Nouvelle-Aquitaine"));
            new Department("80", "Somme", "Amiens", Region.Find("Hauts-de-France"));
            new Department("81", "Tarn", "Albi", Region.Find("Occitanie"));
            new Department("82", "Tarn-et-Garonne", "Montauban", Region.Find("Occitanie"));
            new Department("83", "Var", "Toulon", Region.Find("Provence-Alpes-Côte d'Azur"));
            new Department("84", "Vaucluse", "Avignon", Region.Find("Provence-Alpes-Côte d'Azur"));
            new Department("85", "Vendée", "La Roche-sur-Yon", Region.Find("Pays de la Loire"));
            new Department("86", "Vienne", "Poitiers", Region.Find("Nouvelle-Aquitaine"));
            new Department("87", "Haute-Vienne", "Limoges", Region.Find("Nouvelle-Aquitaine"));
            new Department("88", "Vosges", "Épinal", Region.Find("Grand Est"));
            new Department("89", "Yonne", "Auxerre", Region.Find("Bourgogne-Franche-Comté"));
            new Department("90", "Territoire de Belfort", "Belfort", Region.Find("Bourgogne-Franche-Comté"));
            new Department("91", "Essonne", "Évry", Region.Find("Île-de-France"));
            new Department("92", "Hauts-de-Seine", "Nanterre", Region.Find("Île-de-France"));
            new Department("93", "Seine-St-Denis", "Bobigny", Region.Find("Île-de-France"));
            new Department("94", "Val-de-Marne", "Créteil", Region.Find("Île-de-France"));
            new Department("95", "Val-D'Oise", "Pontoise", Region.Find("Île-de-France"));
            new Department("971", "Guadeloupe", "Basse-Terre", Region.Find("Guadeloupe"), domTom:true);
            new Department("972", "Martinique", "Fort-de-France", Region.Find("Martinique"), domTom: true);
            new Department("973", "Guyane", "Cayenne", Region.Find("Guyane"), domTom: true);
            new Department("974", "La Réunion", "Saint-Denis", Region.Find("La Réunion"), domTom: true);
            new Department("976", "Mayotte", "Mamoudzou", Region.Find("Mayotte"), domTom: true);
        }

        public List<Region> GetRegions()
        {
            return Region.AllRegions;
        }

        public string GetImagePath(Region region)
        {
            return $"/media/{region.Name}.png";
        }
    }
}
