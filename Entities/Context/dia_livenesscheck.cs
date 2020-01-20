//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using DG.XrmContext;
using Microsoft.Xrm.Sdk;
using Microsoft.Xrm.Sdk.Client;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.Serialization;


namespace Entities {
    
    
    /// <summary>
    /// <para>Display Name: Liveness Check</para>
    /// </summary>
    [EntityLogicalName("dia_livenesscheck")]
    [DebuggerDisplay("{DebuggerDisplay,nq}")]
    [DataContract()]
    public partial class dia_livenesscheck : ExtendedEntity<dia_livenesscheckState, dia_livenesscheck_statuscode> {
        
        public const string EntityLogicalName = "dia_livenesscheck";
        
        public const int EntityTypeCode = 10409;
        
        public dia_livenesscheck() : 
                base(EntityLogicalName) {
        }
        
        public dia_livenesscheck(Guid Id) : 
                base(EntityLogicalName, Id) {
        }
        
        private string DebuggerDisplay {
            get {
                return GetDebuggerDisplay("dia_name");
            }
        }
        
        [AttributeLogicalName("dia_livenesscheckid")]
        public override Guid Id {
            get {
                return base.Id;
            }
            set {
                SetId("dia_livenesscheckid", value);
            }
        }
        
        /// <summary>
        /// <para>Unique identifier for entity instances</para>
        /// <para>Display Name: Liveness Check</para>
        /// </summary>
        [AttributeLogicalName("dia_livenesscheckid")]
        public Guid? dia_livenesscheckId {
            get {
                return GetAttributeValue<Guid?>("dia_livenesscheckid");
            }
            set {
                SetId("dia_livenesscheckid", value);
            }
        }
        
        /// <summary>
        /// <para>Unique identifier of the user who created the record.</para>
        /// <para>Display Name: Created By</para>
        /// </summary>
        [AttributeLogicalName("createdby")]
        public EntityReference CreatedBy {
            get {
                return GetAttributeValue<EntityReference>("createdby");
            }
        }
        
        /// <summary>
        /// <para>Date and time when the record was created.</para>
        /// <para>Display Name: Created On</para>
        /// </summary>
        [AttributeLogicalName("createdon")]
        public DateTime? CreatedOn {
            get {
                return GetAttributeValue<DateTime?>("createdon");
            }
        }
        
        /// <summary>
        /// <para>Unique identifier of the delegate user who created the record.</para>
        /// <para>Display Name: Created By (Delegate)</para>
        /// </summary>
        [AttributeLogicalName("createdonbehalfby")]
        public EntityReference CreatedOnBehalfBy {
            get {
                return GetAttributeValue<EntityReference>("createdonbehalfby");
            }
        }
        
        /// <summary>
        /// <para>Sequence number of the import that created this record.</para>
        /// <para>Display Name: Import Sequence Number</para>
        /// </summary>
        [AttributeLogicalName("importsequencenumber")]
        public int? ImportSequenceNumber {
            get {
                return GetAttributeValue<int?>("importsequencenumber");
            }
            set {
                SetAttributeValue("importsequencenumber", value);
            }
        }
        
        /// <summary>
        /// <para>Unique identifier of the user who modified the record.</para>
        /// <para>Display Name: Modified By</para>
        /// </summary>
        [AttributeLogicalName("modifiedby")]
        public EntityReference ModifiedBy {
            get {
                return GetAttributeValue<EntityReference>("modifiedby");
            }
        }
        
        /// <summary>
        /// <para>Date and time when the record was modified.</para>
        /// <para>Display Name: Modified On</para>
        /// </summary>
        [AttributeLogicalName("modifiedon")]
        public DateTime? ModifiedOn {
            get {
                return GetAttributeValue<DateTime?>("modifiedon");
            }
        }
        
        /// <summary>
        /// <para>Unique identifier of the delegate user who modified the record.</para>
        /// <para>Display Name: Modified By (Delegate)</para>
        /// </summary>
        [AttributeLogicalName("modifiedonbehalfby")]
        public EntityReference ModifiedOnBehalfBy {
            get {
                return GetAttributeValue<EntityReference>("modifiedonbehalfby");
            }
        }
        
