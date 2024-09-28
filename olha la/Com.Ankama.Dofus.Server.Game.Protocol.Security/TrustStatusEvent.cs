using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Security;

[Token(Token = "0x200015A")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class TrustStatusEvent : IMessage<TrustStatusEvent>, IMessage, IEquatable<TrustStatusEvent>, IDeepCloneable<TrustStatusEvent>, IBufferMessage
{
	[Token(Token = "0x400049B")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<TrustStatusEvent> _parser;

	[Token(Token = "0x400049C")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x400049D")]
	public const int CertifiedFieldNumber = 1;

	[Token(Token = "0x400049E")]
	[FieldOffset(Offset = "0x18")]
	private bool certified_;

	[Token(Token = "0x170002DE")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageParser<TrustStatusEvent> Parser
	{
		[Token(Token = "0x6000D63")]
		[Address(RVA = "0xC55B90", Offset = "0xC54F90", VA = "0x180C55B90")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170002DF")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x6000D64")]
		[Address(RVA = "0xC55AE0", Offset = "0xC54EE0", VA = "0x180C55AE0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170002E0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x6000D65")]
		[Address(RVA = "0xC55BE0", Offset = "0xC54FE0", VA = "0x180C55BE0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170002E1")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Certified
	{
		[Token(Token = "0x6000D69")]
		[Address(RVA = "0x87EAC0", Offset = "0x87DEC0", VA = "0x18087EAC0")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6000D6A")]
		[Address(RVA = "0x87EB00", Offset = "0x87DF00", VA = "0x18087EB00")]
		set
		{
		}
	}

	[Token(Token = "0x6000D66")]
	[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public TrustStatusEvent()
	{
	}

	[Token(Token = "0x6000D67")]
	[Address(RVA = "0x951480", Offset = "0x950880", VA = "0x180951480")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public TrustStatusEvent(TrustStatusEvent other)
	{
	}

	[Token(Token = "0x6000D68")]
	[Address(RVA = "0xC557D0", Offset = "0xC54BD0", VA = "0x180C557D0", Slot = "10")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public TrustStatusEvent Clone()
	{
		return null;
	}

	[Token(Token = "0x6000D6B")]
	[Address(RVA = "0xC55850", Offset = "0xC54C50", VA = "0x180C55850", Slot = "0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x6000D6C")]
	[Address(RVA = "0x951170", Offset = "0x950570", VA = "0x180951170", Slot = "9")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public bool Equals(TrustStatusEvent other)
	{
		return default(bool);
	}

	[Token(Token = "0x6000D6D")]
	[Address(RVA = "0xC558E0", Offset = "0xC54CE0", VA = "0x180C558E0", Slot = "2")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x6000D6E")]
	[Address(RVA = "0xC55980", Offset = "0xC54D80", VA = "0x180C55980", Slot = "3")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x6000D6F")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x6000D70")]
	[Address(RVA = "0x951670", Offset = "0x950A70", VA = "0x180951670", Slot = "12")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x6000D71")]
	[Address(RVA = "0x9510B0", Offset = "0x9504B0", VA = "0x1809510B0", Slot = "7")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x6000D72")]
	[Address(RVA = "0x9512D0", Offset = "0x9506D0", VA = "0x1809512D0", Slot = "4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(TrustStatusEvent other)
	{
	}

	[Token(Token = "0x6000D73")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x6000D74")]
	[Address(RVA = "0x9515D0", Offset = "0x9509D0", VA = "0x1809515D0", Slot = "11")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
