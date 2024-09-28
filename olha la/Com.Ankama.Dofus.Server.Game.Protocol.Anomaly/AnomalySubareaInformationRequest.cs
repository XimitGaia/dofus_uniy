using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Anomaly;

[Token(Token = "0x2000C35")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class AnomalySubareaInformationRequest : IMessage<AnomalySubareaInformationRequest>, IMessage, IEquatable<AnomalySubareaInformationRequest>, IDeepCloneable<AnomalySubareaInformationRequest>, IBufferMessage
{
	[Token(Token = "0x4002D51")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<AnomalySubareaInformationRequest> _parser;

	[Token(Token = "0x4002D52")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x17001C36")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<AnomalySubareaInformationRequest> Parser
	{
		[Token(Token = "0x6008081")]
		[Address(RVA = "0xC85370", Offset = "0xC84770", VA = "0x180C85370")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001C37")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x6008082")]
		[Address(RVA = "0xC852C0", Offset = "0xC846C0", VA = "0x180C852C0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001C38")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x6008083")]
		[Address(RVA = "0xC853C0", Offset = "0xC847C0", VA = "0x180C853C0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6008084")]
	[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public AnomalySubareaInformationRequest()
	{
	}

	[Token(Token = "0x6008085")]
	[Address(RVA = "0x923CD0", Offset = "0x9230D0", VA = "0x180923CD0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public AnomalySubareaInformationRequest(AnomalySubareaInformationRequest other)
	{
	}

	[Token(Token = "0x6008086")]
	[Address(RVA = "0xC85060", Offset = "0xC84460", VA = "0x180C85060", Slot = "10")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public AnomalySubareaInformationRequest Clone()
	{
		return null;
	}

	[Token(Token = "0x6008087")]
	[Address(RVA = "0xC850E0", Offset = "0xC844E0", VA = "0x180C850E0", Slot = "0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x6008088")]
	[Address(RVA = "0x923AC0", Offset = "0x922EC0", VA = "0x180923AC0", Slot = "9")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public bool Equals(AnomalySubareaInformationRequest other)
	{
		return default(bool);
	}

	[Token(Token = "0x6008089")]
	[Address(RVA = "0x923AE0", Offset = "0x922EE0", VA = "0x180923AE0", Slot = "2")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x600808A")]
	[Address(RVA = "0xC85160", Offset = "0xC84560", VA = "0x180C85160", Slot = "3")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x600808B")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x600808C")]
	[Address(RVA = "0x923EA0", Offset = "0x9232A0", VA = "0x180923EA0", Slot = "12")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x600808D")]
	[Address(RVA = "0x9239A0", Offset = "0x922DA0", VA = "0x1809239A0", Slot = "7")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x600808E")]
	[Address(RVA = "0x923B20", Offset = "0x922F20", VA = "0x180923B20", Slot = "4")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(AnomalySubareaInformationRequest other)
	{
	}

	[Token(Token = "0x600808F")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x6008090")]
	[Address(RVA = "0x923E20", Offset = "0x923220", VA = "0x180923E20", Slot = "11")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
