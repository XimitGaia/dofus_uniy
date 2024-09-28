using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Basic;

[Token(Token = "0x2000B36")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class WhoAmIRequest : IMessage<WhoAmIRequest>, IMessage, IEquatable<WhoAmIRequest>, IDeepCloneable<WhoAmIRequest>, IBufferMessage
{
	[Token(Token = "0x40029E7")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<WhoAmIRequest> _parser;

	[Token(Token = "0x40029E8")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x40029E9")]
	public const int VerboseFieldNumber = 1;

	[Token(Token = "0x40029EA")]
	[FieldOffset(Offset = "0x18")]
	private bool verbose_;

	[Token(Token = "0x17001A0B")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageParser<WhoAmIRequest> Parser
	{
		[Token(Token = "0x6007626")]
		[Address(RVA = "0xC29450", Offset = "0xC28850", VA = "0x180C29450")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001A0C")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x6007627")]
		[Address(RVA = "0xC293A0", Offset = "0xC287A0", VA = "0x180C293A0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001A0D")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x6007628")]
		[Address(RVA = "0xC294A0", Offset = "0xC288A0", VA = "0x180C294A0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001A0E")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Verbose
	{
		[Token(Token = "0x600762C")]
		[Address(RVA = "0x87EAC0", Offset = "0x87DEC0", VA = "0x18087EAC0")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x600762D")]
		[Address(RVA = "0x87EB00", Offset = "0x87DF00", VA = "0x18087EB00")]
		set
		{
		}
	}

	[Token(Token = "0x6007629")]
	[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public WhoAmIRequest()
	{
	}

	[Token(Token = "0x600762A")]
	[Address(RVA = "0x951480", Offset = "0x950880", VA = "0x180951480")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public WhoAmIRequest(WhoAmIRequest other)
	{
	}

	[Token(Token = "0x600762B")]
	[Address(RVA = "0xC29090", Offset = "0xC28490", VA = "0x180C29090", Slot = "10")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public WhoAmIRequest Clone()
	{
		return null;
	}

	[Token(Token = "0x600762E")]
	[Address(RVA = "0xC29110", Offset = "0xC28510", VA = "0x180C29110", Slot = "0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x600762F")]
	[Address(RVA = "0x951170", Offset = "0x950570", VA = "0x180951170", Slot = "9")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public bool Equals(WhoAmIRequest other)
	{
		return default(bool);
	}

	[Token(Token = "0x6007630")]
	[Address(RVA = "0xC291A0", Offset = "0xC285A0", VA = "0x180C291A0", Slot = "2")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x6007631")]
	[Address(RVA = "0xC29240", Offset = "0xC28640", VA = "0x180C29240", Slot = "3")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x6007632")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x6007633")]
	[Address(RVA = "0x951670", Offset = "0x950A70", VA = "0x180951670", Slot = "12")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x6007634")]
	[Address(RVA = "0x9510B0", Offset = "0x9504B0", VA = "0x1809510B0", Slot = "7")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x6007635")]
	[Address(RVA = "0x9512D0", Offset = "0x9506D0", VA = "0x1809512D0", Slot = "4")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(WhoAmIRequest other)
	{
	}

	[Token(Token = "0x6007636")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x6007637")]
	[Address(RVA = "0x9515D0", Offset = "0x9509D0", VA = "0x1809515D0", Slot = "11")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
