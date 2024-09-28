using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Com.Ankama.Dofus.Server.Game.Protocol.Common;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Fight;

[Token(Token = "0x2000610")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class FightMapInformationResponse : IMessage<FightMapInformationResponse>, IMessage, IEquatable<FightMapInformationResponse>, IDeepCloneable<FightMapInformationResponse>, IBufferMessage
{
	[Token(Token = "0x4001554")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<FightMapInformationResponse> _parser;

	[Token(Token = "0x4001555")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x4001556")]
	public const int MapIdFieldNumber = 1;

	[Token(Token = "0x4001557")]
	[FieldOffset(Offset = "0x18")]
	private long mapId_;

	[Token(Token = "0x4001558")]
	public const int FightMapIdFieldNumber = 2;

	[Token(Token = "0x4001559")]
	[FieldOffset(Offset = "0x20")]
	private long fightMapId_;

	[Token(Token = "0x400155A")]
	public const int FightStartPositionsFieldNumber = 3;

	[Token(Token = "0x400155B")]
	[FieldOffset(Offset = "0x28")]
	private FightStartingPositions fightStartPositions_;

	[Token(Token = "0x17000DEA")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<FightMapInformationResponse> Parser
	{
		[Token(Token = "0x60040C9")]
		[Address(RVA = "0xA40A30", Offset = "0xA3FE30", VA = "0x180A40A30")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000DEB")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x60040CA")]
		[Address(RVA = "0xA40980", Offset = "0xA3FD80", VA = "0x180A40980")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000DEC")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x60040CB")]
		[Address(RVA = "0xA40C60", Offset = "0xA40060", VA = "0x180A40C60", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000DED")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public long MapId
	{
		[Token(Token = "0x60040CF")]
		[Address(RVA = "0x7D2760", Offset = "0x7D1B60", VA = "0x1807D2760")]
		get
		{
			return default(long);
		}
		[Token(Token = "0x60040D0")]
		[Address(RVA = "0x918550", Offset = "0x917950", VA = "0x180918550")]
		set
		{
		}
	}

	[Token(Token = "0x17000DEE")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public long FightMapId
	{
		[Token(Token = "0x60040D1")]
		[Address(RVA = "0x7D2770", Offset = "0x7D1B70", VA = "0x1807D2770")]
		get
		{
			return default(long);
		}
		[Token(Token = "0x60040D2")]
		[Address(RVA = "0x91A4B0", Offset = "0x9198B0", VA = "0x18091A4B0")]
		set
		{
		}
	}

	[Token(Token = "0x17000DEF")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public FightStartingPositions FightStartPositions
	{
		[Token(Token = "0x60040D3")]
		[Address(RVA = "0x91A0B0", Offset = "0x9194B0", VA = "0x18091A0B0")]
		get
		{
			return null;
		}
		[Token(Token = "0x60040D4")]
		[Address(RVA = "0x96C220", Offset = "0x96B620", VA = "0x18096C220")]
		set
		{
		}
	}

	[Token(Token = "0x60040CC")]
	[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public FightMapInformationResponse()
	{
	}

	[Token(Token = "0x60040CD")]
	[Address(RVA = "0xA40900", Offset = "0xA3FD00", VA = "0x180A40900")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public FightMapInformationResponse(FightMapInformationResponse other)
	{
	}

	[Token(Token = "0x60040CE")]
	[Address(RVA = "0xA40420", Offset = "0xA3F820", VA = "0x180A40420", Slot = "10")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public FightMapInformationResponse Clone()
	{
		return null;
	}

	[Token(Token = "0x60040D5")]
	[Address(RVA = "0xA404D0", Offset = "0xA3F8D0", VA = "0x180A404D0", Slot = "0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x60040D6")]
	[Address(RVA = "0xA40590", Offset = "0xA3F990", VA = "0x180A40590", Slot = "9")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(FightMapInformationResponse other)
	{
		return default(bool);
	}

	[Token(Token = "0x60040D7")]
	[Address(RVA = "0xA40610", Offset = "0xA3FA10", VA = "0x180A40610", Slot = "2")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x60040D8")]
	[Address(RVA = "0xA407A0", Offset = "0xA3FBA0", VA = "0x180A407A0", Slot = "3")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x60040D9")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x60040DA")]
	[Address(RVA = "0xA40BC0", Offset = "0xA3FFC0", VA = "0x180A40BC0", Slot = "12")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x60040DB")]
	[Address(RVA = "0xA40330", Offset = "0xA3F730", VA = "0x180A40330", Slot = "7")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x60040DC")]
	[Address(RVA = "0xA406C0", Offset = "0xA3FAC0", VA = "0x180A406C0", Slot = "4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(FightMapInformationResponse other)
	{
	}

	[Token(Token = "0x60040DD")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x60040DE")]
	[Address(RVA = "0xA40A80", Offset = "0xA3FE80", VA = "0x180A40A80", Slot = "11")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
