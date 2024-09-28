using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Preset;

[Token(Token = "0x2000245")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class CharacterPresetInfoResponse : IMessage<CharacterPresetInfoResponse>, IMessage, IEquatable<CharacterPresetInfoResponse>, IDeepCloneable<CharacterPresetInfoResponse>, IBufferMessage
{
	[Token(Token = "0x40007AC")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<CharacterPresetInfoResponse> _parser;

	[Token(Token = "0x40007AD")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x40007AE")]
	public const int IsSuccessFieldNumber = 1;

	[Token(Token = "0x40007AF")]
	[FieldOffset(Offset = "0x18")]
	private bool isSuccess_;

	[Token(Token = "0x40007B0")]
	public const int InfoFieldNumber = 2;

	[Token(Token = "0x40007B1")]
	[FieldOffset(Offset = "0x20")]
	private CharacterPresetInfo info_;

	[Token(Token = "0x170004EA")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<CharacterPresetInfoResponse> Parser
	{
		[Token(Token = "0x600170D")]
		[Address(RVA = "0xCF0FD0", Offset = "0xCF03D0", VA = "0x180CF0FD0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170004EB")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x600170E")]
		[Address(RVA = "0xCF0F20", Offset = "0xCF0320", VA = "0x180CF0F20")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170004EC")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x600170F")]
		[Address(RVA = "0xCF1150", Offset = "0xCF0550", VA = "0x180CF1150", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170004ED")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public bool IsSuccess
	{
		[Token(Token = "0x6001713")]
		[Address(RVA = "0x87EAC0", Offset = "0x87DEC0", VA = "0x18087EAC0")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6001714")]
		[Address(RVA = "0x87EB00", Offset = "0x87DF00", VA = "0x18087EB00")]
		set
		{
		}
	}

	[Token(Token = "0x170004EE")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public CharacterPresetInfo Info
	{
		[Token(Token = "0x6001715")]
		[Address(RVA = "0x7D2770", Offset = "0x7D1B70", VA = "0x1807D2770")]
		get
		{
			return null;
		}
		[Token(Token = "0x6001716")]
		[Address(RVA = "0x7F0090", Offset = "0x7EF490", VA = "0x1807F0090")]
		set
		{
		}
	}

	[Token(Token = "0x6001710")]
	[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public CharacterPresetInfoResponse()
	{
	}

	[Token(Token = "0x6001711")]
	[Address(RVA = "0xCDAD50", Offset = "0xCDA150", VA = "0x180CDAD50")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public CharacterPresetInfoResponse(CharacterPresetInfoResponse other)
	{
	}

	[Token(Token = "0x6001712")]
	[Address(RVA = "0xCF0AD0", Offset = "0xCEFED0", VA = "0x180CF0AD0", Slot = "10")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public CharacterPresetInfoResponse Clone()
	{
		return null;
	}

	[Token(Token = "0x6001717")]
	[Address(RVA = "0xCF0B70", Offset = "0xCEFF70", VA = "0x180CF0B70", Slot = "0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x6001718")]
	[Address(RVA = "0x9742A0", Offset = "0x9736A0", VA = "0x1809742A0", Slot = "9")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public bool Equals(CharacterPresetInfoResponse other)
	{
		return default(bool);
	}

	[Token(Token = "0x6001719")]
	[Address(RVA = "0xCF0C20", Offset = "0xCF0020", VA = "0x180CF0C20", Slot = "2")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x600171A")]
	[Address(RVA = "0xCF0DC0", Offset = "0xCF01C0", VA = "0x180CF0DC0", Slot = "3")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x600171B")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x600171C")]
	[Address(RVA = "0x9749C0", Offset = "0x973DC0", VA = "0x1809749C0", Slot = "12")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x600171D")]
	[Address(RVA = "0xCF0A30", Offset = "0xCEFE30", VA = "0x180CF0A30", Slot = "7")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x600171E")]
	[Address(RVA = "0xCF0CE0", Offset = "0xCF00E0", VA = "0x180CF0CE0", Slot = "4")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(CharacterPresetInfoResponse other)
	{
	}

	[Token(Token = "0x600171F")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x6001720")]
	[Address(RVA = "0xCF1020", Offset = "0xCF0420", VA = "0x180CF1020", Slot = "11")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
