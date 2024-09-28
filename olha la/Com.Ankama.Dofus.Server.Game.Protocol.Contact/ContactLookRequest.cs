using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Contact;

[Token(Token = "0x20007A5")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class ContactLookRequest : IMessage<ContactLookRequest>, IMessage, IEquatable<ContactLookRequest>, IDeepCloneable<ContactLookRequest>, IBufferMessage
{
	[Token(Token = "0x20007A6")]
	public enum ComplementOneofCase
	{
		[Token(Token = "0x4001AA6")]
		None = 0,
		[Token(Token = "0x4001AA7")]
		Name = 3,
		[Token(Token = "0x4001AA8")]
		Id = 4
	}

	[Token(Token = "0x20007A7")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static class Types
	{
		[Token(Token = "0x20007A8")]
		public enum SocialContactCategory
		{
			[Token(Token = "0x4001AAA")]
			[OriginalName("FRIEND")]
			Friend,
			[Token(Token = "0x4001AAB")]
			[OriginalName("SPOUSE")]
			Spouse,
			[Token(Token = "0x4001AAC")]
			[OriginalName("PARTY")]
			Party,
			[Token(Token = "0x4001AAD")]
			[OriginalName("GUILD")]
			Guild,
			[Token(Token = "0x4001AAE")]
			[OriginalName("ALLIANCE")]
			Alliance,
			[Token(Token = "0x4001AAF")]
			[OriginalName("CRAFTER")]
			Crafter,
			[Token(Token = "0x4001AB0")]
			[OriginalName("INTERLOCUTOR")]
			Interlocutor,
			[Token(Token = "0x4001AB1")]
			[OriginalName("FIGHT")]
			Fight
		}
	}

	[Token(Token = "0x4001A9B")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<ContactLookRequest> _parser;

	[Token(Token = "0x4001A9C")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x4001A9D")]
	public const int RequestIdFieldNumber = 1;

	[Token(Token = "0x4001A9E")]
	[FieldOffset(Offset = "0x18")]
	private int requestId_;

	[Token(Token = "0x4001A9F")]
	public const int ContactTypeFieldNumber = 2;

	[Token(Token = "0x4001AA0")]
	[FieldOffset(Offset = "0x1C")]
	private Types.SocialContactCategory contactType_;

	[Token(Token = "0x4001AA1")]
	public const int NameFieldNumber = 3;

	[Token(Token = "0x4001AA2")]
	public const int IdFieldNumber = 4;

	[Token(Token = "0x4001AA3")]
	[FieldOffset(Offset = "0x20")]
	private object complement_;

	[Token(Token = "0x4001AA4")]
	[FieldOffset(Offset = "0x28")]
	private ComplementOneofCase complementCase_;

	[Token(Token = "0x1700115B")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageParser<ContactLookRequest> Parser
	{
		[Token(Token = "0x600514E")]
		[Address(RVA = "0xACAB70", Offset = "0xAC9F70", VA = "0x180ACAB70")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700115C")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x600514F")]
		[Address(RVA = "0xACA9D0", Offset = "0xAC9DD0", VA = "0x180ACA9D0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700115D")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x6005150")]
		[Address(RVA = "0xACAE60", Offset = "0xACA260", VA = "0x180ACAE60", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700115E")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int RequestId
	{
		[Token(Token = "0x6005154")]
		[Address(RVA = "0x894410", Offset = "0x893810", VA = "0x180894410")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6005155")]
		[Address(RVA = "0x894490", Offset = "0x893890", VA = "0x180894490")]
		set
		{
		}
	}

	[Token(Token = "0x1700115F")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public Types.SocialContactCategory ContactType
	{
		[Token(Token = "0x6005156")]
		[Address(RVA = "0x87EAE0", Offset = "0x87DEE0", VA = "0x18087EAE0")]
		get
		{
			return default(Types.SocialContactCategory);
		}
		[Token(Token = "0x6005157")]
		[Address(RVA = "0x87EB10", Offset = "0x87DF10", VA = "0x18087EB10")]
		set
		{
		}
	}

	[Token(Token = "0x17001160")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public string Name
	{
		[Token(Token = "0x6005158")]
		[Address(RVA = "0xACAB00", Offset = "0xAC9F00", VA = "0x180ACAB00")]
		get
		{
			return null;
		}
		[Token(Token = "0x6005159")]
		[Address(RVA = "0xACAFB0", Offset = "0xACA3B0", VA = "0x180ACAFB0")]
		set
		{
		}
	}

	[Token(Token = "0x17001161")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool HasName
	{
		[Token(Token = "0x600515A")]
		[Address(RVA = "0xA51720", Offset = "0xA50B20", VA = "0x180A51720")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17001162")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public long Id
	{
		[Token(Token = "0x600515C")]
		[Address(RVA = "0xACAA90", Offset = "0xAC9E90", VA = "0x180ACAA90")]
		get
		{
			return default(long);
		}
		[Token(Token = "0x600515D")]
		[Address(RVA = "0xACAF40", Offset = "0xACA340", VA = "0x180ACAF40")]
		set
		{
		}
	}

	[Token(Token = "0x17001163")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public bool HasId
	{
		[Token(Token = "0x600515E")]
		[Address(RVA = "0xACAA80", Offset = "0xAC9E80", VA = "0x180ACAA80")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17001164")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public ComplementOneofCase ComplementCase
	{
		[Token(Token = "0x6005160")]
		[Address(RVA = "0x87D130", Offset = "0x87C530", VA = "0x18087D130")]
		get
		{
			return default(ComplementOneofCase);
		}
	}

	[Token(Token = "0x6005151")]
	[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ContactLookRequest()
	{
	}

	[Token(Token = "0x6005152")]
	[Address(RVA = "0xACA930", Offset = "0xAC9D30", VA = "0x180ACA930")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ContactLookRequest(ContactLookRequest other)
	{
	}

	[Token(Token = "0x6005153")]
	[Address(RVA = "0xACA320", Offset = "0xAC9720", VA = "0x180ACA320", Slot = "10")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ContactLookRequest Clone()
	{
		return null;
	}

	[Token(Token = "0x600515B")]
	[Address(RVA = "0xA50F40", Offset = "0xA50340", VA = "0x180A50F40")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void ClearName()
	{
	}

	[Token(Token = "0x600515F")]
	[Address(RVA = "0xACA300", Offset = "0xAC9700", VA = "0x180ACA300")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void ClearId()
	{
	}

	[Token(Token = "0x6005161")]
	[Address(RVA = "0x9247A0", Offset = "0x923BA0", VA = "0x1809247A0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void ClearComplement()
	{
	}

	[Token(Token = "0x6005162")]
	[Address(RVA = "0xACA4B0", Offset = "0xAC98B0", VA = "0x180ACA4B0", Slot = "0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x6005163")]
	[Address(RVA = "0xACA3E0", Offset = "0xAC97E0", VA = "0x180ACA3E0", Slot = "9")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(ContactLookRequest other)
	{
		return default(bool);
	}

	[Token(Token = "0x6005164")]
	[Address(RVA = "0xACA5B0", Offset = "0xAC99B0", VA = "0x180ACA5B0", Slot = "2")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x6005165")]
	[Address(RVA = "0xACA7D0", Offset = "0xAC9BD0", VA = "0x180ACA7D0", Slot = "3")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x6005166")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x6005167")]
	[Address(RVA = "0xACACE0", Offset = "0xACA0E0", VA = "0x180ACACE0", Slot = "12")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x6005168")]
	[Address(RVA = "0xACA140", Offset = "0xAC9540", VA = "0x180ACA140", Slot = "7")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x6005169")]
	[Address(RVA = "0xACA730", Offset = "0xAC9B30", VA = "0x180ACA730", Slot = "4")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(ContactLookRequest other)
	{
	}

	[Token(Token = "0x600516A")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x600516B")]
	[Address(RVA = "0xACABC0", Offset = "0xAC9FC0", VA = "0x180ACABC0", Slot = "11")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