        /// <summary>
        /// <para>Date and time that the record was migrated.</para>
        /// <para>Display Name: Record Created On</para>
        /// </summary>
        [AttributeLogicalName("overriddencreatedon")]
        public DateTime? OverriddenCreatedOn {
            get {
                return GetAttributeValue<DateTime?>("overriddencreatedon");
            }
            set {
                SetAttributeValue("overriddencreatedon", value);
            }
        }
        
        /// <summary>
        /// <para>Owner Id</para>
        /// <para>Display Name: Owner</para>
        /// </summary>
        [AttributeLogicalName("ownerid")]
        public EntityReference OwnerId {
            get {
                return GetAttributeValue<EntityReference>("ownerid");
            }
            set {
                SetAttributeValue("ownerid", value);
            }
        }
        
        /// <summary>
        /// <para>Unique identifier for the business unit that owns the record</para>
        /// <para>Display Name: Owning Business Unit</para>
        /// </summary>
        [AttributeLogicalName("owningbusinessunit")]
        public EntityReference OwningBusinessUnit {
            get {
                return GetAttributeValue<EntityReference>("owningbusinessunit");
            }
        }
        
        /// <summary>
        /// <para>Unique identifier for the team that owns the record.</para>
        /// <para>Display Name: Owning Team</para>
        /// </summary>
        [AttributeLogicalName("owningteam")]
        public EntityReference OwningTeam {
            get {
                return GetAttributeValue<EntityReference>("owningteam");
            }
        }
        
        /// <summary>
        /// <para>Unique identifier for the user that owns the record.</para>
        /// <para>Display Name: Owning User</para>
        /// </summary>
        [AttributeLogicalName("owninguser")]
        public EntityReference OwningUser {
            get {
                return GetAttributeValue<EntityReference>("owninguser");
            }
        }
        
        /// <summary>
        /// <para>For internal use only.</para>
        /// <para>Display Name: Time Zone Rule Version Number</para>
        /// </summary>
        [AttributeLogicalName("timezoneruleversionnumber")]
        public int? TimeZoneRuleVersionNumber {
            get {
                return GetAttributeValue<int?>("timezoneruleversionnumber");
            }
            set {
                SetAttributeValue("timezoneruleversionnumber", value);
            }
        }
        
        /// <summary>
        /// <para>Time zone code that was in use when the record was created.</para>
        /// <para>Display Name: UTC Conversion Time Zone Code</para>
        /// </summary>
        [AttributeLogicalName("utcconversiontimezonecode")]
        public int? UTCConversionTimeZoneCode {
            get {
                return GetAttributeValue<int?>("utcconversiontimezonecode");
            }
            set {
                SetAttributeValue("utcconversiontimezonecode", value);
            }
        }
        
        /// <summary>
        /// <para>Version Number</para>
        /// <para>Display Name: Version Number</para>
        /// </summary>
        [AttributeLogicalName("versionnumber")]
        public long? VersionNumber {
            get {
                return GetAttributeValue<long?>("versionnumber");
            }
        }
        
        /// <summary>
        /// <para>Display Name: Accepted on</para>
        /// </summary>
        [AttributeLogicalName("dia_acceptedon")]
        public DateTime? dia_AcceptedOn {
            get {
                return GetAttributeValue<DateTime?>("dia_acceptedon");
            }
            set {
                SetAttributeValue("dia_acceptedon", value);
            }
        }
        
        /// <summary>
        /// <para>Display Name: Blink result</para>
        /// </summary>
        [AttributeLogicalName("dia_blinkresult")]
        public bool? dia_BlinkResult {
            get {
                return GetAttributeValue<bool?>("dia_blinkresult");
            }
            set {
                SetAttributeValue("dia_blinkresult", value);
            }
        }
        
