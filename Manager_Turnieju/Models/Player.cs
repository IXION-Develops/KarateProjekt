using System;
using System.Collections.Generic;
using System.Text;

namespace Manager_Turnieju.Models
{
    public enum Level
    {
        // zzz = .
        _początkujący_bez_stopnia___pas_biały,
        _10_kyū_pas_pomarańczowy,
        _9_kyū_pas_pomarańczowy_z_niebieską_belką,
        _8_kyū_pas_niebieski,
        _7_kyū_pas_niebieski_z_żółtą_belką,
        _6_kyū_pas_żółty,
        _5_kyū_pas_żółty_z_zieloną_belką,
        _4_kyū_pas_zielony,
        _3_kyū_pas_zielony_z_brązową_belką,
        _2_kyū_pas_brązowy,
        _1_kyū_pas_brązowy_z_czarną_belką,
        _Stopnie_dla_dzieci_poniżej_14_roku_życia,
        _10zzz1_kyū_pas_pomarańczowy_z_jedną_czerwoną_belką,
        _10zzz2_kyū_pas_pomarańczowy_z_dwiema_czerwonymi_belkami,
        _10zzz3_kyū_pas_pomarańczowy_z_trzema_czerwonymi_belkami,
        _9zzz1_kyū_pas_pomarańczowy_z_jedną_niebieską_i_czerwoną_belką,
        _9zzz2_kyū_pas_pomarańczowy_z_jedną_niebieską_i_dwiema_czerwonymi_belkami,
        _9zzz3_kyū_pas_pomarańczowy_z_jedną_niebieską_i_trzema_czerwonymi_belkami,
        _8zzz1_kyū_pas_niebieski_z_jedną_czerwoną_belką,
        _8zzz2_kyū_pas_niebieski_z_dwiema_czerwonymi_belkami,
        _8zzz3_kyū_pas_niebieski_z_trzema_czerwonymi_belkami,
        _7zzz1_kyū_pas_niebieski_z_jedną_żółtą_i_czerwoną_belką,
        _7zzz2_kyū_pas_niebieski_z_jedną_żółtą_i_dwiema_czerwonymi_belkami,
        _7zzz3_kyū_pas_niebieski_z_jedną_żółtą_i_trzema_czerwonymi_belkami,
        _6zzz1_kyū_pas_żółty_z_jedną_czerwoną_belką,
        _6zzz2_kyū_pas_żółty_z_dwiema_czerwonymi_belkami,
        _6zzz3_kyū_pas_żółty_z_trzema_czerwonymi_belkami,
        _5zzz1_kyū_pas_żółty_z_jedną_zieloną_i_czerwoną_belką,
        _5zzz2_kyū_pas_żółty_z_jedną_zielona_i_dwiema_czerwonymi_belkami,
        _5zzz3_kyū_pas_żółty_z_jedną_zielona_i_trzema_czerwonymi_belkami,
    }
    public class Player
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Gender { get; set; }
        public DateTime BirthDate { get; set; }
        public float Weight { get; set; }
        public Level Level { get; set; }
        public string Email { get; set; }
        public bool Kumite { get; set; }
        public bool Kata { get; set; }

        public int IdClub { get; set; }
        public Club Club {get;set;}

    }
}
