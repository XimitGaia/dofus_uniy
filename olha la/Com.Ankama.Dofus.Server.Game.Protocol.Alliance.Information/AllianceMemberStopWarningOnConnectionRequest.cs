using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Alliance.Information;

[Token(Token = "0x2000CAB")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class AllianceMemberStopWarningOnConnectionRequest : IMessage<AllianceMemberStopWarningOnConnectionRequest>, IMessage, IEquatable<AllianceMemberStopWarningOnConnectionRequest>, IDeepCloneable<AllianceMemberStopWarningOnConnectionRequest>, IBufferMessage
{
	[Token(Token = "0x4002EAC")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<AllianceMemberStopWarningOnConnectionRequest> _parser;

	[Token(Token = "0x4002EAD")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x17001D31")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageParser<AllianceMemberStopWarningOnConnectionRequest> Parser
	{
		[Token(Token = "0x6008571")]
		[Address(RVA = "0xC97AA0", Offset = "0xC96EA0", VA = "0x180C97AA0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001D32")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x6008572")]
		[Address(RVA = "0xC979F0", Offset = "0xC96DF0", VA = "0x180C979F0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001D33")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x6008573")]
		[Address(RVA = "0xC97AF0", Offset = "0xC96EF0", VA = "0x180C97AF0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6008574")]
	[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public AllianceMemberStopWarningOnConnectionRequest()
	{
	}

	[Token(Token = "0x6008575")]
	[Address(RVA = "0x923CD0", Offset = "0x9230D0", VA = "0x180923CD0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public AllianceMemberStopWarningOnConnectionRequest(AllianceMemberStopWarningOnConnectionRequest other)
	{
	}

	[Token(Token = "0x6008576")]
	[Address(RVA = "0xC97790", Offset = "0xC96B90", VA = "0x180C97790", Slot = "10")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public AllianceMemberStopWarningOnConnectionRequest Clone()
	{
		return null;
	}

	[Token(Token = "0x6008577")]
	[Address(RVA = "0xC97810", Offset = "0xC96C10", VA = "0x180C97810", Slot = "0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x6008578")]
	[Address(RVA = "0x923AC0", Offset = "0x922EC0", VA = "0x180923AC0", Slot = "9")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public bool Equals(AllianceMemberStopWarningOnConnectionRequest other)
	{
		return default(bool);
	}

	[Token(Token = "0x6008579")]
	[Address(RVA = "0x923AE0", Offset = "0x922EE0", VA = "0x180923AE0", Slot = "2")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x600857A")]
	[Address(RVA = "0xC97890", Offset = "0xC96C90", VA = "0x180C97890", Slot = "3")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x600857B")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x600857C")]
	[Address(RVA = "0x923EA0", Offset = "0x9232A0", VA = "0x180923EA0", Slot = "12")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x600857D")]
	[Address(RVA = "0x9239A0", Offset = "0x922DA0", VA = "0x1809239A0", Slot = "7")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x600857E")]
	[Address(RVA = "0x923B20", Offset = "0x922F20", VA = "0x180923B20", Slot = "4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(AllianceMemberStopWarningOnConnectionRequest other)
	{
	}

	[Token(Token = "0x600857F")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x6008580")]
	[Address(RVA = "0x923E20", Offset = "0x923220", VA = "0x180923E20", Slot = "11")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
