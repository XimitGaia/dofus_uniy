using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Symbiont;

[Token(Token = "0x20000EC")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class MimicryResponse : IMessage<MimicryResponse>, IMessage, IEquatable<MimicryResponse>, IDeepCloneable<MimicryResponse>, IBufferMessage
{
	[Token(Token = "0x20000ED")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static class Types
	{
		[Token(Token = "0x20000EE")]
		public enum Result
		{
			[Token(Token = "0x4000326")]
			[OriginalName("ERROR")]
			Error,
			[Token(Token = "0x4000327")]
			[OriginalName("PLAYER_BUSY")]
			PlayerBusy,
			[Token(Token = "0x4000328")]
			[OriginalName("HOST_NOT_MIMICKABLE")]
			HostNotMimickable,
			[Token(Token = "0x4000329")]
			[OriginalName("HOST_WRAPPED")]
			HostWrapped,
			[Token(Token = "0x400032A")]
			[OriginalName("DUPLICATE")]
			Duplicate,
			[Token(Token = "0x400032B")]
			[OriginalName("SUCCESS")]
			Success
		}
	}

	[Token(Token = "0x4000321")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<MimicryResponse> _parser;

	[Token(Token = "0x4000322")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x4000323")]
	public const int ResultFieldNumber = 1;

	[Token(Token = "0x4000324")]
	[FieldOffset(Offset = "0x18")]
	private Types.Result result_;

	[Token(Token = "0x170001F0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageParser<MimicryResponse> Parser
	{
		[Token(Token = "0x6000929")]
		[Address(RVA = "0xA58EB0", Offset = "0xA582B0", VA = "0x180A58EB0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170001F1")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x600092A")]
		[Address(RVA = "0xA58E00", Offset = "0xA58200", VA = "0x180A58E00")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170001F2")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x600092B")]
		[Address(RVA = "0xA58F00", Offset = "0xA58300", VA = "0x180A58F00", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170001F3")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public Types.Result Result
	{
		[Token(Token = "0x600092F")]
		[Address(RVA = "0x894410", Offset = "0x893810", VA = "0x180894410")]
		get
		{
			return default(Types.Result);
		}
		[Token(Token = "0x6000930")]
		[Address(RVA = "0x894490", Offset = "0x893890", VA = "0x180894490")]
		set
		{
		}
	}

	[Token(Token = "0x600092C")]
	[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MimicryResponse()
	{
	}

	[Token(Token = "0x600092D")]
	[Address(RVA = "0x929150", Offset = "0x928550", VA = "0x180929150")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MimicryResponse(MimicryResponse other)
	{
	}

	[Token(Token = "0x600092E")]
	[Address(RVA = "0xA58B90", Offset = "0xA57F90", VA = "0x180A58B90", Slot = "10")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MimicryResponse Clone()
	{
		return null;
	}

	[Token(Token = "0x6000931")]
	[Address(RVA = "0xA58C10", Offset = "0xA58010", VA = "0x180A58C10", Slot = "0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x6000932")]
	[Address(RVA = "0x928E70", Offset = "0x928270", VA = "0x180928E70", Slot = "9")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(MimicryResponse other)
	{
		return default(bool);
	}

	[Token(Token = "0x6000933")]
	[Address(RVA = "0x928F30", Offset = "0x928330", VA = "0x180928F30", Slot = "2")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x6000934")]
	[Address(RVA = "0xA58CA0", Offset = "0xA580A0", VA = "0x180A58CA0", Slot = "3")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x6000935")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x6000936")]
	[Address(RVA = "0x934790", Offset = "0x933B90", VA = "0x180934790", Slot = "12")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x6000937")]
	[Address(RVA = "0xA58B00", Offset = "0xA57F00", VA = "0x180A58B00", Slot = "7")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x6000938")]
	[Address(RVA = "0x928FA0", Offset = "0x9283A0", VA = "0x180928FA0", Slot = "4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(MimicryResponse other)
	{
	}

	[Token(Token = "0x6000939")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x600093A")]
	[Address(RVA = "0x9292A0", Offset = "0x9286A0", VA = "0x1809292A0", Slot = "11")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
