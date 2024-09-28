using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Exchange;

[Token(Token = "0x200067D")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class JobBookSubscribeRequest : IMessage<JobBookSubscribeRequest>, IMessage, IEquatable<JobBookSubscribeRequest>, IDeepCloneable<JobBookSubscribeRequest>, IBufferMessage
{
	[Token(Token = "0x40016AA")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<JobBookSubscribeRequest> _parser;

	[Token(Token = "0x40016AB")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x40016AC")]
	public const int JobsIdFieldNumber = 1;

	[Token(Token = "0x40016AD")]
	[FieldOffset(Offset = "0x8")]
	private static readonly FieldCodec<int> _repeated_jobsId_codec;

	[Token(Token = "0x40016AE")]
	[FieldOffset(Offset = "0x18")]
	private readonly RepeatedField<int> jobsId_;

	[Token(Token = "0x17000EE2")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<JobBookSubscribeRequest> Parser
	{
		[Token(Token = "0x6004598")]
		[Address(RVA = "0xA990A0", Offset = "0xA984A0", VA = "0x180A990A0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000EE3")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x6004599")]
		[Address(RVA = "0xA98FF0", Offset = "0xA983F0", VA = "0x180A98FF0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000EE4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x600459A")]
		[Address(RVA = "0xA992C0", Offset = "0xA986C0", VA = "0x180A992C0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000EE5")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<int> JobsId
	{
		[Token(Token = "0x600459E")]
		[Address(RVA = "0x7D2760", Offset = "0x7D1B60", VA = "0x1807D2760")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x600459B")]
	[Address(RVA = "0xA98F70", Offset = "0xA98370", VA = "0x180A98F70")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public JobBookSubscribeRequest()
	{
	}

	[Token(Token = "0x600459C")]
	[Address(RVA = "0xA98EE0", Offset = "0xA982E0", VA = "0x180A98EE0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public JobBookSubscribeRequest(JobBookSubscribeRequest other)
	{
	}

	[Token(Token = "0x600459D")]
	[Address(RVA = "0xA98AA0", Offset = "0xA97EA0", VA = "0x180A98AA0", Slot = "10")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public JobBookSubscribeRequest Clone()
	{
		return null;
	}

	[Token(Token = "0x600459F")]
	[Address(RVA = "0xA98BF0", Offset = "0xA97FF0", VA = "0x180A98BF0", Slot = "0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x60045A0")]
	[Address(RVA = "0xA98B60", Offset = "0xA97F60", VA = "0x180A98B60", Slot = "9")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(JobBookSubscribeRequest other)
	{
		return default(bool);
	}

	[Token(Token = "0x60045A1")]
	[Address(RVA = "0x9364E0", Offset = "0x9358E0", VA = "0x1809364E0", Slot = "2")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x60045A2")]
	[Address(RVA = "0xA98D50", Offset = "0xA98150", VA = "0x180A98D50", Slot = "3")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x60045A3")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x60045A4")]
	[Address(RVA = "0xA99210", Offset = "0xA98610", VA = "0x180A99210", Slot = "12")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x60045A5")]
	[Address(RVA = "0xA98A00", Offset = "0xA97E00", VA = "0x180A98A00", Slot = "7")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x60045A6")]
	[Address(RVA = "0xA98CD0", Offset = "0xA980D0", VA = "0x180A98CD0", Slot = "4")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(JobBookSubscribeRequest other)
	{
	}

	[Token(Token = "0x60045A7")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x60045A8")]
	[Address(RVA = "0xA990F0", Offset = "0xA984F0", VA = "0x180A990F0", Slot = "11")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
