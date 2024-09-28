using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Com.Ankama.Dofus.Server.Game.Protocol.Common;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Alliance.Conquest;

[Token(Token = "0x2000CDB")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class AllianceFightReplaceRequest : IMessage<AllianceFightReplaceRequest>, IMessage, IEquatable<AllianceFightReplaceRequest>, IDeepCloneable<AllianceFightReplaceRequest>, IBufferMessage
{
	[Token(Token = "0x4002F53")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<AllianceFightReplaceRequest> _parser;

	[Token(Token = "0x4002F54")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x4002F55")]
	public const int FightInformationFieldNumber = 1;

	[Token(Token = "0x4002F56")]
	[FieldOffset(Offset = "0x18")]
	private SocialFightInformation fightInformation_;

	[Token(Token = "0x4002F57")]
	public const int ToReplaceFighterIdFieldNumber = 2;

	[Token(Token = "0x4002F58")]
	[FieldOffset(Offset = "0x20")]
	private long toReplaceFighterId_;

	[Token(Token = "0x17001D9D")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<AllianceFightReplaceRequest> Parser
	{
		[Token(Token = "0x6008776")]
		[Address(RVA = "0xCAD930", Offset = "0xCACD30", VA = "0x180CAD930")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001D9E")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x6008777")]
		[Address(RVA = "0xCAD880", Offset = "0xCACC80", VA = "0x180CAD880")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001D9F")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x6008778")]
		[Address(RVA = "0xCADAA0", Offset = "0xCACEA0", VA = "0x180CADAA0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001DA0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public SocialFightInformation FightInformation
	{
		[Token(Token = "0x600877C")]
		[Address(RVA = "0x7D2760", Offset = "0x7D1B60", VA = "0x1807D2760")]
		get
		{
			return null;
		}
		[Token(Token = "0x600877D")]
		[Address(RVA = "0x7F3FF0", Offset = "0x7F33F0", VA = "0x1807F3FF0")]
		set
		{
		}
	}

	[Token(Token = "0x17001DA1")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public long ToReplaceFighterId
	{
		[Token(Token = "0x600877E")]
		[Address(RVA = "0x7D2770", Offset = "0x7D1B70", VA = "0x1807D2770")]
		get
		{
			return default(long);
		}
		[Token(Token = "0x600877F")]
		[Address(RVA = "0x91A4B0", Offset = "0x9198B0", VA = "0x18091A4B0")]
		set
		{
		}
	}

	[Token(Token = "0x6008779")]
	[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public AllianceFightReplaceRequest()
	{
	}

	[Token(Token = "0x600877A")]
	[Address(RVA = "0xCAAA20", Offset = "0xCA9E20", VA = "0x180CAAA20")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public AllianceFightReplaceRequest(AllianceFightReplaceRequest other)
	{
	}

	[Token(Token = "0x600877B")]
	[Address(RVA = "0xCAD4D0", Offset = "0xCAC8D0", VA = "0x180CAD4D0", Slot = "10")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public AllianceFightReplaceRequest Clone()
	{
		return null;
	}

	[Token(Token = "0x6008780")]
	[Address(RVA = "0xCAD580", Offset = "0xCAC980", VA = "0x180CAD580", Slot = "0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x6008781")]
	[Address(RVA = "0x9719A0", Offset = "0x970DA0", VA = "0x1809719A0", Slot = "9")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public bool Equals(AllianceFightReplaceRequest other)
	{
		return default(bool);
	}

	[Token(Token = "0x6008782")]
	[Address(RVA = "0x971AD0", Offset = "0x970ED0", VA = "0x180971AD0", Slot = "2")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x6008783")]
	[Address(RVA = "0xCAD720", Offset = "0xCACB20", VA = "0x180CAD720", Slot = "3")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x6008784")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x6008785")]
	[Address(RVA = "0x972120", Offset = "0x971520", VA = "0x180972120", Slot = "12")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x6008786")]
	[Address(RVA = "0xCAD410", Offset = "0xCAC810", VA = "0x180CAD410", Slot = "7")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x6008787")]
	[Address(RVA = "0xCAD640", Offset = "0xCACA40", VA = "0x180CAD640", Slot = "4")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(AllianceFightReplaceRequest other)
	{
	}

	[Token(Token = "0x6008788")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x6008789")]
	[Address(RVA = "0xCAD980", Offset = "0xCACD80", VA = "0x180CAD980", Slot = "11")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
