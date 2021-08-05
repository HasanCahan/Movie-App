using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MovieAppMvc.Models;

namespace MovieAppMvc.Veriler
{
    public class FilmVeri
    {
        private static List<Film> _films = null;
        static FilmVeri()
        {
            _films = new List<Film>()
            {
                new Film() { Id = 1, FilmAdı = "Parasıte", Açıklama = "Ki-Taek fakir ve işsiz bir adamdır. Karısı, oğlu ve kızıyla Seul’un arka mahallerinden birinde, böceklerin istila ettiği bir evde mahrumiyet içinde yaşamaktadır. Bir gün Ki-Taek’in oğlu Ki-Woo, son derece varlıklı bir ailenin evinde özel eğitmenlik işi bulur ve çok geçmeden kendi ailesi ile birlikte Park ailesinin hayatının bir parçası olmaya başlar.", Yönetmen = "Bong Joon Ho", Oyuncular = " Song Kang Ho, Jo Yeo Jeong, Park So Dam ile Choi Woo Sik", ImageUrl = "parasite.jpg", KategoriId = 9 },
                new Film() { Id = 2, FilmAdı = "Cinayet Süsü", Açıklama = "İstanbul Emniyet Müdürlüğü Cinayet Büro ekipleri günün birinde hiç alışık olmadıkları bir cinayet vakasıyla karşılaşırlar. Yılların deneyimine sahip Başkomiser Emin, arkadaşları Komiser Salih, Komiser Asuman ve Komiser Yardımcısı Alaattin’den oluşan ekip cinayet olayına el koyar. Ancak tuhaf cinayetler birbiri ardına gelmektedir. Ekibin elinde ne delil, ne de ipucu vardır. Cinayetler sürdükçe sinirler gerilmeye, amirler iyice rahatsız olmaya başlar.", Yönetmen = "Ali Atay", Oyuncular = "Uğur Yücel, Binnur Kaya, Cengiz Bozkurt, Feyyaz Yiğit", ImageUrl = "cinayetSusu.jpg", KategoriId = 6 },
                new Film() { Id = 3, FilmAdı = "Lucy", Açıklama = "Tayvan'ın başkenti Taipei'nin suça batmış yeraltı dünyası sokak çeteleri, mafya ve işbirlikçi polisler tarafından yönetilirken en aktif ticaret, uyuşturucu ağı üzerinden yürütülür. Eğlenmeyi seven, sıradan bir genç kadın olan Lucy, birkaç gece beraber takıldığı Richard yüzünden kendisini bir anda en azılı uyuşturucu şebekelerinin birinin içine düşmüş bulur. Vücudunun içine kurye olması için yerleştirilen yeni bir tür sentetik uyuşturucu, beklenmedik bir şekilde Lucy'nin vücuduna nüfuz edip kanına karışmaya başlayınca mucizevi bir durumla yüzleşir. Lucy'in damarlarında dolaşan kimyasallar, ona insanüstü yetenekler kazandırmıştır! Artık akıl okuma, telekinezi ve acıyı hissetmeme gibi güçlere sahip olan genç kadın beyinin tüm algı kapılarını sonuna kadar açacaktır... ", Yönetmen = "Luc Besson", Oyuncular = "Scarlett Johansson, Morgan Freeman, Min-sik Choi", ImageUrl = "lucy.jpg", KategoriId = 1 },
                new Film() { Id = 4, FilmAdı = "The Martian", Açıklama = "Mars’a gönderilen arstranotlardan Mark Watney şiddetli bir fırtına sonrası öldü sanılarak ekibi tarafından terk edilir. Ancak Watney hayattadır ve kendisini Mars’ta yapayalnız bulur. Elindeki sınırlı olanaklarla, zekasını ve dayanıklılığını kullanarak dünyaya yaşadığına dair bir sinyal gönderir. Bilim adamları ‘Marslı’nın eve dönmesi için uğraşırken, ekip arkadaşları da kurtarma operasyonunda yer alırlar.", Yönetmen = "Ridley Scott", Oyuncular = "Matt Damon, Jessica Chastain, Kate Mara, Kristen Wiig", ImageUrl = "marslı.jpg", KategoriId = 1 },
                new Film() { Id = 5, FilmAdı = "Aile Arasında", Açıklama = "21 yıllık ilişkileri noktalanan nevrotik Fikret ile vokalist Solmaz komik bir tesadüfle tanışır. Solmaz’ın kızı Zeynep, Adanalı sevgilisiyle evlenmeye karar verince her şeyden korkan Fikret, kendini bir anda hayatının rolünü oynarken bulur. Aile arasında olması planlanan nikah, damadın ailesinin ısrarıyla büyüdükçe büyür. Bu ekip düğün hazırlıkları boyunca silahlı, geleneksel, kebapçı zinciri sahibi Adanalı aileyle anlaşabilecek midir?", Yönetmen = "Ozan Açıktan", Oyuncular = "Engin Günaydın, Demet Evgar, Erdal Özyağcılar, Devrim Yakut", ImageUrl = "ailearasinda.jpg", KategoriId = 6 },
                new Film() { Id = 6, FilmAdı = "The Suicide Squad: İntihar Timi", Açıklama = "Belle Reve, ABD'deki en yüksek ölüm oranına sahip olan hapishanedir. Süper Kötülerin tutulduğu bu yerden kurtulmak için her şey göze alınır. Bloodsport, Peacemaker, Captain Boomerang, Ratcatcher 2, Savant, King Shark, Blackguard, Javelin ve herkesin favori psikopatı Harley Quinn yap ya da öl görevini yerine getirebilmek için bir mahkumlar timi oluşturur. Ekip silahlandırılarak düşmanlarla dolu Corto Maltese adasına bırakılacaktır. Militan düşmanlar ve gerillarla dolu ormanda adım adım ilerleyen ekibe sadece Albay Rick Flag liderlik eder. Her hareketlerini izleyen Amanda Waller'ın teknoloji harikası cihazları ile zorlu bir maceranın içinde olan ekip, herhangi yanlış bir hareketlerinde öldürelecektir.", Yönetmen = "James Gunn", Oyuncular = "Margot Robbie, Viola Davis, Joel Kinnaman", ImageUrl = "intihartimi.jpg", KategoriId = 10 },
                new Film() { Id = 7, FilmAdı = "15 07 Şafak Vakti", Açıklama = "Çengelköy’de pastane işleten Cevdet’in ve çocuklarının öyküsünü merkeze alıyor. Köprüde bir anda darbeci askerlerle karşı karşıya gelen Cevdet’in yolu, işine geç kalan güvenlik görevlisi Güray, küçük kızıyla köprüde sıkışıp kalan Mustafa ve askeri okul öğrencisi olan oğlunu bir türlü göremeyen Şerife ile kesişir. Cevdet köprüde, oğlu Yusuf ise Çengelköy’de darbeci askerlerle mücadele etmektedir.", Yönetmen = "Volkan Kocatürk", Oyuncular = "Erkan Petekkaya, Baran Bölükbaşı, Tugay Mercan, Serkan Ercan", ImageUrl = "safakvakti.jpg", KategoriId = 3 },
                new Film() { Id = 8, FilmAdı = "Mainstream", Açıklama = "Hollywood’da bir komedi kulübünde arkadaşı ve zaman zaman sevgilisi olan Jake ile birlikte çalışan Frankie, günümüz toplumunun neye değer verdiğini sorgulamaya başlar. Gizemli Link ile karşılaşması, onun ticaret karşıtı söylemlerini videoya çekmesi için ilham olur. Jake’in önderliğinde bu aykırı üçlü hızla internet yıldızlığına terfi eder. Fakat menajerleri Mark daha fazla para kazanmalarını talep etmeye başlayınca işler farklılaşır.", Yönetmen = "Gia Coppola", Oyuncular = "Andrew Garfield, Maya Hawke, Nat Wolff, Kalena Yiaueki", ImageUrl = "mainstream.jpg", KategoriId = 6 },
                new Film() { Id = 9, FilmAdı = "Azap", Açıklama = "Yaşlı bir kadın olan Edna, ortadan kaybolduğunda yetkililer kızı Kay’e ulaşır. Kay annesinin kaybolduğunu öğrenir öğrenmez kızı Sam ile birlikte annesinin yaşadığı eve gider. Kay ve Sam, Edna ile ilgili bir haber almayı umarak evde beklemeye başlar. Edna birkaç gün sonra ortaya çıkar. Nerede olduğunu açıklayamayan Edna, göğsündeki büyük çürük dışında zarar görmemiş gözükür. Günler geçtikçe Edna’nın tuhaf davranışlar sergilemesi Kay ve Sam’i tedirgin etmeye başlar.", Yönetmen = "Natalie Erika James", Oyuncular = "Robyn Nevin, Emily Mortimer, Bella Heathcote, Steve Rodgers", ImageUrl = "azap.jpg", KategoriId = 4 },
                new Film() { Id = 10,FilmAdı = "Peter Rabit: Kaçak Tavşan", Açıklama = "Bea, Thomas ve Tavşanlar eğreti bir aile kurarlar ama Peter tüm çabalarına rağmen afacanlık namından kurtulamamaktadır. Macera peşinde bahçeden dışarı çıkan Peter, kendini afacanlığının takdir edildiği bir dünyada bulur. Ancak, ailesi onu aramak için her şeylerini riske atınca, Peter’ın ne tür bir tavşan olmak istediğini çözme vakti gelir.", Yönetmen = "Will Gluck", Oyuncular = "Rose Byrne, Domhnall Gleeson, David Oyelowo, Harun Can, Seda Özelsoy, Fatih Özkul", ImageUrl = "peterrabbit.jpg", KategoriId = 7 }
            };
                
        }


        public static List<Film> Films
        {
            get
            {
                return _films;
            }
        }

        public static void FilmEkle(Film yenifilm)
        {
            _films.Add(yenifilm);
        }

        public static Film GetById(int id)
        {
            return _films.FirstOrDefault(i => i.Id == id);
        }
    }
}
