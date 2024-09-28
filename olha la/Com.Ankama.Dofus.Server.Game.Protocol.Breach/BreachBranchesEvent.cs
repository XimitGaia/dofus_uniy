using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Com.Ankama.Dofus.Server.Game.Protocol.Common;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Breach;

[Token(Token = "0x200090D")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class BreachBranchesEvent : IMessage<BreachBranchesEvent>, IMessage, IEquatable<BreachBranchesEvent>, IDeepCloneable<BreachBranchesEvent>, IBufferMessage
{
	[Token(Token = "0x4001EF5")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<BreachBranchesEvent> _parser;

	[Token(Token = "0x4001EF6")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x4001EF7")]
	public const int BranchesFieldNumber = 1;

	[Token(Token = "0x4001EF8")]
	[FieldOffset(Offset = "0x8")]
	private static readonly FieldCodec<BreachBranch> _repeated_branches_codec;

	[Token(Token = "0x4001EF9")]
	[FieldOffset(Offset = "0x18")]
	private readonly RepeatedField<BreachBranch> branches_;

	[Token(Token = "0x17001441")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<BreachBranchesEvent> Parser
	{
		[Token(Token = "0x6005FBB")]
		[Address(RVA = "0xB4E3F0", Offset = "0xB4D7F0", VA = "0x180B4E3F0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001442")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x6005FBC")]
		[Address(RVA = "0xB4E340", Offset = "0xB4D740", VA = "0x180B4E340")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001443")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x6005FBD")]
		[Address(RVA = "0xB4E600", Offset = "0xB4DA00", VA = "0x180B4E600", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001444")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public RepeatedField<BreachBranch> Branches
	{
		[Token(Token = "0x6005FC1")]
		[Address(RVA = "0x7D2760", Offset = "0x7D1B60", VA = "0x1807D2760")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6005FBE")]
	[Address(RVA = "0xB4E2C0", Offset = "0xB4D6C0", VA = "0x180B4E2C0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public BreachBranchesEvent()
	{
	}

	[Token(Token = "0x6005FBF")]
	[Address(RVA = "0xB4E230", Offset = "0xB4D630", VA = "0x180B4E230")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public BreachBranchesEvent(BreachBranchesEvent other)
	{
	}

	[Token(Token = "0x6005FC0")]
	[Address(RVA = "0xB4DD80", Offset = "0xB4D180", VA = "0x180B4DD80", Slot = "10")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public BreachBranchesEvent Clone()
	{
		return null;
	}

	[Token(Token = "0x6005FC2")]
	[Address(RVA = "0xB4DED0", Offset = "0xB4D2D0", VA = "0x180B4DED0", Slot = "0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x6005FC3")]
	[Address(RVA = "0xB4DE40", Offset = "0xB4D240", VA = "0x180B4DE40", Slot = "9")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public bool Equals(BreachBranchesEvent other)
	{
		return default(bool);
	}

	[Token(Token = "0x6005FC4")]
	[Address(RVA = "0x9364E0", Offset = "0x9358E0", VA = "0x1809364E0", Slot = "2")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x6005FC5")]
	[Address(RVA = "0xB4E030", Offset = "0xB4D430", VA = "0x180B4E030", Slot = "3")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x6005FC6")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x6005FC7")]
	[Address(RVA = "0xB4E550", Offset = "0xB4D950", VA = "0x180B4E550", Slot = "12")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x6005FC8")]
	[Address(RVA = "0xB4DCE0", Offset = "0xB4D0E0", VA = "0x180B4DCE0", Slot = "7")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x6005FC9")]
	[Address(RVA = "0xB4DFB0", Offset = "0xB4D3B0", VA = "0x180B4DFB0", Slot = "4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(BreachBranchesEvent other)
	{
	}

	[Token(Token = "0x6005FCA")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x6005FCB")]
	[Address(RVA = "0xB4E440", Offset = "0xB4D840", VA = "0x180B4E440", Slot = "11")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