        /// <summary>
        /// <para>Display Name: CLR result</para>
        /// </summary>
        [AttributeLogicalName("dia_clrresult")]
        public bool? dia_ClrResult {
            get {
                return GetAttributeValue<bool?>("dia_clrresult");
            }
            set {
                SetAttributeValue("dia_clrresult", value);
            }
        }
        
        /// <summary>
        /// <para>Display Name: Confirmation email</para>
        /// </summary>
        [AttributeLogicalName("dia_confirmationemail")]
        public string dia_ConfirmationEmail {
            get {
                return GetAttributeValue<string>("dia_confirmationemail");
            }
            set {
                SetAttributeValue("dia_confirmationemail", value);
            }
        }
        
        /// <summary>
        /// <para>Display Name: Confirmation link</para>
        /// </summary>
        [AttributeLogicalName("dia_confirmationlink")]
        public string dia_ConfirmationLink {
            get {
                return GetAttributeValue<string>("dia_confirmationlink");
            }
            set {
                SetAttributeValue("dia_confirmationlink", value);
            }
        }
        
        /// <summary>
        /// <para>Display Name: Confirmation mobile</para>
        /// </summary>
        [AttributeLogicalName("dia_confirmationmobile")]
        public string dia_ConfirmationMobile {
            get {
                return GetAttributeValue<string>("dia_confirmationmobile");
            }
            set {
                SetAttributeValue("dia_confirmationmobile", value);
            }
        }
        
        /// <summary>
        /// <para>Display Name: Error code</para>
        /// </summary>
        [AttributeLogicalName("dia_errorcode")]
        public string dia_ErrorCode {
            get {
                return GetAttributeValue<string>("dia_errorcode");
            }
            set {
                SetAttributeValue("dia_errorcode", value);
            }
        }
        
        /// <summary>
        /// <para>Display Name: Error description</para>
        /// </summary>
        [AttributeLogicalName("dia_errordescription")]
        public string dia_ErrorDescription {
            get {
                return GetAttributeValue<string>("dia_errordescription");
            }
            set {
                SetAttributeValue("dia_errordescription", value);
            }
        }
        
        /// <summary>
        /// <para>Display Name: ID hash</para>
        /// </summary>
        [AttributeLogicalName("dia_idhash")]
        public string dia_IdHash {
            get {
                return GetAttributeValue<string>("dia_idhash");
            }
            set {
                SetAttributeValue("dia_idhash", value);
            }
        }
        
        /// <summary>
        /// <para>Display Name: Nod result</para>
        /// </summary>
        [AttributeLogicalName("dia_nodresult")]
        public bool? dia_NodResult {
            get {
                return GetAttributeValue<bool?>("dia_nodresult");
            }
            set {
                SetAttributeValue("dia_nodresult", value);
            }
        }
        
        /// <summary>
        /// <para>Display Name: Photo result</para>
        /// </summary>
        [AttributeLogicalName("dia_photoresult")]
        public bool? dia_PhotoResult {
            get {
                return GetAttributeValue<bool?>("dia_photoresult");
            }
            set {
                SetAttributeValue("dia_photoresult", value);
            }
        }
        
        /// <summary>
        /// <para>Display Name: Photo source</para>
        /// </summary>
        [AttributeLogicalName("dia_photosource")]
        public string dia_PhotoSource {
            get {
                return GetAttributeValue<string>("dia_photosource");
            }
            set {
                SetAttributeValue("dia_photosource", value);
            }
        }
        
        /// <summary>
        /// <para>Display Name: Requested on</para>
        /// </summary>
        [AttributeLogicalName("dia_requestedon")]
        public DateTime? dia_RequestedOn {
            get {
                return GetAttributeValue<DateTime?>("dia_requestedon");
            }
            set {
                SetAttributeValue("dia_requestedon", value);
            }
        }
        
        /// <summary>
        /// <para>Display Name: Shake result</para>
        /// </summary>
        [AttributeLogicalName("dia_shakeresult")]
        public bool? dia_ShakeResult {
            get {
                return GetAttributeValue<bool?>("dia_shakeresult");
            }
            set {
                SetAttributeValue("dia_shakeresult", value);
            }
        }
        
