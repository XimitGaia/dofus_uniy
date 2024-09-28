using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Preset;

[Token(Token = "0x2000253")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class CharacterPresetCurrentStateRequest : IMessage<CharacterPresetCurrentStateRequest>, IMessage, IEquatable<CharacterPresetCurrentStateRequest>, IDeepCloneable<CharacterPresetCurrentStateRequest>, IBufferMessage
{
	[Token(Token = "0x40007E1")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<CharacterPresetCurrentStateRequest> _parser;

	[Token(Token = "0x40007E2")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x1700050E")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<CharacterPresetCurrentStateRequest> Parser
	{
		[Token(Token = "0x60017B4")]
		[Address(RVA = "0xCEFA40", Offset = "0xCEEE40", VA = "0x180CEFA40")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700050F")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x60017B5")]
		[Address(RVA = "0xCEF990", Offset = "0xCEED90", VA = "0x180CEF990")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000510")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x60017B6")]
		[Address(RVA = "0xCEFA90", Offset = "0xCEEE90", VA = "0x180CEFA90", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x60017B7")]
	[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public CharacterPresetCurrentStateRequest()
	{
	}

	[Token(Token = "0x60017B8")]
	[Address(RVA = "0x923CD0", Offset = "0x9230D0", VA = "0x180923CD0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public CharacterPresetCurrentStateRequest(CharacterPresetCurrentStateRequest other)
	{
	}

	[Token(Token = "0x60017B9")]
	[Address(RVA = "0xCEF730", Offset = "0xCEEB30", VA = "0x180CEF730", Slot = "10")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public CharacterPresetCurrentStateRequest Clone()
	{
		return null;
	}

	[Token(Token = "0x60017BA")]
	[Address(RVA = "0xCEF7B0", Offset = "0xCEEBB0", VA = "0x180CEF7B0", Slot = "0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x60017BB")]
	[Address(RVA = "0x923AC0", Offset = "0x922EC0", VA = "0x180923AC0", Slot = "9")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(CharacterPresetCurrentStateRequest other)
	{
		return default(bool);
	}

	[Token(Token = "0x60017BC")]
	[Address(RVA = "0x923AE0", Offset = "0x922EE0", VA = "0x180923AE0", Slot = "2")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x60017BD")]
	[Address(RVA = "0xCEF830", Offset = "0xCEEC30", VA = "0x180CEF830", Slot = "3")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x60017BE")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x60017BF")]
	[Address(RVA = "0x923EA0", Offset = "0x9232A0", VA = "0x180923EA0", Slot = "12")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x60017C0")]
	[Address(RVA = "0x9239A0", Offset = "0x922DA0", VA = "0x1809239A0", Slot = "7")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x60017C1")]
	[Address(RVA = "0x923B20", Offset = "0x922F20", VA = "0x180923B20", Slot = "4")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(CharacterPresetCurrentStateRequest other)
	{
	}

	[Token(Token = "0x60017C2")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x60017C3")]
	[Address(RVA = "0x923E20", Offset = "0x923220", VA = "0x180923E20", Slot = "11")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
