using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Job;

[Token(Token = "0x200035C")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class JobBookSubscriptionEvent : IMessage<JobBookSubscriptionEvent>, IMessage, IEquatable<JobBookSubscriptionEvent>, IDeepCloneable<JobBookSubscriptionEvent>, IBufferMessage
{
	[Token(Token = "0x200035D")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static class Types
	{
		[Token(Token = "0x200035E")]
		[DebuggerDisplay("{ToString(),nq}")]
		public sealed class Subscription : IMessage<Subscription>, IMessage, IEquatable<Subscription>, IDeepCloneable<Subscription>, IBufferMessage
		{
			[Token(Token = "0x4000B91")]
			[FieldOffset(Offset = "0x0")]
			private static readonly MessageParser<Subscription> _parser;

			[Token(Token = "0x4000B92")]
			[FieldOffset(Offset = "0x10")]
			private UnknownFieldSet _unknownFields;

			[Token(Token = "0x4000B93")]
			public const int JobIdFieldNumber = 1;

			[Token(Token = "0x4000B94")]
			[FieldOffset(Offset = "0x18")]
			private int jobId_;

			[Token(Token = "0x4000B95")]
			public const int SubscribedFieldNumber = 2;

			[Token(Token = "0x4000B96")]
			[FieldOffset(Offset = "0x1C")]
			private bool subscribed_;

			[Token(Token = "0x17000774")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			public static MessageParser<Subscription> Parser
			{
				[Token(Token = "0x60022D7")]
				[Address(RVA = "0x980150", Offset = "0x97F550", VA = "0x180980150")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000775")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public static MessageDescriptor Descriptor
			{
				[Token(Token = "0x60022D8")]
				[Address(RVA = "0x9800D0", Offset = "0x97F4D0", VA = "0x1809800D0")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000776")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
			{
				[Token(Token = "0x60022D9")]
				[Address(RVA = "0x9802E0", Offset = "0x97F6E0", VA = "0x1809802E0", Slot = "8")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000777")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public int JobId
			{
				[Token(Token = "0x60022DD")]
				[Address(RVA = "0x894410", Offset = "0x893810", VA = "0x180894410")]
				get
				{
					return default(int);
				}
				[Token(Token = "0x60022DE")]
				[Address(RVA = "0x894490", Offset = "0x893890", VA = "0x180894490")]
				set
				{
				}
			}

			[Token(Token = "0x17000778")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public bool Subscribed
			{
				[Token(Token = "0x60022DF")]
				[Address(RVA = "0x8F7940", Offset = "0x8F6D40", VA = "0x1808F7940")]
				get
				{
					return default(bool);
				}
				[Token(Token = "0x60022E0")]
				[Address(RVA = "0x928D40", Offset = "0x928140", VA = "0x180928D40")]
				set
				{
				}
			}

			[Token(Token = "0x60022DA")]
			[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			public Subscription()
			{
			}

			[Token(Token = "0x60022DB")]
			[Address(RVA = "0x980070", Offset = "0x97F470", VA = "0x180980070")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public Subscription(Subscription other)
			{
			}

			[Token(Token = "0x60022DC")]
			[Address(RVA = "0x97FC90", Offset = "0x97F090", VA = "0x18097FC90", Slot = "10")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public Subscription Clone()
			{
				return null;
			}

			[Token(Token = "0x60022E1")]
			[Address(RVA = "0x97FD60", Offset = "0x97F160", VA = "0x18097FD60", Slot = "0")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public override bool Equals(object other)
			{
				return default(bool);
			}

			[Token(Token = "0x60022E2")]
			[Address(RVA = "0x97FD20", Offset = "0x97F120", VA = "0x18097FD20", Slot = "9")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			public bool Equals(Subscription other)
			{
				return default(bool);
			}

			[Token(Token = "0x60022E3")]
			[Address(RVA = "0x97FDF0", Offset = "0x97F1F0", VA = "0x18097FDF0", Slot = "2")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public override int GetHashCode()
			{
				return default(int);
			}

			[Token(Token = "0x60022E4")]
			[Address(RVA = "0x97FF10", Offset = "0x97F310", VA = "0x18097FF10", Slot = "3")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public override string ToString()
			{
				return null;
			}

			[Token(Token = "0x60022E5")]
			[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public void WriteTo(CodedOutputStream output)
			{
			}

			[Token(Token = "0x60022E6")]
			[Address(RVA = "0x980260", Offset = "0x97F660", VA = "0x180980260", Slot = "12")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
			{
			}

			[Token(Token = "0x60022E7")]
			[Address(RVA = "0x97FC00", Offset = "0x97F000", VA = "0x18097FC00", Slot = "7")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public int CalculateSize()
			{
				return default(int);
			}

			[Token(Token = "0x60022E8")]
			[Address(RVA = "0x97FEB0", Offset = "0x97F2B0", VA = "0x18097FEB0", Slot = "4")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public void MergeFrom(Subscription other)
			{
			}

			[Token(Token = "0x60022E9")]
			[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			public void MergeFrom(CodedInputStream input)
			{
			}

			[Token(Token = "0x60022EA")]
			[Address(RVA = "0x9801A0", Offset = "0x97F5A0", VA = "0x1809801A0", Slot = "11")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
			{
			}
		}
	}

	[Token(Token = "0x4000B8C")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<JobBookSubscriptionEvent> _parser;

	[Token(Token = "0x4000B8D")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x4000B8E")]
	public const int SubscriptionsFieldNumber = 1;

	[Token(Token = "0x4000B8F")]
	[FieldOffset(Offset = "0x8")]
	private static readonly FieldCodec<Types.Subscription> _repeated_subscriptions_codec;

	[Token(Token = "0x4000B90")]
	[FieldOffset(Offset = "0x18")]
	private readonly RepeatedField<Types.Subscription> subscriptions_;

	[Token(Token = "0x17000770")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<JobBookSubscriptionEvent> Parser
	{
		[Token(Token = "0x60022C5")]
		[Address(RVA = "0x96A7D0", Offset = "0x969BD0", VA = "0x18096A7D0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000771")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x60022C6")]
		[Address(RVA = "0x96A720", Offset = "0x969B20", VA = "0x18096A720")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000772")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x60022C7")]
		[Address(RVA = "0x96A9E0", Offset = "0x969DE0", VA = "0x18096A9E0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000773")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<Types.Subscription> Subscriptions
	{
		[Token(Token = "0x60022CB")]
		[Address(RVA = "0x7D2760", Offset = "0x7D1B60", VA = "0x1807D2760")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x60022C8")]
	[Address(RVA = "0x96A6A0", Offset = "0x969AA0", VA = "0x18096A6A0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public JobBookSubscriptionEvent()
	{
	}

	[Token(Token = "0x60022C9")]
	[Address(RVA = "0x96A610", Offset = "0x969A10", VA = "0x18096A610")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public JobBookSubscriptionEvent(JobBookSubscriptionEvent other)
	{
	}

	[Token(Token = "0x60022CA")]
	[Address(RVA = "0x96A160", Offset = "0x969560", VA = "0x18096A160", Slot = "10")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public JobBookSubscriptionEvent Clone()
	{
		return null;
	}

	[Token(Token = "0x60022CC")]
	[Address(RVA = "0x96A2B0", Offset = "0x9696B0", VA = "0x18096A2B0", Slot = "0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x60022CD")]
	[Address(RVA = "0x96A220", Offset = "0x969620", VA = "0x18096A220", Slot = "9")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public bool Equals(JobBookSubscriptionEvent other)
	{
		return default(bool);
	}

	[Token(Token = "0x60022CE")]
	[Address(RVA = "0x9364E0", Offset = "0x9358E0", VA = "0x1809364E0", Slot = "2")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x60022CF")]
	[Address(RVA = "0x96A410", Offset = "0x969810", VA = "0x18096A410", Slot = "3")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x60022D0")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x60022D1")]
	[Address(RVA = "0x96A930", Offset = "0x969D30", VA = "0x18096A930", Slot = "12")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x60022D2")]
	[Address(RVA = "0x96A0C0", Offset = "0x9694C0", VA = "0x18096A0C0", Slot = "7")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x60022D3")]
	[Address(RVA = "0x96A390", Offset = "0x969790", VA = "0x18096A390", Slot = "4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(JobBookSubscriptionEvent other)
	{
	}

	[Token(Token = "0x60022D4")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x60022D5")]
	[Address(RVA = "0x96A820", Offset = "0x969C20", VA = "0x18096A820", Slot = "11")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
