using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Achievement;

[Token(Token = "0x2000D15")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class AchievementsAlmostFinishedDetailedRequest : IMessage<AchievementsAlmostFinishedDetailedRequest>, IMessage, IEquatable<AchievementsAlmostFinishedDetailedRequest>, IDeepCloneable<AchievementsAlmostFinishedDetailedRequest>, IBufferMessage
{
	[Token(Token = "0x4003004")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<AchievementsAlmostFinishedDetailedRequest> _parser;

	[Token(Token = "0x4003005")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x17001E15")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<AchievementsAlmostFinishedDetailedRequest> Parser
	{
		[Token(Token = "0x60089BE")]
		[Address(RVA = "0xCA6830", Offset = "0xCA5C30", VA = "0x180CA6830")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001E16")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x60089BF")]
		[Address(RVA = "0xCA6780", Offset = "0xCA5B80", VA = "0x180CA6780")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001E17")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x60089C0")]
		[Address(RVA = "0xCA6880", Offset = "0xCA5C80", VA = "0x180CA6880", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x60089C1")]
	[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public AchievementsAlmostFinishedDetailedRequest()
	{
	}

	[Token(Token = "0x60089C2")]
	[Address(RVA = "0x923CD0", Offset = "0x9230D0", VA = "0x180923CD0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public AchievementsAlmostFinishedDetailedRequest(AchievementsAlmostFinishedDetailedRequest other)
	{
	}

	[Token(Token = "0x60089C3")]
	[Address(RVA = "0xCA6520", Offset = "0xCA5920", VA = "0x180CA6520", Slot = "10")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public AchievementsAlmostFinishedDetailedRequest Clone()
	{
		return null;
	}

	[Token(Token = "0x60089C4")]
	[Address(RVA = "0xCA65A0", Offset = "0xCA59A0", VA = "0x180CA65A0", Slot = "0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x60089C5")]
	[Address(RVA = "0x923AC0", Offset = "0x922EC0", VA = "0x180923AC0", Slot = "9")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(AchievementsAlmostFinishedDetailedRequest other)
	{
		return default(bool);
	}

	[Token(Token = "0x60089C6")]
	[Address(RVA = "0x923AE0", Offset = "0x922EE0", VA = "0x180923AE0", Slot = "2")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x60089C7")]
	[Address(RVA = "0xCA6620", Offset = "0xCA5A20", VA = "0x180CA6620", Slot = "3")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x60089C8")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x60089C9")]
	[Address(RVA = "0x923EA0", Offset = "0x9232A0", VA = "0x180923EA0", Slot = "12")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x60089CA")]
	[Address(RVA = "0x9239A0", Offset = "0x922DA0", VA = "0x1809239A0", Slot = "7")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x60089CB")]
	[Address(RVA = "0x923B20", Offset = "0x922F20", VA = "0x180923B20", Slot = "4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(AchievementsAlmostFinishedDetailedRequest other)
	{
	}

	[Token(Token = "0x60089CC")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x60089CD")]
	[Address(RVA = "0x923E20", Offset = "0x923220", VA = "0x180923E20", Slot = "11")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
