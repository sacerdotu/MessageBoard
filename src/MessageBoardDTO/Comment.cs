using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace MessageBoardDTO
{
    [DataContract]
    public class Comment
    {
        [DataMember]
        public int CommentID { get; set; }

        [DataMember]
        public Nullable<int> FK_tblUser_tblComment { get; set; }

        [DataMember]
        public Nullable<int> FK_tblPost { get; set; }

        [DataMember]
        public Nullable<int> MainComment { get; set; }

        [DataMember]
        public string CommentContent { get; set; }

        [DataMember]
        public bool IsBlocked { get; set; }

        [DataMember]
        public System.DateTime PostDate { get; set; }

        [DataMember]
        public virtual User tblUser { get; set; }

        [DataMember]
        public virtual Post tblPost { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]

        [DataMember]
        public virtual ICollection<Comment> tblComment1 { get; set; }

        [DataMember]
        public virtual Comment tblComment2 { get; set; }
    }
}
