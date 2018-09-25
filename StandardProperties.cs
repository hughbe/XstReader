﻿// Copyright (c) 2016, Dijji, and released under Ms-PL.  This can be found in the root of this distribution. 

using System.Collections.Generic;

namespace XstReader
{
    class StandardProperties
    {
        // Message properties as defined in [MS-OXPROPS]
        // The list is not exhaustive, consisting of message properties actually seen to date
        // "undocumented" means that the property has been seen, but is not in [MS-OXPROPS]
        public static Dictionary<EpropertyTag, string> TagToDescription = new Dictionary<EpropertyTag, string>
        {
            {(EpropertyTag)0x0002,        "AlternateRecipientAllowed" },
            {(EpropertyTag)0x000b,        "undocumented" },
            {(EpropertyTag)0x000f,        "DeferredDeliveryTime" },
            {(EpropertyTag)0x0015,        "ExpiryTime" },
            {(EpropertyTag)0x0017,        "Importance" },
            {(EpropertyTag)0x001a,        "MessageClass" },
            {(EpropertyTag)0x0023,        "OriginatorDeliveryReportRequested" },
            {(EpropertyTag)0x0025,        "ParentKey" },
            {(EpropertyTag)0x0026,        "Priority" },
            {(EpropertyTag)0x0029,        "ReadReceiptRequested" },
            {(EpropertyTag)0x002b,        "RecipientReassignmentProhibited" },
            {(EpropertyTag)0x002c,        "undocumented" },
            {(EpropertyTag)0x002e,        "OriginalSensitivity" },
            {(EpropertyTag)0x0031,        "ReportTag" },
            {(EpropertyTag)0x0032,        "ReportTime" },
            {(EpropertyTag)0x0036,        "Sensitivity" },
            {EpropertyTag.PidTagSubjectW, "Subject" },
            {EpropertyTag.PidTagClientSubmitTime, "ClientSubmitTime" },
            {(EpropertyTag)0x003b,        "SentRepresentingSearchKey" },
            {(EpropertyTag)0x003d,        "SubjectPrefix" },
            {(EpropertyTag)0x003f,        "ReceivedByEntryId" },
            {(EpropertyTag)0x0040,        "ReceivedByName" },
            {(EpropertyTag)0x0041,        "SentRepresentingEntryId" },
            {EpropertyTag.PidTagSentRepresentingNameW, "SentRepresentingName" },
            {(EpropertyTag)0x0043,        "ReceivedRepresentingEntryId" },
            {(EpropertyTag)0x0044,        "ReceivedRepresentingName" },
            {(EpropertyTag)0x0046,        "ReadReceiptEntryId" },
            {(EpropertyTag)0x0047,        "MessageSubmissionId" },
            {(EpropertyTag)0x0048,        "undocumented" },
            {(EpropertyTag)0x0049,        "OriginalSubject" },
            {(EpropertyTag)0x004c,        "OriginalAuthorEntryId" },
            {(EpropertyTag)0x004d,        "OriginalAuthorName" },
            {(EpropertyTag)0x004e,        "OriginalSubmitTime" },
            {(EpropertyTag)0x004f,        "ReplyRecipientEntries" },
            {(EpropertyTag)0x0050,        "ReplyRecipientNames" },
            {(EpropertyTag)0x0051,        "ReceivedBySearchKey" },
            {(EpropertyTag)0x0052,        "ReceivedRepresentingSearchKey" },
            {(EpropertyTag)0x0053,        "ReadReceiptSearchKey" },
            {(EpropertyTag)0x0056,        "undocumented" },
            {(EpropertyTag)0x0057,        "MessageToMe" },
            {(EpropertyTag)0x0058,        "MessageCcMe" },
            {(EpropertyTag)0x0059,        "MessageRecipientMe" },
            {(EpropertyTag)0x005a,        "OriginalSenderName" },
            {(EpropertyTag)0x005b,        "OriginalSenderEntryId" },
            {(EpropertyTag)0x005c,        "OriginalSenderSearchKey" },
            {(EpropertyTag)0x005d,        "OriginalSentRepresentingName" },
            {(EpropertyTag)0x005e,        "OriginalSentRepresentingEntryId" },
            {(EpropertyTag)0x005f,        "OriginalSentRepresentingSearchKey" },
            {(EpropertyTag)0x0060,        "StartDate" },
            {(EpropertyTag)0x0061,        "EndDate" },
            {(EpropertyTag)0x0062,        "OwnerAppointmentId" },
            {(EpropertyTag)0x0063,        "ResponseRequested" },
            {(EpropertyTag)0x0064,        "SentRepresentingAddressType" },
            {EpropertyTag.PidTagSentRepresentingEmailAddress, "SentRepresentingEmailAddress" },
            {(EpropertyTag)0x0066,        "OriginalSenderAddressType" },
            {(EpropertyTag)0x0067,        "OriginalSenderEmailAddress" },
            {(EpropertyTag)0x0068,        "OriginalSentRepresentingAddressType" },
            {(EpropertyTag)0x0069,        "OriginalSentRepresentingEmailAddress" },
            {(EpropertyTag)0x0070,        "ConversationTopic" },
            {(EpropertyTag)0x0071,        "ConversationIndex" },
            {(EpropertyTag)0x0072,        "OriginalDisplayBcc" },
            {(EpropertyTag)0x0073,        "OriginalDisplayCc" },
            {(EpropertyTag)0x0074,        "OriginalDisplayTo" },
            {(EpropertyTag)0x0075,        "ReceivedByAddressType" },
            {(EpropertyTag)0x0076,        "ReceivedByEmailAddress" },
            {(EpropertyTag)0x0077,        "ReceivedRepresentingAddressType" },
            {(EpropertyTag)0x0078,        "ReceivedRepresentingEmailAddress" },
            {(EpropertyTag)0x0079,        "undocumented" },
            {(EpropertyTag)0x007a,        "undocumented" },
            {(EpropertyTag)0x007d,        "TransportMessageHeaders" },
            {(EpropertyTag)0x007f,        "TnefCorrelationKey" },
            {(EpropertyTag)0x0080,        "ReportDisposition" },
            {(EpropertyTag)0x0081,        "ReportDispositionModv" },
            {(EpropertyTag)0x0083,        "undocumented" },
            {(EpropertyTag)0x0084,        "undocumented" },
            {(EpropertyTag)0x0086,        "undocumented" },
            {(EpropertyTag)0x0c04,        "NonDeliveryReportReasonCode" },
            {(EpropertyTag)0x0c05,        "NonDeliveryReportDiagCode" },
            {(EpropertyTag)0x0c06,        "NonReceiptNotificationRequested" },
            {(EpropertyTag)0x0c08,        "OriginatorNonDeliveryReportRequested" },
            {(EpropertyTag)0x0c09,        "undocumented" },
            {(EpropertyTag)0x0c15,        "RecipientType" },
            {(EpropertyTag)0x0c17,        "ReplyRequested" },
            {(EpropertyTag)0x0c19,        "SenderEntryId" },
            {EpropertyTag.PidTagSenderName, "SenderName" },
            {(EpropertyTag)0x0c1d,        "SenderSearchKey" },
            {(EpropertyTag)0x0c1e,        "SenderAddressType" },
            {(EpropertyTag)0x0c1f,        "SenderEmailAddress" },
            {(EpropertyTag)0x0c24,        "undocumented" },
            {(EpropertyTag)0x0c25,        "undocumented" },
            {(EpropertyTag)0x0e01,        "DeleteAfterSubmit" },
            {(EpropertyTag)0x0e02,        "DisplayBcc" },
            {(EpropertyTag)0x0e03,        "DisplayCc" },
            {EpropertyTag.PidTagDisplayToW, "DisplayTo" },
            {(EpropertyTag)0x0e05,        "undocumented" },
            {(EpropertyTag)0x0e06,        "MessageDeliveryTime" },
            {(EpropertyTag)0x0e07,        "MessageFlags" },
            {(EpropertyTag)0x0e08,        "MessageSize" },
            {(EpropertyTag)0x0e0a,        "SentMailEntryId" },
            {(EpropertyTag)0x0e0f,        "Responsibility" },
            {(EpropertyTag)0x0e14,        "undocumented" },
            {(EpropertyTag)0x0e17,        "MessageStatus" },
            {(EpropertyTag)0x0e1d,        "NormalizedSubject" },
            {(EpropertyTag)0x0e1f,        "RtfInSync" },
            {EpropertyTag.PidTagAttachmentSize, "AttachSize" },
            {(EpropertyTag)0x0e23,        "InternetArticleNumber" },
            {(EpropertyTag)0x0e27,        "undocumented" },
            {(EpropertyTag)0x0e28,        "PrimarySendAccount" },
            {(EpropertyTag)0x0e29,        "NextSendAcct" },
            {(EpropertyTag)0x0e2b,        "ToDoItemFlags" },
            {(EpropertyTag)0x0e2f,        "undocumented" },
            {(EpropertyTag)0x0e30,        "undocumented" },
            {(EpropertyTag)0x0e32,        "undocumented" },
            {(EpropertyTag)0x0e33,        "undocumented" },
            {(EpropertyTag)0x0e34,        "undocumented" },
            {(EpropertyTag)0x0e46,        "undocumented" },
            {(EpropertyTag)0x0e48,        "undocumented" },
            {(EpropertyTag)0x0e4b,        "undocumented" },
            {(EpropertyTag)0x0e4c,        "undocumented" },
            {(EpropertyTag)0x0e4d,        "undocumented" },
            {(EpropertyTag)0x0e4e,        "undocumented" },
            {(EpropertyTag)0x0e53,        "undocumented" },
            {(EpropertyTag)0x0e55,        "undocumented" },
            {(EpropertyTag)0x0e58,        "undocumented" },
            {(EpropertyTag)0x0e59,        "undocumented" },
            {(EpropertyTag)0x0e62,        "undocumented" },
            {(EpropertyTag)0x0e79,        "TrustSender" },
            {(EpropertyTag)0x0e92,        "undocumented" },
            {(EpropertyTag)0x0e93,        "undocumented" },
            {(EpropertyTag)0x0e9d,        "undocumented" },
            {(EpropertyTag)0x0ecd,        "undocumented" },
            {(EpropertyTag)0x0f01,        "undocumented" },
            {(EpropertyTag)0x0f02,        "undocumented" },
            {(EpropertyTag)0x0f03,        "undocumented" },
            {(EpropertyTag)0x0f0a,        "undocumented" },
            {(EpropertyTag)0x0ff7,        "AccessLevel" },
            {(EpropertyTag)0x0ff9,        "RecordKey" },
            {(EpropertyTag)0x0ffe,        "ObjectType" },
            {(EpropertyTag)0x0fff,        "EntryId" },
            {(EpropertyTag)0x1001,        "ReportText" },
            {(EpropertyTag)0x1015,        "BodyContentId" },
            {(EpropertyTag)0x1033,        "undocumented" },
            {(EpropertyTag)0x1034,        "undocumented" },
            {(EpropertyTag)0x1035,        "InternetMessageId" },
            {(EpropertyTag)0x1037,        "undocumented" },
            {(EpropertyTag)0x1038,        "undocumented" },
            {(EpropertyTag)0x1039,        "InternetReferences" },
            {(EpropertyTag)0x1040,        "undocumented" },
            {(EpropertyTag)0x1042,        "InReplyToId" },
            {(EpropertyTag)0x1044,        "ListSubscribe" },
            {(EpropertyTag)0x1045,        "ListUnsubscribe" },
            {(EpropertyTag)0x1046,        "InternetReturnPath" },
            {(EpropertyTag)0x1080,        "IconIndex" },
            {(EpropertyTag)0x1081,        "LastVerbExecuted" },
            {(EpropertyTag)0x1082,        "LastVerbExecutionTime" },
            {(EpropertyTag)0x1043,        "ListHelp" },
            {(EpropertyTag)0x1090,        "FlagStatus" },
            {(EpropertyTag)0x1091,        "FlagCompleteTime" },
            {(EpropertyTag)0x1092,        "undocumented" },
            {(EpropertyTag)0x1095,        "FollowupIcon" },
            {(EpropertyTag)0x1096,        "BlockStatus" },
            {(EpropertyTag)0x10f3,        "undocumented" },
            {(EpropertyTag)0x10f4,        "AttributeHidden" },
            {(EpropertyTag)0x10f5,        "undocumented" },
            {(EpropertyTag)0x10f6,        "AttributeReadOnly" },
            {(EpropertyTag)0x1204,        "undocumented" },
            {(EpropertyTag)0x1205,        "undocumented" },
            {(EpropertyTag)0x1206,        "undocumented" },
            {(EpropertyTag)0x120b,        "undocumented" },
            {(EpropertyTag)0x1212,        "undocumented" },
            {(EpropertyTag)0x1213,        "undocumented" },
            {EpropertyTag.PidTagDisplayName, "DisplayName" },
            {(EpropertyTag)0x3002,        "AddressType" },
            {(EpropertyTag)0x3003,        "EmailAddress" },
            {(EpropertyTag)0x3004,        "Comment" },
            {(EpropertyTag)0x3007,        "CreationTime" },
            {(EpropertyTag)0x3008,        "LastModificationTime" },
            {(EpropertyTag)0x300b,        "SearchKey" },
            {(EpropertyTag)0x300f,        "undocumented" },
            {(EpropertyTag)0x3010,        "TargetEntryId" },
            {(EpropertyTag)0x3014,        "undocumented" },
            {(EpropertyTag)0x3016,        "ConversationIndexTracking" },
            {(EpropertyTag)0x3019,        "PolicyTag" },
            {(EpropertyTag)0x301b,        "StartDateEtc" },
            {(EpropertyTag)0x301c,        "RetentionDate" },
            {(EpropertyTag)0x301d,        "RetentionFlags" },
            {(EpropertyTag)0x348a,        "undocumented" },
            {(EpropertyTag)0x3702,        "AttachEncoding" },
            {(EpropertyTag)0x3703,        "AttachExtension" },
            {EpropertyTag.PidTagAttachFilenameW, "AttachFilename" },
            {EpropertyTag.PidTagAttachMethod, "AttachMethod" },
            {EpropertyTag.PidTagAttachLongFilename, "AttachLongFilename" },
            {(EpropertyTag)0x3708,        "AttachPathname" },
            {(EpropertyTag)0x3709,        "AttachRendering" },
            {(EpropertyTag)0x370a,        "AttachTag" },
            {(EpropertyTag)0x370b,        "RenderingPosition" },
            {(EpropertyTag)0x370d,        "AttachLongPathname" },
            {EpropertyTag.PidTagAttachMimeTag, "AttachMimeTag" },
            {(EpropertyTag)0x3710,        "undocumented" },
            {(EpropertyTag)0x3711,        "AttachContentBase" },
            {EpropertyTag.PidTagAttachContentId, "AttachContentId" },
            {(EpropertyTag)0x3713,        "AttachContentLocation" },
            {EpropertyTag.PidTagAttachFlags, "AttachFlags" },
            {(EpropertyTag)0x371d,        "undocumented" },
            {(EpropertyTag)0x3900,        "DisplayType" },
            {(EpropertyTag)0x3905,        "DisplayTypeEx" },
            {(EpropertyTag)0x39fe,        "SmtpAddress" },
            {(EpropertyTag)0x39ff,        "AddressBookDisplayNamePrintable" },
            {(EpropertyTag)0x3a00,        "Account" },
            {(EpropertyTag)0x3a02,        "CallbackTelephoneNumber" },
            {(EpropertyTag)0x3a05,        "Generation" },
            {(EpropertyTag)0x3a06,        "GivenName" },
            {(EpropertyTag)0x3a08,        "BusinessTelephoneNumber" },
            {(EpropertyTag)0x3a09,        "HomeTelephoneNumber" },
            {(EpropertyTag)0x3a0a,        "Initials" },
            {(EpropertyTag)0x3a0b,        "Keyword" },
            {(EpropertyTag)0x3a0c,        "Language" },
            {(EpropertyTag)0x3a0d,        "Location" },
            {(EpropertyTag)0x3a11,        "Surname" },
            {(EpropertyTag)0x3a12,        "OriginalEntryId" },
            {(EpropertyTag)0x3a13,        "undocumented" },
            {(EpropertyTag)0x3a14,        "undocumented" },
            {(EpropertyTag)0x3a16,        "CompanyName" },
            {(EpropertyTag)0x3a17,        "Title" },
            {(EpropertyTag)0x3a18,        "DepartmentName" },
            {(EpropertyTag)0x3a1a,        "PrimaryTelephoneNumber" },
            {(EpropertyTag)0x3a1b,        "Business2TelephoneNumber" },
            {(EpropertyTag)0x3a1c,        "MobileTelephoneNumber" },
            {(EpropertyTag)0x3a1d,        "RadioTelephoneNumber" },
            {(EpropertyTag)0x3a1e,        "CarTelephoneNumber" },
            {(EpropertyTag)0x3a1f,        "OtherTelephoneNumber" },
            {(EpropertyTag)0x3a20,        "TransmittableDisplayName" },
            {(EpropertyTag)0x3a21,        "PagerTelephoneNumber" },
            {(EpropertyTag)0x3a23,        "PrimaryFaxNumber" },
            {(EpropertyTag)0x3a24,        "BusinessFaxNumber" },
            {(EpropertyTag)0x3a25,        "HomeFaxNumber" },
            {(EpropertyTag)0x3a26,        "Country" },
            {(EpropertyTag)0x3a27,        "Locality" },
            {(EpropertyTag)0x3a28,        "StateOrProvince" },
            {(EpropertyTag)0x3a2c,        "TelexNumber" },
            {(EpropertyTag)0x3a2d,        "IsdnNumber" },
            {(EpropertyTag)0x3a2e,        "AssistantTelephoneNumber" },
            {(EpropertyTag)0x3a2f,        "Home2TelephoneNumber" },
            {(EpropertyTag)0x3a40,        "SendRichInfo" },
            {(EpropertyTag)0x3a42,        "Birthday" },
            {(EpropertyTag)0x3a44,        "MiddleName" },
            {(EpropertyTag)0x3a45,        "DisplayNamePrefix" },
            {(EpropertyTag)0x3a4b,        "TelecommunicationsDeviceForDeafTelephoneNumber" },
            {(EpropertyTag)0x3a4f,        "Nickname" },
            {(EpropertyTag)0x3a50,        "PersonalHomePage" },
            {(EpropertyTag)0x3a51,        "BusinessHomePage" },
            {(EpropertyTag)0x3a57,        "CompanyMainTelephoneNumber" },
            {(EpropertyTag)0x3a59,        "HomeAddressCity" },
            {(EpropertyTag)0x3a5a,        "HomeAddressCountry" },
            {(EpropertyTag)0x3a5b,        "HomeAddressPostalCode" },
            {(EpropertyTag)0x3a5c,        "HomeAddresssStateOrProvince" },
            {(EpropertyTag)0x3a5d,        "HomeAddressStreet" },
            {(EpropertyTag)0x3a71,        "SendInternetEncoding" },
            {(EpropertyTag)0x3a76,        "undocumented" },
            {(EpropertyTag)0x3a77,        "undocumented" },
            {(EpropertyTag)0x3a78,        "undocumented" },
            {(EpropertyTag)0x3a79,        "undocumented" },
            {(EpropertyTag)0x3d01,        "undocumented" },
            {(EpropertyTag)0x3fd9,        "undocumented" },
            {(EpropertyTag)0x3fde,        "InternetCodepage" },
            {(EpropertyTag)0x3fdf,        "AutoResponseSuppress" },
            {(EpropertyTag)0x3fea,        "HasDeferredActionMessages" },
            {(EpropertyTag)0x3fef,        "DeferredSendTime" },
            {(EpropertyTag)0x3ff1,        "MessageLocaleId" },
            {(EpropertyTag)0x3ff2,        "undocumented" },
            {(EpropertyTag)0x3ff8,        "CreatorName" },
            {(EpropertyTag)0x3ff9,        "CreatorEntryId" },
            {(EpropertyTag)0x3ffa,        "LastModifierName" },
            {(EpropertyTag)0x3ffb,        "LastModifierEntryId" },
            {(EpropertyTag)0x3ffd,        "MessageCodepage" },
            {(EpropertyTag)0x4019,        "SenderFlags" },
            {(EpropertyTag)0x401a,        "SentRepresentingFlags" },
            {(EpropertyTag)0x401b,        "ReceivedByFlags" },
            {(EpropertyTag)0x401c,        "ReceivedRepresentingFlags" },
            {(EpropertyTag)0x401d,        "undocumented" },
            {(EpropertyTag)0x401e,        "undocumented" },
            {(EpropertyTag)0x4022,        "undocumented" },
            {(EpropertyTag)0x4023,        "undocumented" },
            {(EpropertyTag)0x4024,        "undocumented" },
            {(EpropertyTag)0x4025,        "undocumented" },
            {(EpropertyTag)0x4029,        "ReadReceiptAddressType" },
            {(EpropertyTag)0x402a,        "ReadReceiptEmailAddress" },
            {(EpropertyTag)0x402b,        "ReadReceiptName" },
            {(EpropertyTag)0x4030,        "SenderSimpleDisplayName" },
            {(EpropertyTag)0x4031,        "SentRepresentingSimpleDisplayName" },
            {(EpropertyTag)0x4034,        "undocumented" },
            {(EpropertyTag)0x4035,        "ReceivedRepresentingSimpleDisplayName" },
            {(EpropertyTag)0x4036,        "undocumented" },
            {(EpropertyTag)0x4038,        "CreatorSimpleDisplayName" },
            {(EpropertyTag)0x4039,        "LastModifierSimpleDisplayName" },
            {(EpropertyTag)0x4059,        "undocumented" },
            {(EpropertyTag)0x405a,        "undocumented" },
            {(EpropertyTag)0x405b,        "undocumented" },
            {(EpropertyTag)0x405d,        "undocumented" },
            {(EpropertyTag)0x405e,        "undocumented" },
            {(EpropertyTag)0x4060,        "undocumented" },
            {(EpropertyTag)0x4076,        "ContentFilterSpamConfidenceLevel" },
            {(EpropertyTag)0x4079,        "SenderIdStatus" },
            {(EpropertyTag)0x4080,        "undocumented" },
            {(EpropertyTag)0x4084,        "undocumented" },
            {(EpropertyTag)0x5902,        "InternetMailOverrideFormat" },
            {(EpropertyTag)0x5909,        "MessageEditorFormat" },
            {(EpropertyTag)0x5d01,        "SenderSmtpAddress" },
            {(EpropertyTag)0x5d02,        "SentRepresentingSmtpAddress" },
            {(EpropertyTag)0x5d05,        "ReadReceiptSmtpAddress" },
            {(EpropertyTag)0x5d06,        "undocumented" },
            {(EpropertyTag)0x5d07,        "ReceivedBySmtpAddress" },
            {(EpropertyTag)0x5d08,        "ReceivedRepresentingSmtpAddress" },
            {(EpropertyTag)0x5d09,        "undocumented" },
            {(EpropertyTag)0x5fde,        "undocumented" },
            {(EpropertyTag)0x5fdf,        "RecipientOrder" },
            {(EpropertyTag)0x5fe5,        "undocumented" },
            {(EpropertyTag)0x5feb,        "undocumented" },
            {(EpropertyTag)0x5fef,        "undocumented" },
            {(EpropertyTag)0x5ff2,        "undocumented" },
            {(EpropertyTag)0x5ff5,        "undocumented" },
            {(EpropertyTag)0x5ff6,        "RecipientDisplayName" },
            {(EpropertyTag)0x5ff7,        "RecipientEntryId" },
            {(EpropertyTag)0x5ffd,        "RecipientFlags" },
            {(EpropertyTag)0x5fff,        "RecipientTrackStatus" },
            {(EpropertyTag)0x6001,        "undocumented" },
            {(EpropertyTag)0x6200,        "undocumented" },
            {(EpropertyTag)0x6201,        "undocumented" },
            {(EpropertyTag)0x65c6,        "SecureSubmitFlags" },
            {(EpropertyTag)0x65e0,        "SourceKey" },
            {(EpropertyTag)0x65e1,        "ParentSourceKey" },
            {(EpropertyTag)0x65e2,        "ChangeKey" },
            {(EpropertyTag)0x65e3,        "PredecessorChangeList" },
            {(EpropertyTag)0x65f5,        "undocumented" },
            {(EpropertyTag)0x6604,        "undocumented" },
            {(EpropertyTag)0x6610,        "undocumented" },
            {(EpropertyTag)0x6619,        "UserEntryId" },
            {(EpropertyTag)0x661a,        "undocumented" },
            {(EpropertyTag)0x66a8,        "FolderFlags" },
            {(EpropertyTag)0x66aa,        "undocumented" },
            {(EpropertyTag)0x66b9,        "undocumented" },
            {(EpropertyTag)0x66ca,        "undocumented" },
            {(EpropertyTag)0x6743,        "undocumented" },
            {(EpropertyTag)0x67f2,        "undocumented" },
            {(EpropertyTag)0x67f3,        "undocumented" },
            {(EpropertyTag)0x67f4,        "undocumented" },
            {(EpropertyTag)0x6801,        "OfflineAddressBookSequence" },
            {(EpropertyTag)0x6802,        "RwRulesStream" },
            {(EpropertyTag)0x6804,        "FaxNumberOfPages" },
            {(EpropertyTag)0x6805,        "OfflineAddressBookTruncatedProperties" },
            {(EpropertyTag)0x6814,        "undocumented" },
            {(EpropertyTag)0x6820,        "ReportingMessageTransferAgent" },
            {(EpropertyTag)0x6884,        "undocumented" },
            {(EpropertyTag)0x688c,        "undocumented" },
            {(EpropertyTag)0x688d,        "undocumented" },
            {(EpropertyTag)0x6899,        "undocumented" },
            {(EpropertyTag)0x689b,        "undocumented" },
            {(EpropertyTag)0x689e,        "undocumented" },
            {(EpropertyTag)0x68a1,        "undocumented" },
            {(EpropertyTag)0x68a6,        "undocumented" },
            {(EpropertyTag)0x68a7,        "undocumented" },
            {(EpropertyTag)0x68a8,        "undocumented" },
            {(EpropertyTag)0x68aa,        "undocumented" },
            {(EpropertyTag)0x68b2,        "undocumented" },
            {(EpropertyTag)0x68b9,        "undocumented" },
            {(EpropertyTag)0x68c7,        "undocumented" },
            {(EpropertyTag)0x68da,        "undocumented" },
            {(EpropertyTag)0x7d01,        "undocumented" },
            {(EpropertyTag)0x7ffa,        "AttachmentLinkId" },
            {(EpropertyTag)0x7ffb,        "ExceptionStartTime" },
            {(EpropertyTag)0x7ffc,        "ExceptionEndTime" },
            {(EpropertyTag)0x7ffd,        "AttachmentFlags" },
            {EpropertyTag.PidTagAttachmentHidden, "AttachmentHidden" },
            {(EpropertyTag)0x7fff,        "AttachmentContactPhoto" },
         };

    }
}
