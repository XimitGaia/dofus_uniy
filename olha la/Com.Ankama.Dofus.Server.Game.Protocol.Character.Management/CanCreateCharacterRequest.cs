using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Character.Management;

[Token(Token = "0x200088C")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class CanCreateCharacterRequest : IMessage<CanCreateCharacterRequest>, IMessage, IEquatable<CanCreateCharacterRequest>, IDeepCloneable<CanCreateCharacterRequest>, IBufferMessage
{
	[Token(Token = "0x4001D92")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<CanCreateCharacterRequest> _parser;

	[Token(Token = "0x4001D93")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x1700134C")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageParser<CanCreateCharacterRequest> Parser
	{
		[Token(Token = "0x6005AAE")]
		[Address(RVA = "0xB152D0", Offset = "0xB146D0", VA = "0x180B152D0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700134D")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x6005AAF")]
		[Address(RVA = "0xB15220", Offset = "0xB14620", VA = "0x180B15220")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700134E")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x6005AB0")]
		[Address(RVA = "0xB15320", Offset = "0xB14720", VA = "0x180B15320", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6005AB1")]
	[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public CanCreateCharacterRequest()
	{
	}

	[Token(Token = "0x6005AB2")]
	[Address(RVA = "0x923CD0", Offset = "0x9230D0", VA = "0x180923CD0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public CanCreateCharacterRequest(CanCreateCharacterRequest other)
	{
	}

	[Token(Token = "0x6005AB3")]
	[Address(RVA = "0xB14FC0", Offset = "0xB143C0", VA = "0x180B14FC0", Slot = "10")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public CanCreateCharacterRequest Clone()
	{
		return null;
	}

	[Token(Token = "0x6005AB4")]
	[Address(RVA = "0xB15040", Offset = "0xB14440", VA = "0x180B15040", Slot = "0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x6005AB5")]
	[Address(RVA = "0x923AC0", Offset = "0x922EC0", VA = "0x180923AC0", Slot = "9")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(CanCreateCharacterRequest other)
	{
		return default(bool);
	}

	[Token(Token = "0x6005AB6")]
	[Address(RVA = "0x923AE0", Offset = "0x922EE0", VA = "0x180923AE0", Slot = "2")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x6005AB7")]
	[Address(RVA = "0xB150C0", Offset = "0xB144C0", VA = "0x180B150C0", Slot = "3")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x6005AB8")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x6005AB9")]
	[Address(RVA = "0x923EA0", Offset = "0x9232A0", VA = "0x180923EA0", Slot = "12")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x6005ABA")]
	[Address(RVA = "0x9239A0", Offset = "0x922DA0", VA = "0x1809239A0", Slot = "7")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x6005ABB")]
	[Address(RVA = "0x923B20", Offset = "0x922F20", VA = "0x180923B20", Slot = "4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CanCreateCharacterRequest other)
	{
	}

	[Token(Token = "0x6005ABC")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x6005ABD")]
	[Address(RVA = "0x923E20", Offset = "0x923220", VA = "0x180923E20", Slot = "11")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
