using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Alliance.Information;

[Token(Token = "0x2000CA9")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class AllianceMemberStartWarningOnConnectionRequest : IMessage<AllianceMemberStartWarningOnConnectionRequest>, IMessage, IEquatable<AllianceMemberStartWarningOnConnectionRequest>, IDeepCloneable<AllianceMemberStartWarningOnConnectionRequest>, IBufferMessage
{
	[Token(Token = "0x4002EA9")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<AllianceMemberStartWarningOnConnectionRequest> _parser;

	[Token(Token = "0x4002EAA")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x17001D2E")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageParser<AllianceMemberStartWarningOnConnectionRequest> Parser
	{
		[Token(Token = "0x600855D")]
		[Address(RVA = "0xC97660", Offset = "0xC96A60", VA = "0x180C97660")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001D2F")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x600855E")]
		[Address(RVA = "0xC975B0", Offset = "0xC969B0", VA = "0x180C975B0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001D30")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x600855F")]
		[Address(RVA = "0xC976B0", Offset = "0xC96AB0", VA = "0x180C976B0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6008560")]
	[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public AllianceMemberStartWarningOnConnectionRequest()
	{
	}

	[Token(Token = "0x6008561")]
	[Address(RVA = "0x923CD0", Offset = "0x9230D0", VA = "0x180923CD0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public AllianceMemberStartWarningOnConnectionRequest(AllianceMemberStartWarningOnConnectionRequest other)
	{
	}

	[Token(Token = "0x6008562")]
	[Address(RVA = "0xC97350", Offset = "0xC96750", VA = "0x180C97350", Slot = "10")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public AllianceMemberStartWarningOnConnectionRequest Clone()
	{
		return null;
	}

	[Token(Token = "0x6008563")]
	[Address(RVA = "0xC973D0", Offset = "0xC967D0", VA = "0x180C973D0", Slot = "0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x6008564")]
	[Address(RVA = "0x923AC0", Offset = "0x922EC0", VA = "0x180923AC0", Slot = "9")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(AllianceMemberStartWarningOnConnectionRequest other)
	{
		return default(bool);
	}

	[Token(Token = "0x6008565")]
	[Address(RVA = "0x923AE0", Offset = "0x922EE0", VA = "0x180923AE0", Slot = "2")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x6008566")]
	[Address(RVA = "0xC97450", Offset = "0xC96850", VA = "0x180C97450", Slot = "3")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x6008567")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x6008568")]
	[Address(RVA = "0x923EA0", Offset = "0x9232A0", VA = "0x180923EA0", Slot = "12")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x6008569")]
	[Address(RVA = "0x9239A0", Offset = "0x922DA0", VA = "0x1809239A0", Slot = "7")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x600856A")]
	[Address(RVA = "0x923B20", Offset = "0x922F20", VA = "0x180923B20", Slot = "4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(AllianceMemberStartWarningOnConnectionRequest other)
	{
	}

	[Token(Token = "0x600856B")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x600856C")]
	[Address(RVA = "0x923E20", Offset = "0x923220", VA = "0x180923E20", Slot = "11")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
