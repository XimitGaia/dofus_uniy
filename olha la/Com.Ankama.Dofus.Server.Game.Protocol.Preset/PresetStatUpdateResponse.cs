using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Preset;

[Token(Token = "0x2000222")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class PresetStatUpdateResponse : IMessage<PresetStatUpdateResponse>, IMessage, IEquatable<PresetStatUpdateResponse>, IDeepCloneable<PresetStatUpdateResponse>, IBufferMessage
{
	[Token(Token = "0x400073F")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<PresetStatUpdateResponse> _parser;

	[Token(Token = "0x4000740")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x4000741")]
	public const int IsSuccessFieldNumber = 1;

	[Token(Token = "0x4000742")]
	[FieldOffset(Offset = "0x18")]
	private bool isSuccess_;

	[Token(Token = "0x4000743")]
	public const int CharacteristicsInfoFieldNumber = 2;

	[Token(Token = "0x4000744")]
	[FieldOffset(Offset = "0x20")]
	private CharacteristicsInfo characteristicsInfo_;

	[Token(Token = "0x170004A1")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<PresetStatUpdateResponse> Parser
	{
		[Token(Token = "0x60015A9")]
		[Address(RVA = "0xCE9010", Offset = "0xCE8410", VA = "0x180CE9010")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170004A2")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x60015AA")]
		[Address(RVA = "0xCE8F60", Offset = "0xCE8360", VA = "0x180CE8F60")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170004A3")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x60015AB")]
		[Address(RVA = "0xCE9190", Offset = "0xCE8590", VA = "0x180CE9190", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170004A4")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public bool IsSuccess
	{
		[Token(Token = "0x60015AF")]
		[Address(RVA = "0x87EAC0", Offset = "0x87DEC0", VA = "0x18087EAC0")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x60015B0")]
		[Address(RVA = "0x87EB00", Offset = "0x87DF00", VA = "0x18087EB00")]
		set
		{
		}
	}

	[Token(Token = "0x170004A5")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public CharacteristicsInfo CharacteristicsInfo
	{
		[Token(Token = "0x60015B1")]
		[Address(RVA = "0x7D2770", Offset = "0x7D1B70", VA = "0x1807D2770")]
		get
		{
			return null;
		}
		[Token(Token = "0x60015B2")]
		[Address(RVA = "0x7F0090", Offset = "0x7EF490", VA = "0x1807F0090")]
		set
		{
		}
	}

	[Token(Token = "0x60015AC")]
	[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public PresetStatUpdateResponse()
	{
	}

	[Token(Token = "0x60015AD")]
	[Address(RVA = "0xCE8EF0", Offset = "0xCE82F0", VA = "0x180CE8EF0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PresetStatUpdateResponse(PresetStatUpdateResponse other)
	{
	}

	[Token(Token = "0x60015AE")]
	[Address(RVA = "0xCE8AA0", Offset = "0xCE7EA0", VA = "0x180CE8AA0", Slot = "10")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public PresetStatUpdateResponse Clone()
	{
		return null;
	}

	[Token(Token = "0x60015B3")]
	[Address(RVA = "0xCE8B40", Offset = "0xCE7F40", VA = "0x180CE8B40", Slot = "0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x60015B4")]
	[Address(RVA = "0x9742A0", Offset = "0x9736A0", VA = "0x1809742A0", Slot = "9")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(PresetStatUpdateResponse other)
	{
		return default(bool);
	}

	[Token(Token = "0x60015B5")]
	[Address(RVA = "0xCE8BF0", Offset = "0xCE7FF0", VA = "0x180CE8BF0", Slot = "2")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x60015B6")]
	[Address(RVA = "0xCE8D90", Offset = "0xCE8190", VA = "0x180CE8D90", Slot = "3")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x60015B7")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x60015B8")]
	[Address(RVA = "0x9749C0", Offset = "0x973DC0", VA = "0x1809749C0", Slot = "12")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x60015B9")]
	[Address(RVA = "0xCE8A00", Offset = "0xCE7E00", VA = "0x180CE8A00", Slot = "7")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x60015BA")]
	[Address(RVA = "0xCE8CB0", Offset = "0xCE80B0", VA = "0x180CE8CB0", Slot = "4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(PresetStatUpdateResponse other)
	{
	}

	[Token(Token = "0x60015BB")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x60015BC")]
	[Address(RVA = "0xCE9060", Offset = "0xCE8460", VA = "0x180CE9060", Slot = "11")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
