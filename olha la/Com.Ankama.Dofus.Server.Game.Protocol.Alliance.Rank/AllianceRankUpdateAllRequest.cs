using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Com.Ankama.Dofus.Server.Game.Protocol.Common;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Alliance.Rank;

[Token(Token = "0x2000C7B")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class AllianceRankUpdateAllRequest : IMessage<AllianceRankUpdateAllRequest>, IMessage, IEquatable<AllianceRankUpdateAllRequest>, IDeepCloneable<AllianceRankUpdateAllRequest>, IBufferMessage
{
	[Token(Token = "0x4002E20")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<AllianceRankUpdateAllRequest> _parser;

	[Token(Token = "0x4002E21")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x4002E22")]
	public const int RanksFieldNumber = 1;

	[Token(Token = "0x4002E23")]
	[FieldOffset(Offset = "0x8")]
	private static readonly FieldCodec<RankInformation> _repeated_ranks_codec;

	[Token(Token = "0x4002E24")]
	[FieldOffset(Offset = "0x18")]
	private readonly RepeatedField<RankInformation> ranks_;

	[Token(Token = "0x17001CC9")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<AllianceRankUpdateAllRequest> Parser
	{
		[Token(Token = "0x6008362")]
		[Address(RVA = "0xC79060", Offset = "0xC78460", VA = "0x180C79060")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001CCA")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x6008363")]
		[Address(RVA = "0xC78FB0", Offset = "0xC783B0", VA = "0x180C78FB0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001CCB")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x6008364")]
		[Address(RVA = "0xC79270", Offset = "0xC78670", VA = "0x180C79270", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001CCC")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<RankInformation> Ranks
	{
		[Token(Token = "0x6008368")]
		[Address(RVA = "0x7D2760", Offset = "0x7D1B60", VA = "0x1807D2760")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6008365")]
	[Address(RVA = "0xC78F30", Offset = "0xC78330", VA = "0x180C78F30")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public AllianceRankUpdateAllRequest()
	{
	}

	[Token(Token = "0x6008366")]
	[Address(RVA = "0xC78EA0", Offset = "0xC782A0", VA = "0x180C78EA0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public AllianceRankUpdateAllRequest(AllianceRankUpdateAllRequest other)
	{
	}

	[Token(Token = "0x6008367")]
	[Address(RVA = "0xC789F0", Offset = "0xC77DF0", VA = "0x180C789F0", Slot = "10")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public AllianceRankUpdateAllRequest Clone()
	{
		return null;
	}

	[Token(Token = "0x6008369")]
	[Address(RVA = "0xC78AB0", Offset = "0xC77EB0", VA = "0x180C78AB0", Slot = "0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x600836A")]
	[Address(RVA = "0xC78B90", Offset = "0xC77F90", VA = "0x180C78B90", Slot = "9")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(AllianceRankUpdateAllRequest other)
	{
		return default(bool);
	}

	[Token(Token = "0x600836B")]
	[Address(RVA = "0x9364E0", Offset = "0x9358E0", VA = "0x1809364E0", Slot = "2")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x600836C")]
	[Address(RVA = "0xC78CA0", Offset = "0xC780A0", VA = "0x180C78CA0", Slot = "3")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x600836D")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x600836E")]
	[Address(RVA = "0xC791C0", Offset = "0xC785C0", VA = "0x180C791C0", Slot = "12")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x600836F")]
	[Address(RVA = "0xC78950", Offset = "0xC77D50", VA = "0x180C78950", Slot = "7")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x6008370")]
	[Address(RVA = "0xC78C20", Offset = "0xC78020", VA = "0x180C78C20", Slot = "4")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(AllianceRankUpdateAllRequest other)
	{
	}

	[Token(Token = "0x6008371")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x6008372")]
	[Address(RVA = "0xC790B0", Offset = "0xC784B0", VA = "0x180C790B0", Slot = "11")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
