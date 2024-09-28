using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Bak;

[Token(Token = "0x2000B64")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class BakCancelBidRequest : IMessage<BakCancelBidRequest>, IMessage, IEquatable<BakCancelBidRequest>, IDeepCloneable<BakCancelBidRequest>, IBufferMessage
{
	[Token(Token = "0x2000B65")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static class Types
	{
		[Token(Token = "0x2000B66")]
		public enum BidCancellationType
		{
			[Token(Token = "0x4002A95")]
			[OriginalName("UNKNOWN_TYPE")]
			UnknownType,
			[Token(Token = "0x4002A96")]
			[OriginalName("CLASSIC_TYPE")]
			ClassicType,
			[Token(Token = "0x4002A97")]
			[OriginalName("FRAUD_TYPE")]
			FraudType
		}
	}

	[Token(Token = "0x4002A8E")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<BakCancelBidRequest> _parser;

	[Token(Token = "0x4002A8F")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x4002A90")]
	public const int BidIdFieldNumber = 1;

	[Token(Token = "0x4002A91")]
	[FieldOffset(Offset = "0x18")]
	private long bidId_;

	[Token(Token = "0x4002A92")]
	public const int BidCancellationTypeFieldNumber = 2;

	[Token(Token = "0x4002A93")]
	[FieldOffset(Offset = "0x20")]
	private Types.BidCancellationType bidCancellationType_;

	[Token(Token = "0x17001A6E")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageParser<BakCancelBidRequest> Parser
	{
		[Token(Token = "0x6007801")]
		[Address(RVA = "0xC1D5A0", Offset = "0xC1C9A0", VA = "0x180C1D5A0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001A6F")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x6007802")]
		[Address(RVA = "0xC1D4F0", Offset = "0xC1C8F0", VA = "0x180C1D4F0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001A70")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x6007803")]
		[Address(RVA = "0xC1D5F0", Offset = "0xC1C9F0", VA = "0x180C1D5F0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001A71")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public long BidId
	{
		[Token(Token = "0x6007807")]
		[Address(RVA = "0x7D2760", Offset = "0x7D1B60", VA = "0x1807D2760")]
		get
		{
			return default(long);
		}
		[Token(Token = "0x6007808")]
		[Address(RVA = "0x918550", Offset = "0x917950", VA = "0x180918550")]
		set
		{
		}
	}

	[Token(Token = "0x17001A72")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public Types.BidCancellationType BidCancellationType
	{
		[Token(Token = "0x6007809")]
		[Address(RVA = "0x7F4130", Offset = "0x7F3530", VA = "0x1807F4130")]
		get
		{
			return default(Types.BidCancellationType);
		}
		[Token(Token = "0x600780A")]
		[Address(RVA = "0x7F4140", Offset = "0x7F3540", VA = "0x1807F4140")]
		set
		{
		}
	}

	[Token(Token = "0x6007804")]
	[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public BakCancelBidRequest()
	{
	}

	[Token(Token = "0x6007805")]
	[Address(RVA = "0x948CF0", Offset = "0x9480F0", VA = "0x180948CF0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public BakCancelBidRequest(BakCancelBidRequest other)
	{
	}

	[Token(Token = "0x6007806")]
	[Address(RVA = "0xC1D260", Offset = "0xC1C660", VA = "0x180C1D260", Slot = "10")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public BakCancelBidRequest Clone()
	{
		return null;
	}

	[Token(Token = "0x600780B")]
	[Address(RVA = "0xC1D2F0", Offset = "0xC1C6F0", VA = "0x180C1D2F0", Slot = "0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x600780C")]
	[Address(RVA = "0x9489C0", Offset = "0x947DC0", VA = "0x1809489C0", Slot = "9")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(BakCancelBidRequest other)
	{
		return default(bool);
	}

	[Token(Token = "0x600780D")]
	[Address(RVA = "0x948AA0", Offset = "0x947EA0", VA = "0x180948AA0", Slot = "2")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x600780E")]
	[Address(RVA = "0xC1D390", Offset = "0xC1C790", VA = "0x180C1D390", Slot = "3")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x600780F")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x6007810")]
	[Address(RVA = "0x948ED0", Offset = "0x9482D0", VA = "0x180948ED0", Slot = "12")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x6007811")]
	[Address(RVA = "0xC1D1A0", Offset = "0xC1C5A0", VA = "0x180C1D1A0", Slot = "7")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x6007812")]
	[Address(RVA = "0x948B30", Offset = "0x947F30", VA = "0x180948B30", Slot = "4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(BakCancelBidRequest other)
	{
	}

	[Token(Token = "0x6007813")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x6007814")]
	[Address(RVA = "0x948E20", Offset = "0x948220", VA = "0x180948E20", Slot = "11")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