        /// <summary>
        /// <para>Display Name: CBG application</para>
        /// </summary>
        [AttributeLogicalName("dia_cbgapplication")]
        public EntityReference dia_cbgapplication {
            get {
                return GetAttributeValue<EntityReference>("dia_cbgapplication");
            }
            set {
                SetAttributeValue("dia_cbgapplication", value);
            }
        }
        
        /// <summary>
        /// <para>Display Name: Liveness check type</para>
        /// </summary>
        [AttributeLogicalName("dia_livenesschecktype")]
        public dia_livenesschecktype? dia_livenesschecktype {
            get {
                return GetOptionSetValue<dia_livenesschecktype>("dia_livenesschecktype");
            }
            set {
                SetOptionSetValue("dia_livenesschecktype", value);
            }
        }
        
        /// <summary>
        /// <para>Display Name: Liveness check URL</para>
        /// </summary>
        [AttributeLogicalName("dia_livenesscheckurl")]
        public string dia_livenesscheckurl {
            get {
                return GetAttributeValue<string>("dia_livenesscheckurl");
            }
            set {
                SetAttributeValue("dia_livenesscheckurl", value);
            }
        }
        
        /// <summary>
        /// <para>The name of the custom entity.</para>
        /// <para>Display Name: Name</para>
        /// </summary>
        [AttributeLogicalName("dia_name")]
        public string dia_name {
            get {
                return GetAttributeValue<string>("dia_name");
            }
            set {
                SetAttributeValue("dia_name", value);
            }
        }
        
        /// <summary>
        /// <para>Unique identifier for Person associated with Liveness check.</para>
        /// <para>Display Name: Person</para>
        /// </summary>
        [AttributeLogicalName("dia_personid")]
        public EntityReference dia_personid {
            get {
                return GetAttributeValue<EntityReference>("dia_personid");
            }
            set {
                SetAttributeValue("dia_personid", value);
            }
        }
        
        /// <summary>
        /// <para>Display Name: Person photo</para>
        /// </summary>
        [AttributeLogicalName("dia_personphotoid")]
        public EntityReference dia_personphotoid {
            get {
                return GetAttributeValue<EntityReference>("dia_personphotoid");
            }
            set {
                SetAttributeValue("dia_personphotoid", value);
            }
        }
        
        /// <summary>
        /// <para>Status of the Liveness Check</para>
        /// <para>Display Name: Status</para>
        /// </summary>
        [AttributeLogicalName("statecode")]
        public dia_livenesscheckState? statecode {
            get {
                return GetOptionSetValue<dia_livenesscheckState>("statecode");
            }
            set {
                SetOptionSetValue("statecode", value);
            }
        }
        
        /// <summary>
        /// <para>Reason for the status of the Liveness Check</para>
        /// <para>Display Name: Status Reason</para>
        /// </summary>
        [AttributeLogicalName("statuscode")]
        public dia_livenesscheck_statuscode? statuscode {
            get {
                return GetOptionSetValue<dia_livenesscheck_statuscode>("statuscode");
            }
            set {
                SetOptionSetValue("statuscode", value);
            }
        }
        
        [AttributeLogicalName("owningbusinessunit")]
        [RelationshipSchemaName("business_unit_dia_livenesscheck")]
        public BusinessUnit business_unit_dia_livenesscheck {
            get {
                return GetRelatedEntity<BusinessUnit>("business_unit_dia_livenesscheck", null);
            }
            set {
                SetRelatedEntity("business_unit_dia_livenesscheck", null, value);
            }
        }
        
        [AttributeLogicalName("dia_personid")]
        [RelationshipSchemaName("dia_contact_livenesscheck")]
        public Contact dia_contact_livenesscheck {
            get {
                return GetRelatedEntity<Contact>("dia_contact_livenesscheck", null);
            }
            set {
                SetRelatedEntity("dia_contact_livenesscheck", null, value);
            }
        }
        
