using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace MessageBoardDTO
{
    [DataContract]
    public class Post
    {
        [DataMember]
        public int PostID { get; set; }

        [DataMember]
        public Nullable<int> FK_tblUser_tblPosts { get; set; }

        [DataMember]
        public string PostName { get; set; }

        [DataMember]
        public byte[] PostImage { get; set; }

        [DataMember]
        public bool IsPublished { get; set; }

        [DataMember]
        public System.DateTime PostDate { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]

        [DataMember]
        public virtual ICollection<Comment> tblComments { get; set; }

        [DataMember]
        public virtual User tblUser { get; set; }
    }
}
