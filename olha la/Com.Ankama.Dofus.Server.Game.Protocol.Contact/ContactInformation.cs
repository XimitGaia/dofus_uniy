using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Com.Ankama.Dofus.Server.Game.Protocol.Common;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Contact;

[Token(Token = "0x200080E")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class ContactInformation : IMessage<ContactInformation>, IMessage, IEquatable<ContactInformation>, IDeepCloneable<ContactInformation>, IBufferMessage
{
	[Token(Token = "0x4001BE2")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<ContactInformation> _parser;

	[Token(Token = "0x4001BE3")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x4001BE4")]
	public const int AccountIdFieldNumber = 1;

	[Token(Token = "0x4001BE5")]
	[FieldOffset(Offset = "0x18")]
	private long accountId_;

	[Token(Token = "0x4001BE6")]
	public const int AccountTagFieldNumber = 2;

	[Token(Token = "0x4001BE7")]
	[FieldOffset(Offset = "0x20")]
	private AccountTag accountTag_;

	[Token(Token = "0x1700123C")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageParser<ContactInformation> Parser
	{
		[Token(Token = "0x6005591")]
		[Address(RVA = "0xAE9670", Offset = "0xAE8A70", VA = "0x180AE9670")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700123D")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x6005592")]
		[Address(RVA = "0xAE95C0", Offset = "0xAE89C0", VA = "0x180AE95C0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700123E")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x6005593")]
		[Address(RVA = "0xAE97E0", Offset = "0xAE8BE0", VA = "0x180AE97E0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700123F")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public long AccountId
	{
		[Token(Token = "0x6005597")]
		[Address(RVA = "0x7D2760", Offset = "0x7D1B60", VA = "0x1807D2760")]
		get
		{
			return default(long);
		}
		[Token(Token = "0x6005598")]
		[Address(RVA = "0x918550", Offset = "0x917950", VA = "0x180918550")]
		set
		{
		}
	}

	[Token(Token = "0x17001240")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public AccountTag AccountTag
	{
		[Token(Token = "0x6005599")]
		[Address(RVA = "0x7D2770", Offset = "0x7D1B70", VA = "0x1807D2770")]
		get
		{
			return null;
		}
		[Token(Token = "0x600559A")]
		[Address(RVA = "0x7F0090", Offset = "0x7EF490", VA = "0x1807F0090")]
		set
		{
		}
	}

	[Token(Token = "0x6005594")]
	[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public ContactInformation()
	{
	}

	[Token(Token = "0x6005595")]
	[Address(RVA = "0xAE9540", Offset = "0xAE8940", VA = "0x180AE9540")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public ContactInformation(ContactInformation other)
	{
	}

	[Token(Token = "0x6005596")]
	[Address(RVA = "0xAE91A0", Offset = "0xAE85A0", VA = "0x180AE91A0", Slot = "10")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public ContactInformation Clone()
	{
		return null;
	}

	[Token(Token = "0x600559B")]
	[Address(RVA = "0xAE9240", Offset = "0xAE8640", VA = "0x180AE9240", Slot = "0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x600559C")]
	[Address(RVA = "0x953270", Offset = "0x952670", VA = "0x180953270", Slot = "9")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(ContactInformation other)
	{
		return default(bool);
	}

	[Token(Token = "0x600559D")]
	[Address(RVA = "0x9533A0", Offset = "0x9527A0", VA = "0x1809533A0", Slot = "2")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x600559E")]
	[Address(RVA = "0xAE93E0", Offset = "0xAE87E0", VA = "0x180AE93E0", Slot = "3")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x600559F")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x60055A0")]
	[Address(RVA = "0x953910", Offset = "0x952D10", VA = "0x180953910", Slot = "12")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x60055A1")]
	[Address(RVA = "0xAE90E0", Offset = "0xAE84E0", VA = "0x180AE90E0", Slot = "7")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x60055A2")]
	[Address(RVA = "0xAE9300", Offset = "0xAE8700", VA = "0x180AE9300", Slot = "4")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(ContactInformation other)
	{
	}

	[Token(Token = "0x60055A3")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x60055A4")]
	[Address(RVA = "0xAE96C0", Offset = "0xAE8AC0", VA = "0x180AE96C0", Slot = "11")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