        [AttributeLogicalName("dia_cbgapplication")]
        [RelationshipSchemaName("dia_livenesscheck_cbgapplication_dia_cbga")]
        public dia_cbgapplication dia_livenesscheck_cbgapplication_dia_cbga {
            get {
                return GetRelatedEntity<dia_cbgapplication>("dia_livenesscheck_cbgapplication_dia_cbga", null);
            }
            set {
                SetRelatedEntity("dia_livenesscheck_cbgapplication_dia_cbga", null, value);
            }
        }
        
        [AttributeLogicalName("createdby")]
        [RelationshipSchemaName("lk_dia_livenesscheck_createdby")]
        public SystemUser lk_dia_livenesscheck_createdby {
            get {
                return GetRelatedEntity<SystemUser>("lk_dia_livenesscheck_createdby", null);
            }
            set {
                SetRelatedEntity("lk_dia_livenesscheck_createdby", null, value);
            }
        }
        
        [AttributeLogicalName("createdonbehalfby")]
        [RelationshipSchemaName("lk_dia_livenesscheck_createdonbehalfby")]
        public SystemUser lk_dia_livenesscheck_createdonbehalfby {
            get {
                return GetRelatedEntity<SystemUser>("lk_dia_livenesscheck_createdonbehalfby", null);
            }
            set {
                SetRelatedEntity("lk_dia_livenesscheck_createdonbehalfby", null, value);
            }
        }
        
        [AttributeLogicalName("modifiedby")]
        [RelationshipSchemaName("lk_dia_livenesscheck_modifiedby")]
        public SystemUser lk_dia_livenesscheck_modifiedby {
            get {
                return GetRelatedEntity<SystemUser>("lk_dia_livenesscheck_modifiedby", null);
            }
            set {
                SetRelatedEntity("lk_dia_livenesscheck_modifiedby", null, value);
            }
        }
        
        [AttributeLogicalName("modifiedonbehalfby")]
        [RelationshipSchemaName("lk_dia_livenesscheck_modifiedonbehalfby")]
        public SystemUser lk_dia_livenesscheck_modifiedonbehalfby {
            get {
                return GetRelatedEntity<SystemUser>("lk_dia_livenesscheck_modifiedonbehalfby", null);
            }
            set {
                SetRelatedEntity("lk_dia_livenesscheck_modifiedonbehalfby", null, value);
            }
        }
        
        [AttributeLogicalName("owningteam")]
        [RelationshipSchemaName("team_dia_livenesscheck")]
        public Team team_dia_livenesscheck {
            get {
                return GetRelatedEntity<Team>("team_dia_livenesscheck", null);
            }
            set {
                SetRelatedEntity("team_dia_livenesscheck", null, value);
            }
        }
        
        [AttributeLogicalName("owninguser")]
        [RelationshipSchemaName("user_dia_livenesscheck")]
        public SystemUser user_dia_livenesscheck {
            get {
                return GetRelatedEntity<SystemUser>("user_dia_livenesscheck", null);
            }
            set {
                SetRelatedEntity("user_dia_livenesscheck", null, value);
            }
        }
        
        public static dia_livenesscheck Retrieve(IOrganizationService service, Guid id, params Expression<Func<dia_livenesscheck,object>>[] attrs) {
            return service.Retrieve(id, attrs);
        }
    }
    
    [DataContract()]
    public enum dia_livenesscheckState {
        
        [EnumMember()]
        Active = 0,
        
        [EnumMember()]
        Inactive = 1,
    }
    
    [DataContract()]
    public enum dia_livenesscheck_statuscode {
        
        [EnumMember()]
        Active = 1,
        
        [EnumMember()]
        Inactive = 2,
        
        [EnumMember()]
        New = 100000000,
        
        [EnumMember()]
        Requested = 100000001,
        
        [EnumMember()]
        Completed = 100000002,
        
        [EnumMember()]
        Expired = 100000003,
        
        [EnumMember()]
        Failed = 100000004,
        
        [EnumMember()]
        Cancelled = 100000005,
    }
}
