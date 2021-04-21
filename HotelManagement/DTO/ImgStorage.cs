using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace HotelManagement.DTO
{
    [Table("ImgStorage")]
    public partial class ImgStorage
    {
        [Key]
        [Column("id_imgsto")]
        public int IdImgsto { get; set; }
        [Column("imgsto_url")]
        public string ImgstoUrl { get; set; }
        [Column("imgsto_description")]
        [StringLength(200)]
        public string ImgstoDescription { get; set; }
        [Column("imgsto_idrootyp")]
        public int? ImgstoIdrootyp { get; set; }
        [Column("imgsto_iduser")]
        public int? ImgstoIduser { get; set; }

        [ForeignKey(nameof(ImgstoIdrootyp))]
        [InverseProperty(nameof(RoomType.ImgStorages))]
        public virtual RoomType ImgstoIdrootypNavigation { get; set; }
        [ForeignKey(nameof(ImgstoIduser))]
        [InverseProperty(nameof(User.ImgStorages))]
        public virtual User ImgstoIduserNavigation { get; set; }
    }
}
