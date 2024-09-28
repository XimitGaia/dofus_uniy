using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Com.Ankama.Dofus.Server.Game.Protocol.Common;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Character.Management;

[Token(Token = "0x2000892")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class CharacterReplayWithRemodelRequest : IMessage<CharacterReplayWithRemodelRequest>, IMessage, IEquatable<CharacterReplayWithRemodelRequest>, IDeepCloneable<CharacterReplayWithRemodelRequest>, IBufferMessage
{
	[Token(Token = "0x4001D9F")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<CharacterReplayWithRemodelRequest> _parser;

	[Token(Token = "0x4001DA0")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x4001DA1")]
	public const int CharacterIdFieldNumber = 1;

	[Token(Token = "0x4001DA2")]
	[FieldOffset(Offset = "0x18")]
	private long characterId_;

	[Token(Token = "0x4001DA3")]
	public const int RemodelingInformationFieldNumber = 2;

	[Token(Token = "0x4001DA4")]
	[FieldOffset(Offset = "0x20")]
	private Com.Ankama.Dofus.Server.Game.Protocol.Common.Character remodelingInformation_;

	[Token(Token = "0x17001357")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageParser<CharacterReplayWithRemodelRequest> Parser
	{
		[Token(Token = "0x6005AEE")]
		[Address(RVA = "0xB23A80", Offset = "0xB22E80", VA = "0x180B23A80")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001358")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x6005AEF")]
		[Address(RVA = "0xB239D0", Offset = "0xB22DD0", VA = "0x180B239D0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001359")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x6005AF0")]
		[Address(RVA = "0xB23BF0", Offset = "0xB22FF0", VA = "0x180B23BF0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700135A")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public long CharacterId
	{
		[Token(Token = "0x6005AF4")]
		[Address(RVA = "0x7D2760", Offset = "0x7D1B60", VA = "0x1807D2760")]
		get
		{
			return default(long);
		}
		[Token(Token = "0x6005AF5")]
		[Address(RVA = "0x918550", Offset = "0x917950", VA = "0x180918550")]
		set
		{
		}
	}

	[Token(Token = "0x1700135B")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public Com.Ankama.Dofus.Server.Game.Protocol.Common.Character RemodelingInformation
	{
		[Token(Token = "0x6005AF6")]
		[Address(RVA = "0x7D2770", Offset = "0x7D1B70", VA = "0x1807D2770")]
		get
		{
			return null;
		}
		[Token(Token = "0x6005AF7")]
		[Address(RVA = "0x7F0090", Offset = "0x7EF490", VA = "0x1807F0090")]
		set
		{
		}
	}

	[Token(Token = "0x6005AF1")]
	[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public CharacterReplayWithRemodelRequest()
	{
	}

	[Token(Token = "0x6005AF2")]
	[Address(RVA = "0xB23950", Offset = "0xB22D50", VA = "0x180B23950")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public CharacterReplayWithRemodelRequest(CharacterReplayWithRemodelRequest other)
	{
	}

	[Token(Token = "0x6005AF3")]
	[Address(RVA = "0xB235B0", Offset = "0xB229B0", VA = "0x180B235B0", Slot = "10")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public CharacterReplayWithRemodelRequest Clone()
	{
		return null;
	}

	[Token(Token = "0x6005AF8")]
	[Address(RVA = "0xB23650", Offset = "0xB22A50", VA = "0x180B23650", Slot = "0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x6005AF9")]
	[Address(RVA = "0x953270", Offset = "0x952670", VA = "0x180953270", Slot = "9")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(CharacterReplayWithRemodelRequest other)
	{
		return default(bool);
	}

	[Token(Token = "0x6005AFA")]
	[Address(RVA = "0x9533A0", Offset = "0x9527A0", VA = "0x1809533A0", Slot = "2")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x6005AFB")]
	[Address(RVA = "0xB237F0", Offset = "0xB22BF0", VA = "0x180B237F0", Slot = "3")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x6005AFC")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x6005AFD")]
	[Address(RVA = "0x953910", Offset = "0x952D10", VA = "0x180953910", Slot = "12")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x6005AFE")]
	[Address(RVA = "0xB234F0", Offset = "0xB228F0", VA = "0x180B234F0", Slot = "7")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x6005AFF")]
	[Address(RVA = "0xB23710", Offset = "0xB22B10", VA = "0x180B23710", Slot = "4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CharacterReplayWithRemodelRequest other)
	{
	}

	[Token(Token = "0x6005B00")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x6005B01")]
	[Address(RVA = "0xB23AD0", Offset = "0xB22ED0", VA = "0x180B23AD0", Slot = "11")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
