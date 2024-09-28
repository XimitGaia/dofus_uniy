using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Contact;

[Token(Token = "0x20007B2")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class FriendSetStatusShareRequest : IMessage<FriendSetStatusShareRequest>, IMessage, IEquatable<FriendSetStatusShareRequest>, IDeepCloneable<FriendSetStatusShareRequest>, IBufferMessage
{
	[Token(Token = "0x4001AC7")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<FriendSetStatusShareRequest> _parser;

	[Token(Token = "0x4001AC8")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x4001AC9")]
	public const int ShareFieldNumber = 1;

	[Token(Token = "0x4001ACA")]
	[FieldOffset(Offset = "0x18")]
	private bool share_;

	[Token(Token = "0x17001175")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<FriendSetStatusShareRequest> Parser
	{
		[Token(Token = "0x60051C8")]
		[Address(RVA = "0xADE310", Offset = "0xADD710", VA = "0x180ADE310")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001176")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x60051C9")]
		[Address(RVA = "0xADE260", Offset = "0xADD660", VA = "0x180ADE260")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001177")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x60051CA")]
		[Address(RVA = "0xADE360", Offset = "0xADD760", VA = "0x180ADE360", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001178")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Share
	{
		[Token(Token = "0x60051CE")]
		[Address(RVA = "0x87EAC0", Offset = "0x87DEC0", VA = "0x18087EAC0")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x60051CF")]
		[Address(RVA = "0x87EB00", Offset = "0x87DF00", VA = "0x18087EB00")]
		set
		{
		}
	}

	[Token(Token = "0x60051CB")]
	[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public FriendSetStatusShareRequest()
	{
	}

	[Token(Token = "0x60051CC")]
	[Address(RVA = "0x951480", Offset = "0x950880", VA = "0x180951480")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public FriendSetStatusShareRequest(FriendSetStatusShareRequest other)
	{
	}

	[Token(Token = "0x60051CD")]
	[Address(RVA = "0xADDF50", Offset = "0xADD350", VA = "0x180ADDF50", Slot = "10")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public FriendSetStatusShareRequest Clone()
	{
		return null;
	}

	[Token(Token = "0x60051D0")]
	[Address(RVA = "0xADDFD0", Offset = "0xADD3D0", VA = "0x180ADDFD0", Slot = "0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x60051D1")]
	[Address(RVA = "0x951170", Offset = "0x950570", VA = "0x180951170", Slot = "9")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(FriendSetStatusShareRequest other)
	{
		return default(bool);
	}

	[Token(Token = "0x60051D2")]
	[Address(RVA = "0xADE060", Offset = "0xADD460", VA = "0x180ADE060", Slot = "2")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x60051D3")]
	[Address(RVA = "0xADE100", Offset = "0xADD500", VA = "0x180ADE100", Slot = "3")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x60051D4")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x60051D5")]
	[Address(RVA = "0x951670", Offset = "0x950A70", VA = "0x180951670", Slot = "12")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x60051D6")]
	[Address(RVA = "0x9510B0", Offset = "0x9504B0", VA = "0x1809510B0", Slot = "7")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x60051D7")]
	[Address(RVA = "0x9512D0", Offset = "0x9506D0", VA = "0x1809512D0", Slot = "4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(FriendSetStatusShareRequest other)
	{
	}

	[Token(Token = "0x60051D8")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x60051D9")]
	[Address(RVA = "0x9515D0", Offset = "0x9509D0", VA = "0x1809515D0", Slot = "11")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
