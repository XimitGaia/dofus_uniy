using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Alliance.Information;

[Token(Token = "0x2000CB5")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class AllianceInsiderInformationRequest : IMessage<AllianceInsiderInformationRequest>, IMessage, IEquatable<AllianceInsiderInformationRequest>, IDeepCloneable<AllianceInsiderInformationRequest>, IBufferMessage
{
	[Token(Token = "0x4002EC5")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<AllianceInsiderInformationRequest> _parser;

	[Token(Token = "0x4002EC6")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x17001D45")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageParser<AllianceInsiderInformationRequest> Parser
	{
		[Token(Token = "0x60085DF")]
		[Address(RVA = "0xC93B90", Offset = "0xC92F90", VA = "0x180C93B90")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001D46")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x60085E0")]
		[Address(RVA = "0xC93AE0", Offset = "0xC92EE0", VA = "0x180C93AE0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001D47")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x60085E1")]
		[Address(RVA = "0xC93BE0", Offset = "0xC92FE0", VA = "0x180C93BE0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x60085E2")]
	[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public AllianceInsiderInformationRequest()
	{
	}

	[Token(Token = "0x60085E3")]
	[Address(RVA = "0x923CD0", Offset = "0x9230D0", VA = "0x180923CD0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public AllianceInsiderInformationRequest(AllianceInsiderInformationRequest other)
	{
	}

	[Token(Token = "0x60085E4")]
	[Address(RVA = "0xC93880", Offset = "0xC92C80", VA = "0x180C93880", Slot = "10")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public AllianceInsiderInformationRequest Clone()
	{
		return null;
	}

	[Token(Token = "0x60085E5")]
	[Address(RVA = "0xC93900", Offset = "0xC92D00", VA = "0x180C93900", Slot = "0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x60085E6")]
	[Address(RVA = "0x923AC0", Offset = "0x922EC0", VA = "0x180923AC0", Slot = "9")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public bool Equals(AllianceInsiderInformationRequest other)
	{
		return default(bool);
	}

	[Token(Token = "0x60085E7")]
	[Address(RVA = "0x923AE0", Offset = "0x922EE0", VA = "0x180923AE0", Slot = "2")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x60085E8")]
	[Address(RVA = "0xC93980", Offset = "0xC92D80", VA = "0x180C93980", Slot = "3")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x60085E9")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x60085EA")]
	[Address(RVA = "0x923EA0", Offset = "0x9232A0", VA = "0x180923EA0", Slot = "12")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x60085EB")]
	[Address(RVA = "0x9239A0", Offset = "0x922DA0", VA = "0x1809239A0", Slot = "7")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x60085EC")]
	[Address(RVA = "0x923B20", Offset = "0x922F20", VA = "0x180923B20", Slot = "4")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(AllianceInsiderInformationRequest other)
	{
	}

	[Token(Token = "0x60085ED")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x60085EE")]
	[Address(RVA = "0x923E20", Offset = "0x923220", VA = "0x180923E20", Slot = "11")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
